using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;
using System.Data.Entity;
using Npgsql;
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using DXDBConvert.Lib;

namespace DataGridAX
{
    [ComVisible(true)]
    [Guid("DF72157B-8046-4D80-9179-895842D18BAF")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComDefaultInterface(typeof(IDataGridAX))]
    [ComSourceInterfaces(typeof(IDataGridAXEvents))]
    public partial class DataGridUI : UserControl, IDataGridAX
    {
        #region Свойства

        public DateTime SelectedDateFrom { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime SelectedDateTo { get; set; } = DateTime.Now;
        // строка подключения к БД PG
        public NpgsqlConnectionStringBuilder SqlBuilder { get; set; } = new NpgsqlConnectionStringBuilder();
        public string[] DataStringArray { get; set; } = new string[] { "S11_D01_BGD01_SQO", "S11_D01_BGD01_SQC", "S11_D01_BGD01_VALVE", "S11_D01_BGD01" };
        #endregion

        // конструктор
        public DataGridUI()
        {
            InitializeComponent();
            setDefaultConnectionStringData(); // устанавливаем подключения к БД по умолчанию


            dateNavigator1.DateTime = SelectedDateFrom;
            dateNavigator2.DateTime = SelectedDateTo;
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Minimum = 0;            
        }



        #region Методы
        // строка подключения передаваемая через СОМ-интерфейс
        public void getConnectionStringData(string Host, string Port, string Database, string Username, string Password)
        {
            SqlBuilder.Host = Host;
            SqlBuilder.Port = Int32.Parse(Port);
            SqlBuilder.Database = Database;
            SqlBuilder.Username = Username;
            SqlBuilder.Password = Password;
            SqlBuilder.Timeout = 50;
        }


        //Checking merge branches
        private void setDefaultConnectionStringData()
        {
            SqlBuilder.Host = "192.168.3.5";
            SqlBuilder.Port = Int32.Parse("5432");
            SqlBuilder.Database = "EventPicker";
            SqlBuilder.Username = "Al";
            SqlBuilder.Password = "kip12";
            SqlBuilder.Timeout = 50;
        }

        // поолучаем данные из БД
        private List<ActionExtended> GetDateFromDB(DateTime selectedDateFrom, DateTime selectedDateTo, string[] dataStringArray)
        {
            List<ActionExtended> unionTable;
            using (DBEventContext dbEv = new DBEventContext(SqlBuilder.ConnectionString))
            {

                unionTable = new List<ActionExtended>();
                int l = 1;
                ActionExtended.id = 0;
                for (int j = 0; j < dataStringArray.Length; j++)
                {
                    ushort hashCode = 0;
                    ushort p_pow = 1;

                    unchecked
                    {
                        for (int i = 0; i < dataStringArray[j].Length; i++)
                        {
                            hashCode += (ushort)(dataStringArray[j][i] * (short)p_pow);
                            p_pow = (ushort)((p_pow << 5) - p_pow);
                        }
                    }
                    var variableName = dataStringArray[j];
                    var unionTable2 = from a in dbEv.actionsEng
                                      join b in dbEv.actionsCodes on a.action_id equals b.action_id
                                      join c in dbEv.typesOfVars on b.type equals c.type_id
                                      join d in dbEv.dcsEvents.Where(ev => ev.hash == hashCode && ev.time >= selectedDateFrom && ev.time <= selectedDateTo).OrderBy(x => x.pick_id).Skip(0)/*.Take(100)*/
                                         on new { X1 = b.action, X2 = b.type } equals new { X1 = d.action, X2 = d.type }
                                      select new ActionExtended { VariableName = variableName, HashCode = d.hash, PickId = d.pick_id, TimeOfAction = d.time, Milliseconds = d.ms, ActionId = b.action_id, ActionType = b.type, ActionTypeDescription = c.description, Action = b.action, ActionDesc = a.description, ActionDescShort = a.description_short };

                    unionTable2.ForEach(el => unionTable.Add(el));
                    l++;
                }
                unionTable.Sort((x, y) => x.TimeOfAction.CompareTo(y.TimeOfAction));
            }
            return unionTable;
        }

        // инициализации таблицы
        private async void InitGridCintrol()
        {
            gridControl2.DataSource = await Task.Run(() => GetDateFromDB(SelectedDateFrom, SelectedDateTo, DataStringArray));
            gridControl2.Refresh();
        }

        private void testMerge() { }
        //Khrolenko
        private void TestMerge2()
        {
            
        }

        #endregion

        #region Регистрация класса в реестре
        [ComRegisterFunction()]
        public static void RegisterClass(string key)
        {
            // Удаляем HKEY_CLASSES_ROOT\ из переданного ключа
            StringBuilder sb = new StringBuilder(key);
            sb.Replace(@"HKEY_CLASSES_ROOT\", "");

            // Открываем ключ CLSID\{guid} в режиме записи
            RegistryKey k = Registry.ClassesRoot.OpenSubKey(sb.ToString(), true);

            // Создаем ключ элемента управления ActiveX – это позволяет ему появиться
            //в контейнере элемента управления ActiveX
            RegistryKey ctrl = k.CreateSubKey("Control");
            ctrl.Close();

            // Создаем запись CodeBase
            RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);
            inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase);
            inprocServer32.Close();

            // И в заключении закрываем ключ реестра 
            k.Close();
        }

        [ComUnregisterFunction()]
        public static void UnregisterClass(string key)
        {
            StringBuilder sb = new StringBuilder(key);
            sb.Replace(@"HKEY_CLASSES_ROOT\", "");

            // Открываем ключ HKCR\CLSID\{guid} в режиме записи
            RegistryKey k = Registry.ClassesRoot.OpenSubKey(sb.ToString(), true);

            // Удаляем ключ элемента управления ActiveX 
            k.DeleteSubKey("Control", false);

            // Затем открываем ключ InprocServer32
            RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);

            // Удаляем ключ CodeBase
            k.DeleteSubKey("CodeBase", false);

            // И в заключении закрываем ключ реестра
            k.Close();
        }
        #endregion


        #region События элементов управления
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //NpgsqlConnectionStringBuilder sqlBuilder = new NpgsqlConnectionStringBuilder();

            //CancellationTokenSource cts = new CancellationTokenSource();

            //Task.Run(() =>
            //{
            //    while (!cts.IsCancellationRequested)
            //    {
            //        progressBarControl1.Increment(10);
            //        if (progressBarControl1.Position >= progressBarControl1.Properties.Maximum)
            //        {
            //            progressBarControl1.Position = 0;
            //        }

            //        progressBarControl1.Update();
            //        Thread.Sleep(150);
            //    }
            //}, cts.Token).ContinueWith(o => progressBarControl1.Position = 0);

            //string[] variablesArray = new string[] { "S11_D01_BGD01_SQO", "S11_D01_BGD01_SQC", "S11_D01_BGD01_VALVE", "S11_D01_BGD01" };


            SelectedDateFrom = dateNavigator1.DateTime/*.Add(timeEdit1.Time.TimeOfDay)*/;
            SelectedDateTo   = dateNavigator2.DateTime/*.Add(timeEdit2.Time.TimeOfDay)*/;
            

            if (SelectedDateFrom > SelectedDateTo)
            {
                MessageBox.Show("Start Date is more than End Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InitGridCintrol();
        }           

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dateNavigator1.Visible = !dateNavigator1.Visible;
            dateNavigator2.Visible = false;
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dateNavigator2.Visible = !dateNavigator2.Visible;
            dateNavigator1.Visible = false;            
        }

        private void dateNavigator1_DateTimeCommit(object sender, EventArgs e)
        {
            DatePicker_1.Text = dateNavigator1.DateTime.ToString("dd.MM.yyyy");
            dateNavigator1.Visible = false;
        }

        private void dateNavigator2_DateTimeCommit(object sender, EventArgs e)
        {
            DatePicker_2.Text = dateNavigator2.DateTime.ToString("dd.MM.yyyy");
            dateNavigator2.Visible = false;
        }

        private void dateNavigator1_DateTimeChanged(object sender, EventArgs e)
        {
            DatePicker_1.Text = dateNavigator1.DateTime.ToString("dd.MM.yyyy");
        }

        private void dateNavigator2_DateTimeChanged(object sender, EventArgs e)
        {
            DatePicker_2.Text = dateNavigator2.DateTime.ToString("dd.MM.yyyy");
        }

        private void timeSpanEdit1_EditValueChanged(object sender, EventArgs e)
        {

            timeEdit2.Time = dateNavigator2.DateTime = DateTime.Now;
            timeEdit1.Time = dateNavigator1.DateTime = dateNavigator2.DateTime.Subtract(timeSpanEdit1.TimeSpan);          

        }

        private void timeEdit1_EditValueChanged(object sender, EventArgs e)
        {
            dateNavigator1.DateTime = DateTime.Today.Add(timeEdit1.Time.TimeOfDay);
        }

        private void timeEdit2_EditValueChanged(object sender, EventArgs e)
        {
            dateNavigator2.DateTime = DateTime.Today.Add(timeEdit2.Time.TimeOfDay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBarControl1.Properties.Minimum += 2;            
            //progressBarControl1.PerformStep();
            progressBarControl1.Increment(5);            
            if (progressBarControl1.Position >= progressBarControl1.Properties.Maximum)
            {
                progressBarControl1.Position = 0;                
            }
                
            progressBarControl1.Update();


        }

        #endregion

        private void gridControl2_Load(object sender, EventArgs e)
        {
            InitGridCintrol();
        }
    }
}

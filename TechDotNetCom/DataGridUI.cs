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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;

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

        Progress<int> progress;
        bool cancelBool;
        #endregion

        #region Поля
        
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
            progressBarControl1.Width = 80;
            progressBarControl1.Position = 100;

            progress = new Progress<int>(percent =>
            {
                progressBarControl1.Position = percent;
            });          

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


        // строка подключения по умолчанию
        private void setDefaultConnectionStringData()
        {
            SqlBuilder.Host = "192.168.1.131";
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
                                      join d in dbEv.dcsEvents.Where(ev => ev.hash == hashCode && ev.time >= selectedDateFrom && ev.time <= selectedDateTo).OrderBy(x => x.pick_id).Skip(0)
                                         on new { X1 = b.action, X2 = b.type } equals new { X1 = d.action, X2 = d.type }
                                      select new ActionExtended { VariableName = variableName, HashCode = d.hash, PickId = d.pick_id, TimeOfAction = d.time, Milliseconds = d.ms, ActionId = b.action_id, ActionType = b.type, ActionTypeDescription = c.description, Action = b.action, ActionDesc = a.description, ActionDescShort = a.description_short };

                    unionTable2.ForEach(el => unionTable.Add(el));
                    l++;
                }
                unionTable.Sort((x, y) => x.PickId.CompareTo(y.PickId));
            }
            return unionTable;
        }

        // инициализации таблицы
        private async void InitGridCintrol()
        {
            //Запускаем прорисовку ProgressBar'а
            _ = Task.Run(() => ProgressBarUpdate(progress)).ContinueWith(o => MessageBox.Show("Data has been read successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information));

            //Обнновляем DataGrid
            gridControl2.DataSource = await Task.Run(() => GetDateFromDB(SelectedDateFrom, SelectedDateTo, DataStringArray));
            gridControl2.Refresh();


            //Отменяем прорисовку ProgressBar'а
            cancelBool = true;

            gridConditions();
        }

        private void gridConditions()
        {
            gridView2.BeginDataUpdate();

            // прячем колонки -------------------------------------
            gridView2.Columns["Id"].Visible = false;
            gridView2.Columns["HashCode"].Visible = false;
            gridView2.Columns["PickId"].Visible = false;
            gridView2.Columns["Milliseconds"].Visible = false;
            gridView2.Columns["Action"].Visible = false;
            //gridView2.Columns["ActionId"].Visible = false;
            gridView2.Columns["ActionType"].Visible = false;
            gridView2.Columns["ActionTypeDescription"].Visible = false;
            //gridView2.Columns["ActionDescShort"].Visible = false;
            // ----------------------------------------------------


            // отобрает картинки в ячейках ------------------------
            var AItextEdit = new RepositoryItemTextEdit();
            var AOtextEdit = new RepositoryItemTextEdit();
            var DItextEdit = new RepositoryItemTextEdit();
            var DOtextEdit = new RepositoryItemTextEdit();
            var ATVtextEdit = new RepositoryItemTextEdit();
            var VGDtextEdit = new RepositoryItemTextEdit();
            var MtextEdit = new RepositoryItemTextEdit();

            AItextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("AI");
            AOtextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("AO");
            DItextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("DI");
            DOtextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("DO");
            ATVtextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("ATV");
            VGDtextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("VGD");
            MtextEdit.ContextImageOptions.Image = svgImageCollection1.GetImage("M");

            gridView2.CustomRowCellEdit += (sender, e) => {
                GridView view = sender as GridView;
                int _actionType = (int)view.GetRowCellValue(e.RowHandle, "ActionType");
                if (e.Column.FieldName == "VariableName")
                {
                    switch (_actionType)
                    {
                        case (int)EditType.AI:
                            e.RepositoryItem = AItextEdit;
                            break;
                        case (int)EditType.AO:
                            e.RepositoryItem = AOtextEdit;
                            break;
                        case (int)EditType.DI:
                            e.RepositoryItem = DItextEdit;
                            break;
                        case (int)EditType.DO:
                            e.RepositoryItem = DOtextEdit;
                            break;
                        case (int)EditType.ATV:
                            e.RepositoryItem = ATVtextEdit;
                            break;
                        case (int)EditType.VGD:
                            e.RepositoryItem = VGDtextEdit;
                            break;
                        case (int)EditType.M:
                            e.RepositoryItem = MtextEdit;
                            break;
                        default:                            
                            break;
                    }
                }
            };
            // ----------------------------------------------------

            // Меняем цвет ячейки ---------------------------------
            gridView2.RowCellStyle += (sender, e) =>
            {
                GridView view = sender as GridView;
                int _action = (int)view.GetRowCellValue(e.RowHandle, "Action");
                if (e.Column.FieldName == "ActionDesc")
                {
                    // красным цветом
                    if (_action == 9 || _action == 12 || _action == 13 || _action == 15 || _action == 41 || _action == 44 || _action == 45 || _action == 47 || _action == 69)
                    {
                        e.Appearance.BackColor = Color.IndianRed;
                    }

                    // желтым цветом
                    if (_action == 5 || _action == 10 || _action == 11 || _action == 14 || _action == 38 || _action == 42 || _action == 43 || _action == 46 || _action == 100)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                    }
                    //e.Appearance.TextOptions.HAlignment = _action == 3 ? HorzAlignment.Far : HorzAlignment.Near;
                }
            };
            // ----------------------------------------------------

            gridView2.EndDataUpdate();
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

            SelectedDateFrom = dateNavigator1.DateTime;
            SelectedDateTo = dateNavigator2.DateTime;


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
            (rangeControl1.Client as DateTimeRangeControlClient).Minimum = dateNavigator1.DateTime.AddDays(-10);
        }

        private void dateNavigator2_DateTimeCommit(object sender, EventArgs e)
        {
            DatePicker_2.Text = dateNavigator2.DateTime.ToString("dd.MM.yyyy");
            dateNavigator2.Visible = false;
            (rangeControl1.Client as DateTimeRangeControlClient).Maximum = dateNavigator2.DateTime.AddDays(10);
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
            
            //panel2.Left = panel1.Left;
        }

        //Метод для обновления прогрессбара
        private void ProgressBarUpdate(IProgress<int> progress)
        {
            while (!cancelBool)
            {
                if (progressBarControl1.Left >= panel1.Width)
                    progressBarControl1.Left = 0;
                else
                    progressBarControl1.Left += 30;
                Thread.Sleep(50);
            }

            cancelBool = false;
            progressBarControl1.Left = progressBarControl1.Width * -1;

        }

        #endregion

        private void gridControl2_Load(object sender, EventArgs e)
        {
            InitGridCintrol();
        }

        #region Enum
        enum EditType : int
        {
            AI = 1,
            AO = 2,
            DI = 3,
            DO = 4,
            ATV = 5,
            VGD = 6,
            M = 7
        }
        #endregion

        private void rangeControl1_RangeChanged(object sender, RangeControlRangeEventArgs range)
        {
            dateNavigator1.DateTime = (DateTime)rangeControl1.SelectedRange.Minimum;
            dateNavigator2.DateTime = (DateTime)rangeControl1.SelectedRange.Maximum;
        }
    }
}

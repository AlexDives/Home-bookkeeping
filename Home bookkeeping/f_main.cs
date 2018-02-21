using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Home_bookkeeping
{
    public partial class F_Main : Form
    {

        public FbConnection fbConn;
        DataTable dt_query;
        public F_Main()
        {
            InitializeComponent();
            f_About fa = new f_About();
            tSSL_ProgVers.Text = String.Format("v{0}", fa.AssemblyVersion);
        }

        private void RefreshObject(bool add)
        {
            if (add)
            {
                b_add.Enabled = false;
                b_save.Enabled = true;
                b_cancel.Enabled = true; 
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                p_top.Height = 70;
                DateTime mon = new DateTime();
                if (mon.Month !=
                    ((Convert.ToInt32(QuerySel("select count(id) from planning where closse = 0 ").Rows[0][0]) == 0) ? mon.Month :
                    Convert.ToInt32(QuerySel("select max(mounth_aciv) from planning where closse = 0 ").Rows[0][0])))
                {
                    b_CloseMounth.Enabled = true;
                }
                else
                {
                    b_add_stat.Enabled = false;
                    b_save_stat.Enabled = true;
                    b_cancel_stat.Enabled = true;
                    groupBox4.Visible = true;
                    groupBox5.Visible = true;
                    groupBox6.Visible = true;
                    b_CloseMounth.Enabled = false;
                    p_top_stat.Height = 70;
                } 
            }
            else
            {
                b_add.Enabled = true;
                b_save.Enabled = false;
                b_cancel.Enabled = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                p_top.Height = 30;
                DateTime mon = new DateTime();
                if (mon.Month != 
                    ((Convert.ToInt32(QuerySel("select count(id) from planning where closse = 0 ").Rows[0][0]) == 0)? mon.Month :
                    Convert.ToInt32(QuerySel("select max(mounth_aciv) from planning where closse = 0 ").Rows[0][0])))
                {
                    b_CloseMounth.Enabled = true;
                }
                else
                {
                    b_add_stat.Enabled = true;
                    b_save_stat.Enabled = false;
                    b_cancel_stat.Enabled = false;
                    groupBox4.Visible = false;
                    groupBox5.Visible = false;
                    groupBox6.Visible = false;
                    b_CloseMounth.Enabled = false;
                    p_top_stat.Height = 30;
                }
            }
            
        }
        public void DB_Connect()
        {
            // формируем connection string для последующего соединения с нашей базой данных
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
            fb_con.Charset = "WIN1251"; //используемая кодировка
            fb_con.UserID = "SYSDBA"; //логин
            fb_con.Password = "masterkey"; //пароль
            fb_con.Database = "localhost:db"; //путь к файлу базы данных
            fb_con.Dialect = 3;
            fb_con.ServerType = FbServerType.Embedded; //указываем тип сервера (0 - "полноценный Firebird" (classic или super server), 1 - встроенный (embedded))

            //создаем подключение
            fbConn = new FbConnection(fb_con.ToString()); //передаем нашу строку подключения объекту класса FbConnection

            fbConn.Open(); //открываем БД

            //пока у объекта БД не был вызван метод Open() - никакой информации о БД не получить, будет только ошибка
            
        }
        public bool QueryExec(string text)
        {
           // MessageBox.Show(text);
            //выполним запрос на вставку
            FbCommand InsertSQL = new FbCommand(text, fbConn);

            if (fbConn.State == ConnectionState.Closed) //если соединение закрыто - откроем его; Перечисление ConnectionState содержит состояния соединения (подключено/отключено)
                fbConn.Open();
            FbTransaction fbt = fbConn.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
            InsertSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта InsertSQL
            int res = 0;
            try
            {
                res = InsertSQL.ExecuteNonQuery(); //для запросов, не возвращающих набор данных (insert, update, delete) надо вызывать этот метод
                fbt.Commit(); //если вставка прошла успешно - комитим транзакцию
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InsertSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать объекты этого типа, если они больше не нужны
            if (res == 1) return true;
            else return false;
        }
        public DataTable QuerySel(string select)
        {
            DataTable dt_tmp = new DataTable();
            DB_Connect();
            if (fbConn.State == ConnectionState.Closed)
                fbConn.Open();

            FbCommand cmd = new FbCommand(select, fbConn);
            try
            {
                cmd.CommandType = CommandType.Text;
                FbDataReader dr = cmd.ExecuteReader();
                dt_tmp.Load(dr);
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt_tmp;
        }
        private void MoveGrid(string text, Control parent)
        {
            parent.Visible = false;
            grid_main.Parent = parent;
            grid_main.Dock = DockStyle.Fill;
            grid_main.DataSource = QuerySel(text);

            if (grid_main.Columns.Contains("id"))
            {
                grid_main.Columns["id"].HeaderText = "№";
                grid_main.Columns["id"].Width = 40;
                grid_main.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (grid_main.Columns.Contains("comment"))
            {
                grid_main.Columns["comment"].HeaderText = "Наименование";
                grid_main.Columns["comment"].Width = 300;
                grid_main.Columns["comment"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            if (grid_main.Columns.Contains("summa"))
            {
                grid_main.Columns["summa"].HeaderText = "Сумма";
                grid_main.Columns["summa"].Width = 100;
                grid_main.Columns["summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid_main.Columns["summa"].DefaultCellStyle.Format = "N2";
            }
            if (grid_main.Columns.Contains("views"))
            {
                grid_main.Columns["views"].HeaderText = "Бюджет";
                grid_main.Columns["views"].Width = 75;
                grid_main.Columns["views"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (grid_main.Columns.Contains("valute"))
            {
                grid_main.Columns["valute"].HeaderText = "Валюта";
                grid_main.Columns["valute"].Width = 100;
                grid_main.Columns["valute"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (grid_main.Columns.Contains("costs"))
            {
                grid_main.Columns["costs"].HeaderText = "Вид расходов";
                grid_main.Columns["costs"].Width = 100;
                grid_main.Columns["costs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (grid_main.Columns.Contains("name"))
            {
                grid_main.Columns["name"].HeaderText = "Наименование";
                grid_main.Columns["name"].Width = 200;
                grid_main.Columns["name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (grid_main.Columns.Contains("balance"))
            {
                grid_main.Columns["balance"].HeaderText = "Баланс";
                grid_main.Columns["balance"].Width = 100;
                grid_main.Columns["balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (grid_main.Columns.Contains("need_summa"))
            {
                grid_main.Columns["need_summa"].HeaderText = "Требуемая сумма";
                grid_main.Columns["need_summa"].Width = 125;
                grid_main.Columns["need_summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (grid_main.Columns.Contains("fix_summa"))
            {
                grid_main.Columns["fix_summa"].HeaderText = "Закрепленная сумма";
                grid_main.Columns["fix_summa"].Width = 125;
                grid_main.Columns["fix_summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (grid_main.Columns.Contains("date_crt"))     grid_main.Columns["date_crt"].HeaderText = "Дата"; 
            if (grid_main.Columns.Contains("view_id"))      grid_main.Columns["view_id"].Visible = false; 
            if (grid_main.Columns.Contains("fix_objects"))  grid_main.Columns["fix_objects"].Visible = false; 
            if (grid_main.Columns.Contains("valute_id"))    grid_main.Columns["valute_id"].Visible = false; 

            if (parent.Name == "p_main")
            {
                for (int i = 0; i < grid_main.RowCount; i++)
                    if (Convert.ToDouble(grid_main[grid_main.Columns["need_summa"].Index, i].Value) <=
                        Convert.ToDouble(grid_main[grid_main.Columns["fix_summa"].Index, i].Value))
                    {
                        grid_main[grid_main.Columns["fix_summa"].Index, i].Style.BackColor = Color.LightGreen;
                        grid_main[grid_main.Columns["need_summa"].Index, i].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        grid_main[grid_main.Columns["fix_summa"].Index, i].Style.BackColor = Color.PaleVioletRed;
                        grid_main[grid_main.Columns["need_summa"].Index, i].Style.BackColor = Color.PaleVioletRed;
                    }
                grid_main.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            }
            else
            {
                if (grid_main.Columns.Contains("view_id"))
                {
                    for (int i = 0; i < grid_main.RowCount; i++)
                        if (Convert.ToInt32(grid_main[grid_main.Columns["view_id"].Index, i].Value) == 1)
                            grid_main[grid_main.Columns["views"].Index, i].Style.BackColor = Color.LightGreen;
                        else grid_main[grid_main.Columns["views"].Index, i].Style.BackColor = Color.PaleVioletRed;
                    grid_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            parent.Visible = true;
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            DB_Connect();
        }

        private void menu_InfoProject_Click(object sender, EventArgs e)
        {
            f_About f_a = new f_About();
            f_a.ShowDialog();
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Refresh_Click(object sender, EventArgs e)
        {
            tabControl1_Selected(sender, null);
        }

        private void F_Main_Shown(object sender, EventArgs e)
        {
            //menu_Refresh_Click(sender, e);
        }

        private void menu_Help_Click(object sender, EventArgs e)
        {

        }

        private void grid_main_Sorted(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedTab.Name == "tp_main") || (tabControl1.SelectedTab.Name == "tp_gain") ||
                (tabControl1.SelectedTab.Name == "tp_costs"))
                for (int i = 0; i < grid_main.RowCount; i++)
                    if (Convert.ToInt32(grid_main[grid_main.Columns["view_id"].Index, i].Value) == 1)
                        grid_main[grid_main.Columns["views"].Index, i].Style.BackColor = Color.LightGreen;
                    else grid_main[grid_main.Columns["views"].Index, i].Style.BackColor = Color.PaleVioletRed;

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tp_main")
                MoveGrid("select id, comment, views, summa, "
                + " valute, costs, date_crt, view_id from get_money "
                + " order by date_crt desc", tp_main);
            else if (tabControl1.SelectedTab.Name == "tp_gain")
                MoveGrid("select id, comment, views, summa, "
                + " valute, costs, date_crt, view_id from get_money "
                + " where view_id = 1 "
                + " order by date_crt desc", tp_gain);
            else if (tabControl1.SelectedTab.Name == "tp_costs")
                MoveGrid("select id, comment, views, summa, "
                + " valute, costs, date_crt, view_id from get_money "
                + " where view_id = 2 "
                + " order by date_crt desc", tp_costs);
            else if (tabControl1.SelectedTab.Name == "tp_object")
            {
                MoveGrid("select o.id, o.name, o.need_summa, o.fix_summa, b.summa as balance, o.fix_objects, "
                + " val.name as valute, o.date_crt, o.valute_id from objects o "
                + " left join type_valute val on val.id = o.valute_id "
                + " left join balance b on b.valute_id = val.id "
                + " order by o.date_crt desc", p_main);

                dt_query = QuerySel("select id, name from type_valute order by id");
                cb_valute.Items.Clear();
                for (int i = 0; i < dt_query.Rows.Count; i++)
                    cb_valute.Items.Add(dt_query.Rows[i]["name"] as string);
                RefreshObject(false);
            }
            else if (tabControl1.SelectedTab.Name == "tb_planning")
            {
                dgv_plan.DataSource = QuerySel("select p.id, p.name, p.summa, p.summa_ost, tp.name as valute, tm.name as mounth " +
                                               " from planning p " +
                                               " left join type_valute tp on tp.id = p.valute_id " +
                                               " left join type_mounth tm on tm.id = p.mounth_aciv " +
                                               " where p.closse = 0");
                dt_query = QuerySel("select id, name from type_valute order by id");
                cb_valute_plan.Items.Clear();
                for (int i = 0; i < dt_query.Rows.Count; i++)
                    cb_valute_plan.Items.Add(dt_query.Rows[i]["name"] as string);

                if (dgv_plan.Columns.Contains("id")) dgv_plan.Columns["id"].Visible = false;
                if (dgv_plan.Columns.Contains("name"))
                {
                    dgv_plan.Columns["name"].HeaderText = "Наименование планирования";
                    dgv_plan.Columns["name"].Width = 200;
                    dgv_plan.Columns["name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                if (dgv_plan.Columns.Contains("summa"))
                {
                    dgv_plan.Columns["summa"].HeaderText = "План. баланс";
                    dgv_plan.Columns["summa"].Width = 60;
                    dgv_plan.Columns["summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgv_plan.Columns.Contains("summa_ost"))
                {
                    dgv_plan.Columns["summa_ost"].HeaderText = "Ост. баланс";
                    dgv_plan.Columns["summa_ost"].Width = 60;
                    dgv_plan.Columns["summa_ost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgv_plan.Columns.Contains("valute"))
                {
                    dgv_plan.Columns["valute"].HeaderText = "Валюта";
                    dgv_plan.Columns["valute"].Width = 100;
                    dgv_plan.Columns["valute"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                if (dgv_plan.Columns.Contains("mounth"))
                {
                    dgv_plan.Columns["mounth"].HeaderText = "Месяц";
                    dgv_plan.Columns["mounth"].Width = 100;
                    dgv_plan.Columns["mounth"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                RefreshObject(false);
            }
            else if (tabControl1.SelectedTab.Name == "tp_statistic")
            {
                dgv_stats.DataSource = QuerySel("select b.id, v.full_name as name, b.summa, " +
                                                " (select sum(o.fix_summa) from objects o where o.valute_id = b.valute_id) as fix_summa, " +
                                                " (select sum(p.summa) from planning p where (p.valute_id = b.valute_id) and (p.closse = 0)) as plan_summa " +
                                                " from balance b " + 
                                                " left join type_valute v on v.id=b.valute_id " +
                                                " order by b.id ");
                if (dgv_stats.Columns.Contains("id")) dgv_stats.Columns["id"].Visible = false;
                if (dgv_stats.Columns.Contains("name"))
                {
                    dgv_stats.Columns["name"].HeaderText = "Валюта";
                    dgv_stats.Columns["name"].Width = 100;
                    dgv_stats.Columns["name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                if (dgv_stats.Columns.Contains("summa"))
                {
                    dgv_stats.Columns["summa"].HeaderText = "Баланс";
                    dgv_stats.Columns["summa"].Width = 60;
                    dgv_stats.Columns["summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgv_stats.Columns.Contains("fix_summa"))
                {
                    dgv_stats.Columns["fix_summa"].HeaderText = "Резерв. сумма";
                    dgv_stats.Columns["fix_summa"].Width = 60;
                    dgv_stats.Columns["fix_summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgv_stats.Columns.Contains("plan_summa"))
                {
                    dgv_stats.Columns["plan_summa"].HeaderText = "План. сумма";
                    dgv_stats.Columns["plan_summa"].Width = 60;
                    dgv_stats.Columns["plan_summa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }                
            }
            if (grid_main.RowCount == 0 && grid_main.Focused)
            {
                menu_Delete.Enabled = false;
                menu_Edit.Enabled = false;
            }
            else if (dgv_plan.RowCount == 0 && dgv_plan.Focused)
            {
                menu_Delete.Enabled = false;
                menu_Edit.Enabled = false;
            }
            else
            {
                menu_Delete.Enabled = true;
                menu_Edit.Enabled = true;
            }
        }

        private void menu_Add_Click(object sender, EventArgs e)
        {
            if (grid_main.Parent.Name == "p_main")
                b_add_Click(null, null);
            else
            {
                f_AddAndEdit f_add = new f_AddAndEdit();
                f_add.numRow = 0;
                f_add.Text = "Добавить";
                f_add.ShowDialog();
                
                Enabled = false;
                menu_Refresh_Click(sender, e);
                Enabled = true;
                f_add.Dispose();
            }
        }

        private void menu_Delete_Click(object sender, EventArgs e)
        {
            if (grid_main.Parent.Name == "p_main")
            {
                if (MessageBox.Show("Подтвердите удаление!", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    if (QueryExec("delete from objects where id = " + grid_main[grid_main.Columns["id"].Index, grid_main.CurrentRow.Index].Value) == true)
                        MessageBox.Show("Запись успешно удалена!");
            }
            else if (tabControl1.SelectedTab.Name == "tb_planning")
            {
                if (MessageBox.Show("Подтвердите удаление!", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    if (QueryExec("delete from planning where id = " + dgv_plan[dgv_plan.Columns["id"].Index, dgv_plan.CurrentRow.Index].Value) == true)
                        MessageBox.Show("Запись успешно удалена!");
            }
            else
            {
                if (MessageBox.Show("Подтвердите удаление!", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    if (QueryExec("delete from money where id = " + grid_main[grid_main.Columns["id"].Index, grid_main.CurrentRow.Index].Value) == true)
                        MessageBox.Show("Запись успешно удалена!");

            }
            menu_Refresh_Click(sender, e);
        }

        private void menu_Edit_Click(object sender, EventArgs e)
        {
            f_AddAndEdit f_edit = new f_AddAndEdit();
            f_edit.numRow = Convert.ToInt32(grid_main[grid_main.Columns["id"].Index, grid_main.CurrentRow.Index].Value);
            f_edit.Text = "Редактировать";
            f_edit.ShowDialog();
            f_edit.numRow = 0;
            Enabled = false;
            menu_Refresh_Click(sender, e);
            Enabled = true;
            f_edit.Dispose();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            RefreshObject(true);
        }

        private void b_canel_Click(object sender, EventArgs e)
        {
            RefreshObject(false);
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            int valute_id;
            dt_query = QuerySel("select id from type_valute where name = '" + cb_valute.Text + "'");
            valute_id = Convert.ToInt32(dt_query.Rows[0][0]);
            if (QueryExec("INSERT INTO OBJECTS(ID, NAME, NEED_SUMMA, VALUTE_ID, FIX_SUMMA) "
                + " VALUES(null, '" + tb_name.Text + "', " + Convert.ToString(tb_summa.Text) + ", "  
                + valute_id + ", 0)") == true)
                MessageBox.Show("Цель успешно добавлена!");
            RefreshObject(false);
            menu_Refresh_Click(sender, e);
        }

        private void b_fix_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(grid_main[grid_main.Columns["balance"].Index, grid_main.CurrentRow.Index].Value) >= Convert.ToDouble(tb_FixSumma.Text))
            {
                if (QueryExec("UPDATE OBJECTS SET FIX_SUMMA = (FIX_SUMMA + " + tb_FixSumma.Text + ") where ID = " +
                Convert.ToInt32(grid_main[grid_main.Columns["id"].Index, grid_main.CurrentRow.Index].Value)) == true)
                   if (QueryExec("UPDATE BALANCE SET SUMMA = (SUMMA - " + tb_FixSumma.Text + ") where valute_id = " +
                       grid_main[grid_main.Columns["valute_id"].Index, grid_main.CurrentRow.Index].Value) == true)
                        MessageBox.Show("Сумма успешно перемещена!");
            }
            else MessageBox.Show("Сумма превышает баланс!");
            menu_Refresh_Click(sender, e);
        }

        private void grid_main_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_main.Columns.Contains("BALANCE"))
            {
                if (Convert.ToDouble(grid_main[grid_main.Columns["BALANCE"].Index, grid_main.CurrentRow.Index].Value) != 0)
                {
                    if (Convert.ToDouble(grid_main[grid_main.Columns["need_summa"].Index, grid_main.CurrentRow.Index].Value) >
                        Convert.ToDouble(grid_main[grid_main.Columns["fix_summa"].Index, grid_main.CurrentRow.Index].Value))
                    {
                        if ((Convert.ToDouble(grid_main[grid_main.Columns["need_summa"].Index, grid_main.CurrentRow.Index].Value) -
                             Convert.ToDouble(grid_main[grid_main.Columns["fix_summa"].Index, grid_main.CurrentRow.Index].Value)) >
                             Convert.ToDouble(grid_main[grid_main.Columns["balance"].Index, grid_main.CurrentRow.Index].Value))
                        {
                            tb_FixSumma.Text = Convert.ToString(grid_main[grid_main.Columns["balance"].Index, grid_main.CurrentRow.Index].Value);
                        }
                        else
                            tb_FixSumma.Text = Convert.ToString((Convert.ToDouble(grid_main[grid_main.Columns["need_summa"].Index, grid_main.CurrentRow.Index].Value) -
                                                                 Convert.ToDouble(grid_main[grid_main.Columns["fix_summa"].Index, grid_main.CurrentRow.Index].Value)));
                    }
                    b_fix.Enabled = true;
                }
                else
                {
                    b_fix.Enabled = false;
                    tb_FixSumma.Text = "0";
                }
                if (Convert.ToDouble(grid_main[grid_main.Columns["fix_summa"].Index, grid_main.CurrentRow.Index].Value) != 0)
                {
                    b_UnFix.Enabled = true;
                }
                else
                {
                    b_UnFix.Enabled = false;
                }
            }            
        }

        private void F_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            fbConn.Dispose();
        }

        private void b_UnFix_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(grid_main[grid_main.Columns["FIX_SUMMA"].Index, grid_main.CurrentRow.Index].Value) >= Convert.ToDouble(tb_FixSumma.Text))
            {
                if (QueryExec("UPDATE OBJECTS SET FIX_SUMMA = (FIX_SUMMA - " + tb_FixSumma.Text + ") where ID = " +
                Convert.ToInt32(grid_main[grid_main.Columns["id"].Index, grid_main.CurrentRow.Index].Value)) == true)
                    if (QueryExec("UPDATE BALANCE SET SUMMA = (SUMMA + " + tb_FixSumma.Text + ") where valute_id = " +
                            grid_main[grid_main.Columns["valute_id"].Index, grid_main.CurrentRow.Index].Value) == true)
                        MessageBox.Show("Сумма успешно снята!");
            }
            else MessageBox.Show("Сумма превышает \"зафиксированную сумму\"!");
            menu_Refresh_Click(sender, e);
        }

        private void b_add_stat_Click(object sender, EventArgs e)
        {
            RefreshObject(true);
        }

        private void b_save_stat_Click(object sender, EventArgs e)
        {
            int valute_id;
            DateTime mon = new DateTime();
            
            dt_query = QuerySel("select id from type_valute where name = '" + cb_valute_plan.Text + "'");
            valute_id = Convert.ToInt32(dt_query.Rows[0][0]);

            if (QueryExec("INSERT INTO PLANNING(NAME, SUMMA, VALUTE_ID, MOUNTH_ACIV) "
                + " VALUES('" + tb_name_plan.Text + "', " + Convert.ToString(tb_summ_plan.Text) + ", "
                + valute_id + ", " + mon.Month + ")") == true)
                MessageBox.Show("План успешно добавлен!");
            RefreshObject(false);
            menu_Refresh_Click(sender, e);
        }

        private void b_cancel_stat_Click(object sender, EventArgs e)
        {
            RefreshObject(false);
        }

        private void b_CloseMounth_Click(object sender, EventArgs e)
        {
            if (QueryExec("UPDATE PLANNING SET CLOSSE = 1 where CLOSSE = 0") == true)
                MessageBox.Show("Месяц успешно закрыт! Можете добавить новые планы");
        }
    }
}
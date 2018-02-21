using System;
using System.Data;
using System.Windows.Forms;

namespace Home_bookkeeping
{
    public partial class f_AddAndEdit : Form
    {
        DataTable dt_query;
        public int numRow;
        public f_AddAndEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Main f_main = new F_Main();
            int view_id, valute_id, costs_id = 0;
            dt_query = f_main.QuerySel("select id from type_views where name = '" + cb_view.Text + "'");
            view_id = Convert.ToInt32(dt_query.Rows[0][0]);
            dt_query = f_main.QuerySel("select id from type_valute where name = '" + cb_valute.Text + "'");
            valute_id = Convert.ToInt32(dt_query.Rows[0][0]);
            if (groupBox7.Visible)
            {
                if (rb_osn.Checked)
                    dt_query = f_main.QuerySel("select id from type_costs where name = '" + cb_costs.Text + "'");
                else if (rb_plan.Checked)
                    dt_query = f_main.QuerySel("select id from planning where name = '" + cb_costs.Text + "' and closse = 0");

                costs_id = Convert.ToInt32(dt_query.Rows[0][0]);
            }
            if (numRow != 0)
            {
                if (f_main.QueryExec("UPDATE MONEY SET " +
                                     " COMMENT = '" + tb_comment.Text + "', " +
                                     " VIEW_ID = " + view_id + ", " +
                                     " SUMMA = '" + Convert.ToString(tb_summa.Text) + "', " +
                                     " VALUTE_ID = " + valute_id + ", " +
                                     " date_crt = '" + dtp_date.Value + "' " + 
                                     ((groupBox7.Visible)?", costs_id = " + costs_id:", costs_id = 0 ") +
                                     ((rb_plan.Checked) ? ", planning_id = 1 ": ", planning_id = 0 ") +
                                     " where id = " + numRow) == true)
                    MessageBox.Show("Запись успешно обновлена!");

            }
            else
            {
                if (f_main.QueryExec("INSERT INTO MONEY (ID, COMMENT, VIEW_ID, SUMMA, VALUTE_ID, DATE_CRT, COSTS_ID, PLANNING_ID) "
                + " VALUES(null, '" + tb_comment.Text + "', " + view_id + ", " + Convert.ToString(tb_summa.Text)
                + "," + valute_id + ", '" + dtp_date.Value.ToString("dd.MM.yyyy hh:mm:ss") + "' " + ((groupBox7.Visible) ? ", " + costs_id : ", 0 ")
                + ((rb_plan.Checked) ? ", 1 )" : ", 0 )")) == true)
                    MessageBox.Show("Запись успешно добавлена!");
            }
        }

        private void f_AddAndEdit_Load(object sender, EventArgs e)
        {
            F_Main f_main = new F_Main();
            cb_view.Items.Clear();
            cb_valute.Items.Clear();
            dt_query = f_main.QuerySel("select id, name from type_views order by id");
            for (int i = 0; i < dt_query.Rows.Count; i++)
                cb_view.Items.Add(dt_query.Rows[i]["name"] as string);
            dt_query = f_main.QuerySel("select id, name from type_valute order by id");
            for (int i = 0; i < dt_query.Rows.Count; i++)
                cb_valute.Items.Add(dt_query.Rows[i]["name"] as string);
            rb_osn.Checked = true;
            cb_valute.SelectedIndex = 0;
            cb_view.SelectedIndex = 0;
            if (numRow != 0)
            {
                tb_id.Text = Convert.ToString(numRow);
                dt_query = f_main.QuerySel("select id, comment, view_id, summa, valute_id, date_crt from money where id = " + numRow);
                tb_comment.Text = dt_query.Rows[0]["comment"] as string;
                cb_view.SelectedIndex = Convert.ToInt32(dt_query.Rows[0]["view_id"])-1;
                tb_summa.Text = Convert.ToString(dt_query.Rows[0]["summa"]);
                cb_valute.SelectedIndex = Convert.ToInt32(dt_query.Rows[0]["valute_id"])-1;
                dtp_date.Value = Convert.ToDateTime(dt_query.Rows[0]["date_crt"]);
            }
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            Height = 217;
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_summa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void cb_view_TextChanged(object sender, EventArgs e)
        {
            if (cb_view.Text == "Расход")
            {
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                Height = 308;
            }
            else
            {
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                Height = 217;
            }
        }

        private void rb_osn_CheckedChanged(object sender, EventArgs e)
        {
            cb_costs.Items.Clear();
            F_Main f_main = new F_Main();
            dt_query = f_main.QuerySel("select id, name from type_costs where id <> 0 order by id");
            for (int i = 0; i < dt_query.Rows.Count; i++)
                cb_costs.Items.Add(dt_query.Rows[i]["name"] as string);
            cb_costs.SelectedIndex = 0;
        }

        private void rb_plan_CheckedChanged(object sender, EventArgs e)
        {
            cb_costs.Items.Clear();
            F_Main f_main = new F_Main();
            dt_query = f_main.QuerySel("select id, name from planning where closse = 0 order by id");
            for (int i = 0; i < dt_query.Rows.Count; i++)
                cb_costs.Items.Add(dt_query.Rows[i]["name"] as string);
            cb_costs.SelectedIndex = 0;
        }
    }
}

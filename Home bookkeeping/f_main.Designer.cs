namespace Home_bookkeeping
{
    partial class F_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_main = new System.Windows.Forms.TabPage();
            this.grid_main = new System.Windows.Forms.DataGridView();
            this.tp_gain = new System.Windows.Forms.TabPage();
            this.tp_costs = new System.Windows.Forms.TabPage();
            this.tp_object = new System.Windows.Forms.TabPage();
            this.p_main = new System.Windows.Forms.Panel();
            this.p_top = new System.Windows.Forms.Panel();
            this.b_UnFix = new System.Windows.Forms.Button();
            this.tb_FixSumma = new System.Windows.Forms.TextBox();
            this.b_fix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_summa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_valute = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_planning = new System.Windows.Forms.TabPage();
            this.dgv_plan = new System.Windows.Forms.DataGridView();
            this.p_top_stat = new System.Windows.Forms.Panel();
            this.b_CloseMounth = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_summ_plan = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_valute_plan = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_name_plan = new System.Windows.Forms.TextBox();
            this.b_cancel_stat = new System.Windows.Forms.Button();
            this.b_save_stat = new System.Windows.Forms.Button();
            this.b_add_stat = new System.Windows.Forms.Button();
            this.tp_statistic = new System.Windows.Forms.TabPage();
            this.dgv_stats = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_AllSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_InfoProject = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_ProgVers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).BeginInit();
            this.tp_object.SuspendLayout();
            this.p_top.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tb_planning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plan)).BeginInit();
            this.p_top_stat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tp_statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stats)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_main);
            this.tabControl1.Controls.Add(this.tp_gain);
            this.tabControl1.Controls.Add(this.tp_costs);
            this.tabControl1.Controls.Add(this.tp_object);
            this.tabControl1.Controls.Add(this.tb_planning);
            this.tabControl1.Controls.Add(this.tp_statistic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 388);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tp_main
            // 
            this.tp_main.BackColor = System.Drawing.SystemColors.Control;
            this.tp_main.Controls.Add(this.grid_main);
            this.tp_main.Location = new System.Drawing.Point(4, 22);
            this.tp_main.Name = "tp_main";
            this.tp_main.Padding = new System.Windows.Forms.Padding(3);
            this.tp_main.Size = new System.Drawing.Size(851, 362);
            this.tp_main.TabIndex = 0;
            this.tp_main.Text = "Главная";
            // 
            // grid_main
            // 
            this.grid_main.AllowUserToAddRows = false;
            this.grid_main.AllowUserToDeleteRows = false;
            this.grid_main.AllowUserToResizeRows = false;
            this.grid_main.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_main.Location = new System.Drawing.Point(3, 3);
            this.grid_main.MultiSelect = false;
            this.grid_main.Name = "grid_main";
            this.grid_main.ReadOnly = true;
            this.grid_main.RowHeadersVisible = false;
            this.grid_main.Size = new System.Drawing.Size(845, 356);
            this.grid_main.TabIndex = 0;
            this.grid_main.SelectionChanged += new System.EventHandler(this.grid_main_SelectionChanged);
            this.grid_main.Sorted += new System.EventHandler(this.grid_main_Sorted);
            // 
            // tp_gain
            // 
            this.tp_gain.BackColor = System.Drawing.SystemColors.Control;
            this.tp_gain.Location = new System.Drawing.Point(4, 22);
            this.tp_gain.Name = "tp_gain";
            this.tp_gain.Padding = new System.Windows.Forms.Padding(3);
            this.tp_gain.Size = new System.Drawing.Size(851, 362);
            this.tp_gain.TabIndex = 1;
            this.tp_gain.Text = "Доходы";
            // 
            // tp_costs
            // 
            this.tp_costs.BackColor = System.Drawing.SystemColors.Control;
            this.tp_costs.Location = new System.Drawing.Point(4, 22);
            this.tp_costs.Name = "tp_costs";
            this.tp_costs.Padding = new System.Windows.Forms.Padding(3);
            this.tp_costs.Size = new System.Drawing.Size(851, 362);
            this.tp_costs.TabIndex = 2;
            this.tp_costs.Text = "Расходы";
            // 
            // tp_object
            // 
            this.tp_object.BackColor = System.Drawing.SystemColors.Control;
            this.tp_object.Controls.Add(this.p_main);
            this.tp_object.Controls.Add(this.p_top);
            this.tp_object.Location = new System.Drawing.Point(4, 22);
            this.tp_object.Name = "tp_object";
            this.tp_object.Padding = new System.Windows.Forms.Padding(3);
            this.tp_object.Size = new System.Drawing.Size(851, 362);
            this.tp_object.TabIndex = 4;
            this.tp_object.Text = "Цели";
            // 
            // p_main
            // 
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(3, 73);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(845, 286);
            this.p_main.TabIndex = 1;
            // 
            // p_top
            // 
            this.p_top.Controls.Add(this.b_UnFix);
            this.p_top.Controls.Add(this.tb_FixSumma);
            this.p_top.Controls.Add(this.b_fix);
            this.p_top.Controls.Add(this.groupBox3);
            this.p_top.Controls.Add(this.groupBox2);
            this.p_top.Controls.Add(this.groupBox1);
            this.p_top.Controls.Add(this.b_cancel);
            this.p_top.Controls.Add(this.b_save);
            this.p_top.Controls.Add(this.b_add);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(3, 3);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(845, 70);
            this.p_top.TabIndex = 0;
            // 
            // b_UnFix
            // 
            this.b_UnFix.Location = new System.Drawing.Point(464, 3);
            this.b_UnFix.Name = "b_UnFix";
            this.b_UnFix.Size = new System.Drawing.Size(107, 23);
            this.b_UnFix.TabIndex = 12;
            this.b_UnFix.Text = "Снять сумму";
            this.b_UnFix.UseVisualStyleBackColor = true;
            this.b_UnFix.Click += new System.EventHandler(this.b_UnFix_Click);
            // 
            // tb_FixSumma
            // 
            this.tb_FixSumma.Location = new System.Drawing.Point(359, 5);
            this.tb_FixSumma.Name = "tb_FixSumma";
            this.tb_FixSumma.Size = new System.Drawing.Size(99, 20);
            this.tb_FixSumma.TabIndex = 11;
            this.tb_FixSumma.Text = "0";
            this.tb_FixSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_fix
            // 
            this.b_fix.Location = new System.Drawing.Point(246, 3);
            this.b_fix.Name = "b_fix";
            this.b_fix.Size = new System.Drawing.Size(107, 23);
            this.b_fix.TabIndex = 10;
            this.b_fix.Text = "Положить сумму";
            this.b_fix.UseVisualStyleBackColor = true;
            this.b_fix.Click += new System.EventHandler(this.b_fix_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tb_summa);
            this.groupBox3.Location = new System.Drawing.Point(335, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 42);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сумма";
            // 
            // tb_summa
            // 
            this.tb_summa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_summa.Location = new System.Drawing.Point(3, 16);
            this.tb_summa.Name = "tb_summa";
            this.tb_summa.Size = new System.Drawing.Size(120, 20);
            this.tb_summa.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cb_valute);
            this.groupBox2.Location = new System.Drawing.Point(206, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Валюта";
            // 
            // cb_valute
            // 
            this.cb_valute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_valute.FormattingEnabled = true;
            this.cb_valute.Location = new System.Drawing.Point(3, 16);
            this.cb_valute.Name = "cb_valute";
            this.cb_valute.Size = new System.Drawing.Size(120, 21);
            this.cb_valute.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наименовение цели";
            // 
            // tb_name
            // 
            this.tb_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_name.Location = new System.Drawing.Point(3, 16);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(194, 20);
            this.tb_name.TabIndex = 5;
            // 
            // b_cancel
            // 
            this.b_cancel.Enabled = false;
            this.b_cancel.Location = new System.Drawing.Point(165, 3);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Отменить";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_canel_Click);
            // 
            // b_save
            // 
            this.b_save.Enabled = false;
            this.b_save.Location = new System.Drawing.Point(84, 3);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 1;
            this.b_save.Text = "Сохранить";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(3, 3);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_planning
            // 
            this.tb_planning.BackColor = System.Drawing.SystemColors.Control;
            this.tb_planning.Controls.Add(this.dgv_plan);
            this.tb_planning.Controls.Add(this.p_top_stat);
            this.tb_planning.Location = new System.Drawing.Point(4, 22);
            this.tb_planning.Name = "tb_planning";
            this.tb_planning.Padding = new System.Windows.Forms.Padding(3);
            this.tb_planning.Size = new System.Drawing.Size(851, 362);
            this.tb_planning.TabIndex = 5;
            this.tb_planning.Text = "Планирование";
            // 
            // dgv_plan
            // 
            this.dgv_plan.AllowUserToAddRows = false;
            this.dgv_plan.AllowUserToDeleteRows = false;
            this.dgv_plan.AllowUserToResizeRows = false;
            this.dgv_plan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_plan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_plan.Location = new System.Drawing.Point(3, 73);
            this.dgv_plan.Name = "dgv_plan";
            this.dgv_plan.RowHeadersVisible = false;
            this.dgv_plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_plan.Size = new System.Drawing.Size(845, 286);
            this.dgv_plan.TabIndex = 2;
            // 
            // p_top_stat
            // 
            this.p_top_stat.Controls.Add(this.b_CloseMounth);
            this.p_top_stat.Controls.Add(this.groupBox4);
            this.p_top_stat.Controls.Add(this.groupBox5);
            this.p_top_stat.Controls.Add(this.groupBox6);
            this.p_top_stat.Controls.Add(this.b_cancel_stat);
            this.p_top_stat.Controls.Add(this.b_save_stat);
            this.p_top_stat.Controls.Add(this.b_add_stat);
            this.p_top_stat.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top_stat.Location = new System.Drawing.Point(3, 3);
            this.p_top_stat.Name = "p_top_stat";
            this.p_top_stat.Size = new System.Drawing.Size(845, 70);
            this.p_top_stat.TabIndex = 1;
            // 
            // b_CloseMounth
            // 
            this.b_CloseMounth.Enabled = false;
            this.b_CloseMounth.Location = new System.Drawing.Point(246, 3);
            this.b_CloseMounth.Name = "b_CloseMounth";
            this.b_CloseMounth.Size = new System.Drawing.Size(221, 23);
            this.b_CloseMounth.TabIndex = 10;
            this.b_CloseMounth.Text = "Закрыть месяц";
            this.b_CloseMounth.UseVisualStyleBackColor = true;
            this.b_CloseMounth.Click += new System.EventHandler(this.b_CloseMounth_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.tb_summ_plan);
            this.groupBox4.Location = new System.Drawing.Point(209, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 42);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сумма";
            // 
            // tb_summ_plan
            // 
            this.tb_summ_plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_summ_plan.Location = new System.Drawing.Point(3, 16);
            this.tb_summ_plan.Name = "tb_summ_plan";
            this.tb_summ_plan.Size = new System.Drawing.Size(120, 20);
            this.tb_summ_plan.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.cb_valute_plan);
            this.groupBox5.Location = new System.Drawing.Point(341, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(126, 42);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Валюта";
            // 
            // cb_valute_plan
            // 
            this.cb_valute_plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_valute_plan.FormattingEnabled = true;
            this.cb_valute_plan.Location = new System.Drawing.Point(3, 16);
            this.cb_valute_plan.Name = "cb_valute_plan";
            this.cb_valute_plan.Size = new System.Drawing.Size(120, 21);
            this.cb_valute_plan.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.tb_name_plan);
            this.groupBox6.Location = new System.Drawing.Point(3, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 42);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Наименовение планирования";
            // 
            // tb_name_plan
            // 
            this.tb_name_plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_name_plan.Location = new System.Drawing.Point(3, 16);
            this.tb_name_plan.Name = "tb_name_plan";
            this.tb_name_plan.Size = new System.Drawing.Size(194, 20);
            this.tb_name_plan.TabIndex = 5;
            // 
            // b_cancel_stat
            // 
            this.b_cancel_stat.Enabled = false;
            this.b_cancel_stat.Location = new System.Drawing.Point(165, 3);
            this.b_cancel_stat.Name = "b_cancel_stat";
            this.b_cancel_stat.Size = new System.Drawing.Size(75, 23);
            this.b_cancel_stat.TabIndex = 2;
            this.b_cancel_stat.Text = "Отменить";
            this.b_cancel_stat.UseVisualStyleBackColor = true;
            this.b_cancel_stat.Click += new System.EventHandler(this.b_cancel_stat_Click);
            // 
            // b_save_stat
            // 
            this.b_save_stat.Enabled = false;
            this.b_save_stat.Location = new System.Drawing.Point(84, 3);
            this.b_save_stat.Name = "b_save_stat";
            this.b_save_stat.Size = new System.Drawing.Size(75, 23);
            this.b_save_stat.TabIndex = 1;
            this.b_save_stat.Text = "Сохранить";
            this.b_save_stat.UseVisualStyleBackColor = true;
            this.b_save_stat.Click += new System.EventHandler(this.b_save_stat_Click);
            // 
            // b_add_stat
            // 
            this.b_add_stat.Location = new System.Drawing.Point(3, 3);
            this.b_add_stat.Name = "b_add_stat";
            this.b_add_stat.Size = new System.Drawing.Size(75, 23);
            this.b_add_stat.TabIndex = 0;
            this.b_add_stat.Text = "Добавить";
            this.b_add_stat.UseVisualStyleBackColor = true;
            this.b_add_stat.Click += new System.EventHandler(this.b_add_stat_Click);
            // 
            // tp_statistic
            // 
            this.tp_statistic.BackColor = System.Drawing.SystemColors.Control;
            this.tp_statistic.Controls.Add(this.dgv_stats);
            this.tp_statistic.Location = new System.Drawing.Point(4, 22);
            this.tp_statistic.Name = "tp_statistic";
            this.tp_statistic.Padding = new System.Windows.Forms.Padding(3);
            this.tp_statistic.Size = new System.Drawing.Size(851, 362);
            this.tp_statistic.TabIndex = 3;
            this.tp_statistic.Text = "Статистика";
            // 
            // dgv_stats
            // 
            this.dgv_stats.AllowUserToAddRows = false;
            this.dgv_stats.AllowUserToDeleteRows = false;
            this.dgv_stats.AllowUserToResizeRows = false;
            this.dgv_stats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stats.Location = new System.Drawing.Point(0, 0);
            this.dgv_stats.MultiSelect = false;
            this.dgv_stats.Name = "dgv_stats";
            this.dgv_stats.RowHeadersVisible = false;
            this.dgv_stats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_stats.Size = new System.Drawing.Size(283, 146);
            this.dgv_stats.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Settings,
            this.menu_InfoProject});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Add,
            this.menu_Edit,
            this.menu_Delete,
            this.menu_Refresh,
            this.menu_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(48, 20);
            this.menu_File.Text = "Файл";
            // 
            // menu_Add
            // 
            this.menu_Add.Name = "menu_Add";
            this.menu_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_Add.Size = new System.Drawing.Size(208, 22);
            this.menu_Add.Text = "Добавить запись";
            this.menu_Add.Click += new System.EventHandler(this.menu_Add_Click);
            // 
            // menu_Edit
            // 
            this.menu_Edit.Name = "menu_Edit";
            this.menu_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menu_Edit.Size = new System.Drawing.Size(208, 22);
            this.menu_Edit.Text = "Редактировать";
            this.menu_Edit.Click += new System.EventHandler(this.menu_Edit_Click);
            // 
            // menu_Delete
            // 
            this.menu_Delete.Name = "menu_Delete";
            this.menu_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.menu_Delete.Size = new System.Drawing.Size(208, 22);
            this.menu_Delete.Text = "Удалить";
            this.menu_Delete.Click += new System.EventHandler(this.menu_Delete_Click);
            // 
            // menu_Refresh
            // 
            this.menu_Refresh.Name = "menu_Refresh";
            this.menu_Refresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menu_Refresh.Size = new System.Drawing.Size(208, 22);
            this.menu_Refresh.Text = "Обновить";
            this.menu_Refresh.Click += new System.EventHandler(this.menu_Refresh_Click);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_Exit.Size = new System.Drawing.Size(208, 22);
            this.menu_Exit.Text = "Выход";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // menu_Settings
            // 
            this.menu_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_AllSetting,
            this.menu_Help});
            this.menu_Settings.Name = "menu_Settings";
            this.menu_Settings.Size = new System.Drawing.Size(79, 20);
            this.menu_Settings.Text = "Настройки";
            // 
            // menu_AllSetting
            // 
            this.menu_AllSetting.Name = "menu_AllSetting";
            this.menu_AllSetting.Size = new System.Drawing.Size(175, 22);
            this.menu_AllSetting.Text = "Общие настройки";
            // 
            // menu_Help
            // 
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menu_Help.Size = new System.Drawing.Size(175, 22);
            this.menu_Help.Text = "Справка";
            this.menu_Help.Click += new System.EventHandler(this.menu_Help_Click);
            // 
            // menu_InfoProject
            // 
            this.menu_InfoProject.Name = "menu_InfoProject";
            this.menu_InfoProject.Size = new System.Drawing.Size(94, 20);
            this.menu_InfoProject.Text = "О программе";
            this.menu_InfoProject.Click += new System.EventHandler(this.menu_InfoProject_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_ProgVers});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL_ProgVers
            // 
            this.tSSL_ProgVers.Name = "tSSL_ProgVers";
            this.tSSL_ProgVers.Size = new System.Drawing.Size(118, 17);
            this.tSSL_ProgVers.Text = "toolStripStatusLabel2";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя бухгалтерия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Main_FormClosing);
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.Shown += new System.EventHandler(this.F_Main_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tp_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).EndInit();
            this.tp_object.ResumeLayout(false);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tb_planning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plan)).EndInit();
            this.p_top_stat.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tp_statistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stats)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_main;
        private System.Windows.Forms.TabPage tp_gain;
        private System.Windows.Forms.TabPage tp_costs;
        private System.Windows.Forms.TabPage tp_object;
        private System.Windows.Forms.TabPage tp_statistic;
        private System.Windows.Forms.DataGridView grid_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_Refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem menu_Settings;
        private System.Windows.Forms.ToolStripMenuItem menu_AllSetting;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_InfoProject;
        private System.Windows.Forms.ToolStripMenuItem menu_Add;
        private System.Windows.Forms.ToolStripMenuItem menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem menu_Delete;
        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_summa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_valute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button b_fix;
        private System.Windows.Forms.TextBox tb_FixSumma;
        private System.Windows.Forms.Button b_UnFix;
        private System.Windows.Forms.TabPage tb_planning;
        private System.Windows.Forms.DataGridView dgv_plan;
        private System.Windows.Forms.Panel p_top_stat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_summ_plan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_valute_plan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_name_plan;
        private System.Windows.Forms.Button b_cancel_stat;
        private System.Windows.Forms.Button b_save_stat;
        private System.Windows.Forms.Button b_add_stat;
        private System.Windows.Forms.Button b_CloseMounth;
        private System.Windows.Forms.DataGridView dgv_stats;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_ProgVers;
    }
}


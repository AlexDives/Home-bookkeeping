namespace Home_bookkeeping
{
    partial class f_AddAndEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_AddAndEdit));
            this.but_add = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_view = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_summa = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_valute = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cb_costs = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rb_osn = new System.Windows.Forms.RadioButton();
            this.rb_plan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_add
            // 
            this.but_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_add.Location = new System.Drawing.Point(12, 237);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(186, 23);
            this.but_add.TabIndex = 0;
            this.but_add.Text = "Сохранить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_close
            // 
            this.but_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_close.Location = new System.Drawing.Point(204, 237);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(181, 23);
            this.but_close.TabIndex = 8;
            this.but_close.Text = "Закрыть";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_comment);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 39);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наименовение дохода / расхода";
            // 
            // tb_comment
            // 
            this.tb_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_comment.Location = new System.Drawing.Point(3, 16);
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(306, 20);
            this.tb_comment.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_view);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 39);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Бюджет";
            // 
            // cb_view
            // 
            this.cb_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_view.FormattingEnabled = true;
            this.cb_view.Location = new System.Drawing.Point(3, 15);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(183, 21);
            this.cb_view.TabIndex = 2;
            this.cb_view.TextChanged += new System.EventHandler(this.cb_view_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_summa);
            this.groupBox3.Location = new System.Drawing.Point(204, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 39);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сумма";
            // 
            // tb_summa
            // 
            this.tb_summa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_summa.Location = new System.Drawing.Point(3, 16);
            this.tb_summa.Name = "tb_summa";
            this.tb_summa.Size = new System.Drawing.Size(175, 20);
            this.tb_summa.TabIndex = 6;
            this.tb_summa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_summa_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cb_valute);
            this.groupBox4.Location = new System.Drawing.Point(12, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 39);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Валюта";
            // 
            // cb_valute
            // 
            this.cb_valute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_valute.FormattingEnabled = true;
            this.cb_valute.Location = new System.Drawing.Point(3, 15);
            this.cb_valute.Name = "cb_valute";
            this.cb_valute.Size = new System.Drawing.Size(183, 21);
            this.cb_valute.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dtp_date);
            this.groupBox5.Location = new System.Drawing.Point(204, 193);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 39);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата";
            // 
            // dtp_date
            // 
            this.dtp_date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtp_date.Location = new System.Drawing.Point(3, 16);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(175, 20);
            this.dtp_date.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_id);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(55, 39);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "№";
            // 
            // tb_id
            // 
            this.tb_id.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_id.Location = new System.Drawing.Point(3, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(49, 20);
            this.tb_id.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.cb_costs);
            this.groupBox7.Location = new System.Drawing.Point(10, 148);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(375, 39);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Вид расхода";
            // 
            // cb_costs
            // 
            this.cb_costs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_costs.FormattingEnabled = true;
            this.cb_costs.Location = new System.Drawing.Point(3, 15);
            this.cb_costs.Name = "cb_costs";
            this.cb_costs.Size = new System.Drawing.Size(369, 21);
            this.cb_costs.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rb_plan);
            this.groupBox8.Controls.Add(this.rb_osn);
            this.groupBox8.Location = new System.Drawing.Point(12, 102);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(373, 39);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Тип расхода";
            // 
            // rb_osn
            // 
            this.rb_osn.AutoSize = true;
            this.rb_osn.Location = new System.Drawing.Point(15, 16);
            this.rb_osn.Name = "rb_osn";
            this.rb_osn.Size = new System.Drawing.Size(113, 17);
            this.rb_osn.TabIndex = 0;
            this.rb_osn.Text = "Основной расход";
            this.rb_osn.UseVisualStyleBackColor = true;
            this.rb_osn.CheckedChanged += new System.EventHandler(this.rb_osn_CheckedChanged);
            // 
            // rb_plan
            // 
            this.rb_plan.AutoSize = true;
            this.rb_plan.Location = new System.Drawing.Point(192, 16);
            this.rb_plan.Name = "rb_plan";
            this.rb_plan.Size = new System.Drawing.Size(145, 17);
            this.rb_plan.TabIndex = 1;
            this.rb_plan.Text = "Планированный расход";
            this.rb_plan.UseVisualStyleBackColor = true;
            this.rb_plan.CheckedChanged += new System.EventHandler(this.rb_plan_CheckedChanged);
            // 
            // f_AddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 269);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 217);
            this.Name = "f_AddAndEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "f_AddAndEdit";
            this.Load += new System.EventHandler(this.f_AddAndEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_view;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_summa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_valute;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cb_costs;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rb_plan;
        private System.Windows.Forms.RadioButton rb_osn;
    }
}
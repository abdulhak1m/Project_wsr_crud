namespace Project_ws_crud
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Add = new System.Windows.Forms.Panel();
            this.pnl_Deleted = new System.Windows.Forms.Panel();
            this.pnl_edit = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.switch_add = new System.Windows.Forms.Button();
            this.switch_edit = new System.Windows.Forms.Button();
            this.switch_deleted = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmd_gender = new System.Windows.Forms.ComboBox();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_instagram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.pnl_Top.SuspendLayout();
            this.pnl_Add.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.White;
            this.pnl_Top.Controls.Add(this.btn_close);
            this.pnl_Top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(857, 25);
            this.pnl_Top.TabIndex = 0;
            // 
            // pnl_Add
            // 
            this.pnl_Add.Controls.Add(this.txt_phone);
            this.pnl_Add.Controls.Add(this.cmd_gender);
            this.pnl_Add.Controls.Add(this.panel5);
            this.pnl_Add.Controls.Add(this.btn_Save);
            this.pnl_Add.Controls.Add(this.panel6);
            this.pnl_Add.Controls.Add(this.panel4);
            this.pnl_Add.Controls.Add(this.panel3);
            this.pnl_Add.Controls.Add(this.panel2);
            this.pnl_Add.Controls.Add(this.panel1);
            this.pnl_Add.Controls.Add(this.label5);
            this.pnl_Add.Controls.Add(this.label6);
            this.pnl_Add.Controls.Add(this.label4);
            this.pnl_Add.Controls.Add(this.label3);
            this.pnl_Add.Controls.Add(this.label2);
            this.pnl_Add.Controls.Add(this.label1);
            this.pnl_Add.Controls.Add(this.txt_group);
            this.pnl_Add.Controls.Add(this.txt_instagram);
            this.pnl_Add.Controls.Add(this.txt_surname);
            this.pnl_Add.Controls.Add(this.txt_name);
            this.pnl_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Add.Location = new System.Drawing.Point(117, 25);
            this.pnl_Add.Name = "pnl_Add";
            this.pnl_Add.Size = new System.Drawing.Size(740, 473);
            this.pnl_Add.TabIndex = 2;
            // 
            // pnl_Deleted
            // 
            this.pnl_Deleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Deleted.Location = new System.Drawing.Point(117, 25);
            this.pnl_Deleted.Name = "pnl_Deleted";
            this.pnl_Deleted.Size = new System.Drawing.Size(740, 473);
            this.pnl_Deleted.TabIndex = 2;
            // 
            // pnl_edit
            // 
            this.pnl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_edit.Location = new System.Drawing.Point(117, 25);
            this.pnl_edit.Name = "pnl_edit";
            this.pnl_edit.Size = new System.Drawing.Size(740, 473);
            this.pnl_edit.TabIndex = 2;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.switch_deleted);
            this.pnl_menu.Controls.Add(this.switch_edit);
            this.pnl_menu.Controls.Add(this.switch_add);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 25);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(117, 473);
            this.pnl_menu.TabIndex = 1;
            // 
            // switch_add
            // 
            this.switch_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_add.FlatAppearance.BorderSize = 0;
            this.switch_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_add.Image = ((System.Drawing.Image)(resources.GetObject("switch_add.Image")));
            this.switch_add.Location = new System.Drawing.Point(27, 141);
            this.switch_add.Name = "switch_add";
            this.switch_add.Size = new System.Drawing.Size(62, 44);
            this.switch_add.TabIndex = 0;
            this.switch_add.UseVisualStyleBackColor = true;
            // 
            // switch_edit
            // 
            this.switch_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_edit.FlatAppearance.BorderSize = 0;
            this.switch_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_edit.Image = ((System.Drawing.Image)(resources.GetObject("switch_edit.Image")));
            this.switch_edit.Location = new System.Drawing.Point(27, 207);
            this.switch_edit.Name = "switch_edit";
            this.switch_edit.Size = new System.Drawing.Size(62, 44);
            this.switch_edit.TabIndex = 0;
            this.switch_edit.UseVisualStyleBackColor = true;
            // 
            // switch_deleted
            // 
            this.switch_deleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_deleted.FlatAppearance.BorderSize = 0;
            this.switch_deleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_deleted.Image = ((System.Drawing.Image)(resources.GetObject("switch_deleted.Image")));
            this.switch_deleted.Location = new System.Drawing.Point(27, 276);
            this.switch_deleted.Name = "switch_deleted";
            this.switch_deleted.Size = new System.Drawing.Size(62, 44);
            this.switch_deleted.TabIndex = 0;
            this.switch_deleted.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(62, 118);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(264, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(62, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 5);
            this.panel1.TabIndex = 2;
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(62, 192);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(264, 20);
            this.txt_surname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Location = new System.Drawing.Point(62, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 5);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пол:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Location = new System.Drawing.Point(62, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 5);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Номер телефона:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Location = new System.Drawing.Point(381, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 5);
            this.panel4.TabIndex = 2;
            // 
            // cmd_gender
            // 
            this.cmd_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_gender.FormattingEnabled = true;
            this.cmd_gender.Items.AddRange(new object[] {
            "Не выбрано",
            "Муж",
            "Жен"});
            this.cmd_gender.Location = new System.Drawing.Point(62, 257);
            this.cmd_gender.Name = "cmd_gender";
            this.cmd_gender.Size = new System.Drawing.Size(264, 27);
            this.cmd_gender.TabIndex = 3;
            // 
            // txt_group
            // 
            this.txt_group.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_group.Location = new System.Drawing.Point(381, 263);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(264, 20);
            this.txt_group.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Группа:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.BlueViolet;
            this.panel5.Location = new System.Drawing.Point(381, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 5);
            this.panel5.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(325, 326);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 54);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_instagram
            // 
            this.txt_instagram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_instagram.Location = new System.Drawing.Point(381, 195);
            this.txt_instagram.Name = "txt_instagram";
            this.txt_instagram.Size = new System.Drawing.Size(264, 20);
            this.txt_instagram.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "instagram:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(381, 218);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 5);
            this.panel6.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(832, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Location = new System.Drawing.Point(381, 122);
            this.txt_phone.Mask = "+7 (999) 999-9999";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(264, 20);
            this.txt_phone.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 498);
            this.Controls.Add(this.pnl_Add);
            this.Controls.Add(this.pnl_edit);
            this.Controls.Add(this.pnl_Deleted);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Add.ResumeLayout(false);
            this.pnl_Add.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_Add;
        private System.Windows.Forms.Panel pnl_Deleted;
        private System.Windows.Forms.Panel pnl_edit;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button switch_add;
        private System.Windows.Forms.Button switch_deleted;
        private System.Windows.Forms.Button switch_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.ComboBox cmd_gender;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_instagram;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.MaskedTextBox txt_phone;
    }
}


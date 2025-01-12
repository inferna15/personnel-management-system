namespace personnel_management_system
{
    partial class MainApp
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
            list = new DataGridView();
            label1 = new Label();
            ssn_box = new TextBox();
            firstname_box = new TextBox();
            label2 = new Label();
            lastname_box = new TextBox();
            label3 = new Label();
            title_box = new TextBox();
            label4 = new Label();
            department_box = new TextBox();
            label5 = new Label();
            age_box = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateofbirth_box = new DateTimePicker();
            dateofstart_box = new DateTimePicker();
            isonduty_box = new CheckBox();
            create_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            SuspendLayout();
            // 
            // list
            // 
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(12, 12);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(916, 521);
            list.TabIndex = 0;
            list.SelectionChanged += list_SelectionChangedAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(949, 59);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "T.C. no";
            // 
            // ssn_box
            // 
            ssn_box.Location = new Point(1061, 56);
            ssn_box.Name = "ssn_box";
            ssn_box.Size = new Size(194, 27);
            ssn_box.TabIndex = 2;
            // 
            // firstname_box
            // 
            firstname_box.Location = new Point(1061, 89);
            firstname_box.Name = "firstname_box";
            firstname_box.Size = new Size(194, 27);
            firstname_box.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(949, 92);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "Adı";
            // 
            // lastname_box
            // 
            lastname_box.Location = new Point(1061, 122);
            lastname_box.Name = "lastname_box";
            lastname_box.Size = new Size(194, 27);
            lastname_box.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(949, 125);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Soyadı";
            // 
            // title_box
            // 
            title_box.Location = new Point(1061, 155);
            title_box.Name = "title_box";
            title_box.Size = new Size(194, 27);
            title_box.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(949, 158);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Ünvanı";
            // 
            // department_box
            // 
            department_box.Location = new Point(1061, 188);
            department_box.Name = "department_box";
            department_box.Size = new Size(194, 27);
            department_box.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(949, 191);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Bölümü";
            // 
            // age_box
            // 
            age_box.Enabled = false;
            age_box.Location = new Point(1061, 254);
            age_box.Name = "age_box";
            age_box.Size = new Size(194, 27);
            age_box.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(949, 257);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 13;
            label6.Text = "Yaşı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(949, 224);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 11;
            label7.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(949, 323);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 17;
            label8.Text = "Görevde mi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(949, 290);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 15;
            label9.Text = "Başlama Tarihi";
            // 
            // dateofbirth_box
            // 
            dateofbirth_box.Location = new Point(1061, 221);
            dateofbirth_box.Name = "dateofbirth_box";
            dateofbirth_box.Size = new Size(194, 27);
            dateofbirth_box.TabIndex = 19;
            // 
            // dateofstart_box
            // 
            dateofstart_box.Location = new Point(1061, 287);
            dateofstart_box.Name = "dateofstart_box";
            dateofstart_box.Size = new Size(194, 27);
            dateofstart_box.TabIndex = 20;
            // 
            // isonduty_box
            // 
            isonduty_box.AutoSize = true;
            isonduty_box.Location = new Point(1061, 326);
            isonduty_box.Name = "isonduty_box";
            isonduty_box.Size = new Size(18, 17);
            isonduty_box.TabIndex = 21;
            isonduty_box.UseVisualStyleBackColor = true;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(949, 369);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(306, 29);
            create_btn.TabIndex = 22;
            create_btn.Text = "Oluştur";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(949, 404);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(306, 29);
            update_btn.TabIndex = 23;
            update_btn.Text = "Değiştir";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(949, 439);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(306, 29);
            delete_btn.TabIndex = 24;
            delete_btn.Text = "Sil";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_ClickAsync;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 558);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(create_btn);
            Controls.Add(isonduty_box);
            Controls.Add(dateofstart_box);
            Controls.Add(dateofbirth_box);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(age_box);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(department_box);
            Controls.Add(label5);
            Controls.Add(title_box);
            Controls.Add(label4);
            Controls.Add(lastname_box);
            Controls.Add(label3);
            Controls.Add(firstname_box);
            Controls.Add(label2);
            Controls.Add(ssn_box);
            Controls.Add(label1);
            Controls.Add(list);
            Name = "MainApp";
            Text = "MainApp";
            FormClosing += MainApp_FormClosing;
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView list;
        private Label label1;
        private TextBox ssn_box;
        private TextBox firstname_box;
        private Label label2;
        private TextBox lastname_box;
        private Label label3;
        private TextBox title_box;
        private Label label4;
        private TextBox department_box;
        private Label label5;
        private TextBox age_box;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateofbirth_box;
        private DateTimePicker dateofstart_box;
        private CheckBox isonduty_box;
        private Button create_btn;
        private Button update_btn;
        private Button delete_btn;
    }
}
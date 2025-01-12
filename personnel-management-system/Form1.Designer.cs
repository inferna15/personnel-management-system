namespace personnel_management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            username_box = new TextBox();
            password_box = new TextBox();
            login_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 103);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 141);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // username_box
            // 
            username_box.Location = new Point(172, 100);
            username_box.Name = "username_box";
            username_box.Size = new Size(125, 27);
            username_box.TabIndex = 2;
            // 
            // password_box
            // 
            password_box.Location = new Point(172, 138);
            password_box.Name = "password_box";
            password_box.Size = new Size(125, 27);
            password_box.TabIndex = 3;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(130, 190);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 4;
            login_btn.Text = "Giriş Yap";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(login_btn);
            Controls.Add(password_box);
            Controls.Add(username_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_box;
        private TextBox password_box;
        private Button login_btn;
    }
}

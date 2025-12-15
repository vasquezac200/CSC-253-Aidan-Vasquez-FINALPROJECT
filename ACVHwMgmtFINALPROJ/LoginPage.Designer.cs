namespace ACVHwMgmtFINALPROJ
{
    partial class LoginPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLogIn = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            txtConfNewPass = new TextBox();
            label6 = new Label();
            btnRegister = new Button();
            txtNewPass = new TextBox();
            txtNewUser = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(379, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome! Please Sign in or Log in with existing account.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(446, 245);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogIn);
            tabPage1.Controls.Add(txtPass);
            tabPage1.Controls.Add(txtUser);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(438, 212);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Log In";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(254, 133);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(163, 89);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(185, 27);
            txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(163, 52);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(185, 27);
            txtUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 92);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 56);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtFullName);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtConfNewPass);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(txtNewPass);
            tabPage2.Controls.Add(txtNewUser);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(438, 212);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sign In";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtConfNewPass
            // 
            txtConfNewPass.Location = new Point(196, 135);
            txtConfNewPass.Name = "txtConfNewPass";
            txtConfNewPass.Size = new Size(159, 27);
            txtConfNewPass.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 142);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 10;
            label6.Text = "Confirm password:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(272, 167);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(196, 102);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(159, 27);
            txtNewPass.TabIndex = 8;
            // 
            // txtNewUser
            // 
            txtNewUser.Location = new Point(168, 60);
            txtNewUser.Name = "txtNewUser";
            txtNewUser.Size = new Size(187, 27);
            txtNewUser.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 105);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 63);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 5;
            label5.Text = "New username:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(168, 23);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(187, 27);
            txtFullName.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 26);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 12;
            label7.Text = "Full Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 300);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label3;
        private Button btnLogIn;
        private TextBox txtPass;
        private TextBox txtUser;
        private TextBox txtConfNewPass;
        private Label label6;
        private Button btnRegister;
        private TextBox txtNewPass;
        private TextBox txtNewUser;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private Label label7;
    }
}

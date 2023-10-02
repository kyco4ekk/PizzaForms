
namespace WindowsFormsApp1
{
    partial class LogIn
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.logPassword = new System.Windows.Forms.TextBox();
            this.regLogin = new System.Windows.Forms.TextBox();
            this.lookPass = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(196, 278);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(187, 50);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // logPassword
            // 
            this.logPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logPassword.Location = new System.Drawing.Point(196, 150);
            this.logPassword.Multiline = true;
            this.logPassword.Name = "logPassword";
            this.logPassword.Size = new System.Drawing.Size(187, 40);
            this.logPassword.TabIndex = 4;
            this.logPassword.Enter += new System.EventHandler(this.regPassword_Enter);
            this.logPassword.Leave += new System.EventHandler(this.regPassword_Leave);
            // 
            // regLogin
            // 
            this.regLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogin.Location = new System.Drawing.Point(196, 91);
            this.regLogin.Multiline = true;
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(187, 40);
            this.regLogin.TabIndex = 3;
            this.regLogin.Enter += new System.EventHandler(this.regLogin_Enter);
            this.regLogin.Leave += new System.EventHandler(this.regLogin_Leave);
            // 
            // lookPass
            // 
            this.lookPass.AutoSize = true;
            this.lookPass.Location = new System.Drawing.Point(389, 161);
            this.lookPass.Name = "lookPass";
            this.lookPass.Size = new System.Drawing.Size(18, 17);
            this.lookPass.TabIndex = 17;
            this.lookPass.UseVisualStyleBackColor = true;
            this.lookPass.Click += new System.EventHandler(this.lookPass_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(544, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "X";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lookPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.logPassword);
            this.Controls.Add(this.regLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox logPassword;
        private System.Windows.Forms.TextBox regLogin;
        private System.Windows.Forms.CheckBox lookPass;
        private System.Windows.Forms.TextBox textBox1;
    }
}
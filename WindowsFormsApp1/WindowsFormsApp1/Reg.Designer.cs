
namespace WindowsFormsApp1
{
    partial class RegPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegPanel));
            this.button1 = new System.Windows.Forms.Button();
            this.lookPass = new System.Windows.Forms.CheckBox();
            this.x = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regSurname = new System.Windows.Forms.TextBox();
            this.regName = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(301, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lookPass
            // 
            this.lookPass.AutoSize = true;
            this.lookPass.Location = new System.Drawing.Point(249, 130);
            this.lookPass.Name = "lookPass";
            this.lookPass.Size = new System.Drawing.Size(18, 17);
            this.lookPass.TabIndex = 16;
            this.lookPass.UseVisualStyleBackColor = true;
            this.lookPass.Click += new System.EventHandler(this.lookPass_Click);
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.x.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(666, -3);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(30, 20);
            this.x.TabIndex = 15;
            this.x.Text = "X";
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // regSurname
            // 
            this.regSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regSurname.Location = new System.Drawing.Point(30, 230);
            this.regSurname.Multiline = true;
            this.regSurname.Name = "regSurname";
            this.regSurname.Size = new System.Drawing.Size(213, 40);
            this.regSurname.TabIndex = 13;
            this.regSurname.Enter += new System.EventHandler(this.regSurname_Enter);
            this.regSurname.Leave += new System.EventHandler(this.regSurname_Leave);
            // 
            // regName
            // 
            this.regName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regName.Location = new System.Drawing.Point(30, 175);
            this.regName.Multiline = true;
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(213, 40);
            this.regName.TabIndex = 12;
            this.regName.Enter += new System.EventHandler(this.regName_Enter);
            this.regName.Leave += new System.EventHandler(this.regName_Leave);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Green;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(16, 295);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(261, 55);
            this.buttonReg.TabIndex = 11;
            this.buttonReg.Text = "Зарегестрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // regPassword
            // 
            this.regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassword.Location = new System.Drawing.Point(30, 119);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(213, 30);
            this.regPassword.TabIndex = 10;
            this.regPassword.UseSystemPasswordChar = true;
            this.regPassword.Enter += new System.EventHandler(this.regPassword_Enter);
            this.regPassword.Leave += new System.EventHandler(this.regPassword_Leave);
            // 
            // regLogin
            // 
            this.regLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogin.Location = new System.Drawing.Point(30, 64);
            this.regLogin.Multiline = true;
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(213, 40);
            this.regLogin.TabIndex = 0;
            this.regLogin.Enter += new System.EventHandler(this.regLogin_Enter);
            this.regLogin.Leave += new System.EventHandler(this.regLogin_Leave);
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
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "X";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lookPass);
            this.Controls.Add(this.x);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regSurname);
            this.Controls.Add(this.regName);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegPanel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пиццерия";
            this.Load += new System.EventHandler(this.regPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox lookPass;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox regSurname;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regLogin;
        private System.Windows.Forms.TextBox textBox1;
    }
}
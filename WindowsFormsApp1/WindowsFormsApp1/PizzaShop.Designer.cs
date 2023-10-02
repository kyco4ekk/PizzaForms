
namespace WindowsFormsApp1
{
    partial class PizzaShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaShop));
            this.button1 = new System.Windows.Forms.Button();
            this.pizzaButtonOne = new System.Windows.Forms.Button();
            this.pizzaButtonTwo = new System.Windows.Forms.Button();
            this.pizzaButtonThree = new System.Windows.Forms.Button();
            this.picturePizza3 = new System.Windows.Forms.PictureBox();
            this.picturePizza2 = new System.Windows.Forms.PictureBox();
            this.picturePizza1 = new System.Windows.Forms.PictureBox();
            this.structure1 = new System.Windows.Forms.Button();
            this.cal1 = new System.Windows.Forms.Button();
            this.cal2 = new System.Windows.Forms.Button();
            this.structure2 = new System.Windows.Forms.Button();
            this.cal3 = new System.Windows.Forms.Button();
            this.structure3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.countOfPizzaInBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.Button();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.pricePizzaOne = new System.Windows.Forms.TextBox();
            this.pricePizzaTwo = new System.Windows.Forms.TextBox();
            this.pricePizzaThree = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cleanTheBox = new System.Windows.Forms.Button();
            this.Discount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePizza3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePizza2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePizza1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Корзина";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pizzaButtonOne
            // 
            this.pizzaButtonOne.Location = new System.Drawing.Point(28, 105);
            this.pizzaButtonOne.Name = "pizzaButtonOne";
            this.pizzaButtonOne.Size = new System.Drawing.Size(166, 43);
            this.pizzaButtonOne.TabIndex = 1;
            this.pizzaButtonOne.Text = "Маргарита";
            this.pizzaButtonOne.UseVisualStyleBackColor = true;
            this.pizzaButtonOne.Click += new System.EventHandler(this.button2_Click);
            // 
            // pizzaButtonTwo
            // 
            this.pizzaButtonTwo.Location = new System.Drawing.Point(205, 105);
            this.pizzaButtonTwo.Name = "pizzaButtonTwo";
            this.pizzaButtonTwo.Size = new System.Drawing.Size(166, 43);
            this.pizzaButtonTwo.TabIndex = 2;
            this.pizzaButtonTwo.Text = "Пепперони";
            this.pizzaButtonTwo.UseVisualStyleBackColor = true;
            this.pizzaButtonTwo.Click += new System.EventHandler(this.button3_Click);
            // 
            // pizzaButtonThree
            // 
            this.pizzaButtonThree.Location = new System.Drawing.Point(382, 105);
            this.pizzaButtonThree.Name = "pizzaButtonThree";
            this.pizzaButtonThree.Size = new System.Drawing.Size(166, 43);
            this.pizzaButtonThree.TabIndex = 3;
            this.pizzaButtonThree.Text = "Барселона";
            this.pizzaButtonThree.UseVisualStyleBackColor = true;
            this.pizzaButtonThree.Click += new System.EventHandler(this.button4_Click);
            // 
            // picturePizza3
            // 
            this.picturePizza3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturePizza3.ErrorImage")));
            this.picturePizza3.Image = ((System.Drawing.Image)(resources.GetObject("picturePizza3.Image")));
            this.picturePizza3.Location = new System.Drawing.Point(419, 49);
            this.picturePizza3.Name = "picturePizza3";
            this.picturePizza3.Size = new System.Drawing.Size(100, 53);
            this.picturePizza3.TabIndex = 8;
            this.picturePizza3.TabStop = false;
            // 
            // picturePizza2
            // 
            this.picturePizza2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturePizza2.ErrorImage")));
            this.picturePizza2.Image = ((System.Drawing.Image)(resources.GetObject("picturePizza2.Image")));
            this.picturePizza2.Location = new System.Drawing.Point(242, 49);
            this.picturePizza2.Name = "picturePizza2";
            this.picturePizza2.Size = new System.Drawing.Size(100, 50);
            this.picturePizza2.TabIndex = 9;
            this.picturePizza2.TabStop = false;
            // 
            // picturePizza1
            // 
            this.picturePizza1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picturePizza1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturePizza1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturePizza1.ErrorImage")));
            this.picturePizza1.Image = ((System.Drawing.Image)(resources.GetObject("picturePizza1.Image")));
            this.picturePizza1.Location = new System.Drawing.Point(65, 49);
            this.picturePizza1.Name = "picturePizza1";
            this.picturePizza1.Size = new System.Drawing.Size(100, 50);
            this.picturePizza1.TabIndex = 10;
            this.picturePizza1.TabStop = false;
            this.picturePizza1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // structure1
            // 
            this.structure1.Location = new System.Drawing.Point(28, 154);
            this.structure1.Name = "structure1";
            this.structure1.Size = new System.Drawing.Size(42, 23);
            this.structure1.TabIndex = 11;
            this.structure1.Text = "stru";
            this.structure1.UseVisualStyleBackColor = true;
            this.structure1.Click += new System.EventHandler(this.structure1_Click);
            // 
            // cal1
            // 
            this.cal1.Location = new System.Drawing.Point(76, 154);
            this.cal1.Name = "cal1";
            this.cal1.Size = new System.Drawing.Size(42, 23);
            this.cal1.TabIndex = 12;
            this.cal1.Text = "cal";
            this.cal1.UseVisualStyleBackColor = true;
            this.cal1.Click += new System.EventHandler(this.cal1_Click);
            // 
            // cal2
            // 
            this.cal2.Location = new System.Drawing.Point(253, 154);
            this.cal2.Name = "cal2";
            this.cal2.Size = new System.Drawing.Size(42, 23);
            this.cal2.TabIndex = 14;
            this.cal2.Text = "cal";
            this.cal2.UseVisualStyleBackColor = true;
            this.cal2.Click += new System.EventHandler(this.cal2_Click);
            // 
            // structure2
            // 
            this.structure2.Location = new System.Drawing.Point(205, 154);
            this.structure2.Name = "structure2";
            this.structure2.Size = new System.Drawing.Size(42, 23);
            this.structure2.TabIndex = 13;
            this.structure2.Text = "stru";
            this.structure2.UseVisualStyleBackColor = true;
            this.structure2.Click += new System.EventHandler(this.structure2_Click);
            // 
            // cal3
            // 
            this.cal3.Location = new System.Drawing.Point(430, 154);
            this.cal3.Name = "cal3";
            this.cal3.Size = new System.Drawing.Size(42, 23);
            this.cal3.TabIndex = 16;
            this.cal3.Text = "cal";
            this.cal3.UseVisualStyleBackColor = true;
            this.cal3.Click += new System.EventHandler(this.cal3_Click);
            // 
            // structure3
            // 
            this.structure3.Location = new System.Drawing.Point(382, 154);
            this.structure3.Name = "structure3";
            this.structure3.Size = new System.Drawing.Size(42, 23);
            this.structure3.TabIndex = 15;
            this.structure3.Text = "stru";
            this.structure3.UseVisualStyleBackColor = true;
            this.structure3.Click += new System.EventHandler(this.structure3_Click);
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
            // countOfPizzaInBox
            // 
            this.countOfPizzaInBox.Location = new System.Drawing.Point(538, 236);
            this.countOfPizzaInBox.Name = "countOfPizzaInBox";
            this.countOfPizzaInBox.ReadOnly = true;
            this.countOfPizzaInBox.Size = new System.Drawing.Size(22, 22);
            this.countOfPizzaInBox.TabIndex = 18;
            this.countOfPizzaInBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 302);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(108, 151);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Ничего нет";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(258, 410);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(166, 43);
            this.final.TabIndex = 22;
            this.final.Text = "Оформить заказ";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Location = new System.Drawing.Point(28, 210);
            this.textBoxConfig.Multiline = true;
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.ReadOnly = true;
            this.textBoxConfig.Size = new System.Drawing.Size(396, 175);
            this.textBoxConfig.TabIndex = 23;
            this.textBoxConfig.Visible = false;
            this.textBoxConfig.TextChanged += new System.EventHandler(this.textBoxConfig_TextChanged);
            // 
            // pricePizzaOne
            // 
            this.pricePizzaOne.Location = new System.Drawing.Point(124, 138);
            this.pricePizzaOne.Multiline = true;
            this.pricePizzaOne.Name = "pricePizzaOne";
            this.pricePizzaOne.ReadOnly = true;
            this.pricePizzaOne.Size = new System.Drawing.Size(70, 22);
            this.pricePizzaOne.TabIndex = 24;
            // 
            // pricePizzaTwo
            // 
            this.pricePizzaTwo.Location = new System.Drawing.Point(301, 138);
            this.pricePizzaTwo.Multiline = true;
            this.pricePizzaTwo.Name = "pricePizzaTwo";
            this.pricePizzaTwo.ReadOnly = true;
            this.pricePizzaTwo.Size = new System.Drawing.Size(70, 22);
            this.pricePizzaTwo.TabIndex = 25;
            // 
            // pricePizzaThree
            // 
            this.pricePizzaThree.Location = new System.Drawing.Point(478, 138);
            this.pricePizzaThree.Multiline = true;
            this.pricePizzaThree.Name = "pricePizzaThree";
            this.pricePizzaThree.ReadOnly = true;
            this.pricePizzaThree.Size = new System.Drawing.Size(70, 22);
            this.pricePizzaThree.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 27);
            this.button2.TabIndex = 27;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cleanTheBox
            // 
            this.cleanTheBox.Location = new System.Drawing.Point(452, 409);
            this.cleanTheBox.Name = "cleanTheBox";
            this.cleanTheBox.Size = new System.Drawing.Size(108, 44);
            this.cleanTheBox.TabIndex = 28;
            this.cleanTheBox.Text = "Очистить корзину";
            this.cleanTheBox.UseVisualStyleBackColor = true;
            this.cleanTheBox.Visible = false;
            this.cleanTheBox.Click += new System.EventHandler(this.cleanTheBox_Click);
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(-1, 2);
            this.Discount.Multiline = true;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Size = new System.Drawing.Size(248, 32);
            this.Discount.TabIndex = 29;
            this.Discount.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // PizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 465);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.cleanTheBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pricePizzaThree);
            this.Controls.Add(this.pricePizzaTwo);
            this.Controls.Add(this.pricePizzaOne);
            this.Controls.Add(this.textBoxConfig);
            this.Controls.Add(this.final);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.countOfPizzaInBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cal3);
            this.Controls.Add(this.structure3);
            this.Controls.Add(this.cal2);
            this.Controls.Add(this.structure2);
            this.Controls.Add(this.cal1);
            this.Controls.Add(this.structure1);
            this.Controls.Add(this.picturePizza1);
            this.Controls.Add(this.picturePizza2);
            this.Controls.Add(this.picturePizza3);
            this.Controls.Add(this.pizzaButtonThree);
            this.Controls.Add(this.pizzaButtonTwo);
            this.Controls.Add(this.pizzaButtonOne);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PizzaShop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Онлайн Пиццерия";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePizza3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePizza2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePizza1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pizzaButtonOne;
        private System.Windows.Forms.Button pizzaButtonTwo;
        private System.Windows.Forms.Button pizzaButtonThree;
        private System.Windows.Forms.PictureBox picturePizza3;
        private System.Windows.Forms.PictureBox picturePizza2;
        private System.Windows.Forms.PictureBox picturePizza1;
        private System.Windows.Forms.Button structure1;
        private System.Windows.Forms.Button cal1;
        private System.Windows.Forms.Button cal2;
        private System.Windows.Forms.Button structure2;
        private System.Windows.Forms.Button cal3;
        private System.Windows.Forms.Button structure3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox countOfPizzaInBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.TextBox textBoxConfig;
        private System.Windows.Forms.TextBox pricePizzaOne;
        private System.Windows.Forms.TextBox pricePizzaTwo;
        private System.Windows.Forms.TextBox pricePizzaThree;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cleanTheBox;
        private System.Windows.Forms.TextBox Discount;
    }
}


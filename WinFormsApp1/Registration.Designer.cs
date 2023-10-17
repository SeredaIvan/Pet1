namespace WinFormsApp1
{
    partial class Registration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPIB = new TextBox();
            textBoxPhonenumber = new TextBox();
            textBoxPin1 = new TextBox();
            textBoxPin2 = new TextBox();
            comboBoxTypeOfCard = new ComboBox();
            button1 = new Button();
            labelIsRegistry = new Label();
            textBoxNumberCard = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(269, 31);
            label1.TabIndex = 0;
            label1.Text = "Введіть ПІБ англійською";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 110);
            label2.Name = "label2";
            label2.Size = new Size(317, 31);
            label2.TabIndex = 1;
            label2.Text = "Введіть свій номер телефону";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 192);
            label3.Name = "label3";
            label3.Size = new Size(294, 31);
            label3.TabIndex = 2;
            label3.Text = "Виберіть платіжну систему";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 284);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 3;
            label4.Text = "Введіть пін";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(216, 284);
            label5.Name = "label5";
            label5.Size = new Size(156, 31);
            label5.TabIndex = 4;
            label5.Text = "Повторіть пін";
            // 
            // textBoxPIB
            // 
            textBoxPIB.Location = new Point(36, 80);
            textBoxPIB.Name = "textBoxPIB";
            textBoxPIB.Size = new Size(336, 27);
            textBoxPIB.TabIndex = 5;
            textBoxPIB.MouseClick += textBoxPIB_MouseClick;
            // 
            // textBoxPhonenumber
            // 
            textBoxPhonenumber.Location = new Point(36, 153);
            textBoxPhonenumber.Name = "textBoxPhonenumber";
            textBoxPhonenumber.Size = new Size(336, 27);
            textBoxPhonenumber.TabIndex = 6;
            textBoxPhonenumber.MouseClick += textBoxPhonenumber_MouseClick;
            // 
            // textBoxPin1
            // 
            textBoxPin1.Location = new Point(32, 333);
            textBoxPin1.Name = "textBoxPin1";
            textBoxPin1.PasswordChar = '*';
            textBoxPin1.Size = new Size(168, 27);
            textBoxPin1.TabIndex = 7;
            // 
            // textBoxPin2
            // 
            textBoxPin2.Location = new Point(216, 333);
            textBoxPin2.Name = "textBoxPin2";
            textBoxPin2.PasswordChar = '*';
            textBoxPin2.Size = new Size(156, 27);
            textBoxPin2.TabIndex = 8;
            textBoxPin2.MouseClick += textBoxPin2_MouseClick;
            textBoxPin2.TextChanged += textBoxPin2_TextChanged;
            // 
            // comboBoxTypeOfCard
            // 
            comboBoxTypeOfCard.FormattingEnabled = true;
            comboBoxTypeOfCard.Items.AddRange(new object[] { "Visa", "MasterCard" });
            comboBoxTypeOfCard.Location = new Point(36, 241);
            comboBoxTypeOfCard.Name = "comboBoxTypeOfCard";
            comboBoxTypeOfCard.Size = new Size(336, 28);
            comboBoxTypeOfCard.TabIndex = 9;
            comboBoxTypeOfCard.MouseClick += comboBoxTypeOfCard_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(32, 383);
            button1.Name = "button1";
            button1.Size = new Size(340, 55);
            button1.TabIndex = 10;
            button1.Text = "Реєструватись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelIsRegistry
            // 
            labelIsRegistry.AutoSize = true;
            labelIsRegistry.Location = new Point(32, 456);
            labelIsRegistry.Name = "labelIsRegistry";
            labelIsRegistry.Size = new Size(0, 20);
            labelIsRegistry.TabIndex = 11;
            labelIsRegistry.Visible = false;
            // 
            // textBoxNumberCard
            // 
            textBoxNumberCard.Location = new Point(32, 479);
            textBoxNumberCard.Name = "textBoxNumberCard";
            textBoxNumberCard.ReadOnly = true;
            textBoxNumberCard.Size = new Size(340, 27);
            textBoxNumberCard.TabIndex = 12;
            textBoxNumberCard.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(132, 3);
            label6.Name = "label6";
            label6.Size = new Size(128, 31);
            label6.TabIndex = 13;
            label6.Text = "Реєстрація";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 526);
            Controls.Add(label6);
            Controls.Add(textBoxNumberCard);
            Controls.Add(labelIsRegistry);
            Controls.Add(button1);
            Controls.Add(comboBoxTypeOfCard);
            Controls.Add(textBoxPin2);
            Controls.Add(textBoxPin1);
            Controls.Add(textBoxPhonenumber);
            Controls.Add(textBoxPIB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPIB;
        private TextBox textBoxPhonenumber;
        private TextBox textBoxPin1;
        private TextBox textBoxPin2;
        private ComboBox comboBoxTypeOfCard;
        private Button button1;
        private Label labelIsRegistry;
        private TextBox textBoxNumberCard;
        private Label label6;
    }
}
namespace WinFormsApp1
{
    partial class Cabinet
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
            label4 = new Label();
            label5 = new Label();
            labelPIB = new Label();
            labelNumberCard = new Label();
            labelCostInCard = new Label();
            buttonPerekazCost = new Button();
            button1 = new Button();
            button2 = new Button();
            labelBankName = new Label();
            label6 = new Label();
            labelATMName = new Label();
            label3 = new Label();
            label7 = new Label();
            labelCostsInATM = new Label();
            labelNumberCardPerekaz = new Label();
            label9 = new Label();
            textBoxNumberCardPerekaz = new TextBox();
            button3 = new Button();
            textBoxCostPerecaz = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            label8 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(493, 13);
            label1.Name = "label1";
            label1.Size = new Size(340, 46);
            label1.TabIndex = 0;
            label1.Text = "Кабінет користувача";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 107);
            label2.Margin = new Padding(30);
            label2.Name = "label2";
            label2.Size = new Size(49, 31);
            label2.TabIndex = 0;
            label2.Text = "ПІБ";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 182);
            label4.Margin = new Padding(30);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 2;
            label4.Text = "Номер карти";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 257);
            label5.Margin = new Padding(30);
            label5.Name = "label5";
            label5.Size = new Size(169, 31);
            label5.TabIndex = 3;
            label5.Text = "Кошти на карті";
            // 
            // labelPIB
            // 
            labelPIB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelPIB.AutoSize = true;
            labelPIB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelPIB.Location = new Point(235, 107);
            labelPIB.Margin = new Padding(30);
            labelPIB.Name = "labelPIB";
            labelPIB.Size = new Size(49, 31);
            labelPIB.TabIndex = 4;
            labelPIB.Text = "ПІБ";
            // 
            // labelNumberCard
            // 
            labelNumberCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelNumberCard.AutoSize = true;
            labelNumberCard.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberCard.Location = new Point(235, 182);
            labelNumberCard.Margin = new Padding(30);
            labelNumberCard.Name = "labelNumberCard";
            labelNumberCard.Size = new Size(150, 31);
            labelNumberCard.TabIndex = 5;
            labelNumberCard.Text = "Номер карти";
            // 
            // labelCostInCard
            // 
            labelCostInCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelCostInCard.AutoSize = true;
            labelCostInCard.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCostInCard.Location = new Point(235, 257);
            labelCostInCard.Margin = new Padding(30);
            labelCostInCard.Name = "labelCostInCard";
            labelCostInCard.Size = new Size(169, 31);
            labelCostInCard.TabIndex = 6;
            labelCostInCard.Text = "Кошти на карті";
            // 
            // buttonPerekazCost
            // 
            buttonPerekazCost.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPerekazCost.Location = new Point(14, 15);
            buttonPerekazCost.Name = "buttonPerekazCost";
            buttonPerekazCost.Size = new Size(365, 100);
            buttonPerekazCost.TabIndex = 7;
            buttonPerekazCost.Text = "Перказати кошти";
            buttonPerekazCost.UseVisualStyleBackColor = true;
            buttonPerekazCost.Click += buttonPerekazCost_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(14, 128);
            button1.Name = "button1";
            button1.Size = new Size(365, 100);
            button1.TabIndex = 8;
            button1.Text = "Зняти кошти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(14, 234);
            button2.Name = "button2";
            button2.Size = new Size(365, 100);
            button2.TabIndex = 9;
            button2.Text = "Внести кошти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelBankName
            // 
            labelBankName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelBankName.AutoSize = true;
            labelBankName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBankName.Location = new Point(797, 107);
            labelBankName.Margin = new Padding(30);
            labelBankName.Name = "labelBankName";
            labelBankName.Size = new Size(63, 31);
            labelBankName.TabIndex = 10;
            labelBankName.Text = "Банк";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(472, 107);
            label6.Margin = new Padding(30);
            label6.Name = "label6";
            label6.Size = new Size(63, 31);
            label6.TabIndex = 11;
            label6.Text = "Банк";
            // 
            // labelATMName
            // 
            labelATMName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelATMName.AutoSize = true;
            labelATMName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelATMName.Location = new Point(797, 182);
            labelATMName.Margin = new Padding(30);
            labelATMName.Name = "labelATMName";
            labelATMName.Size = new Size(207, 31);
            labelATMName.TabIndex = 12;
            labelATMName.Text = "Адреса банкомату";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(472, 182);
            label3.Margin = new Padding(30);
            label3.Name = "label3";
            label3.Size = new Size(207, 31);
            label3.TabIndex = 13;
            label3.Text = "Адреса банкомату";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(472, 257);
            label7.Margin = new Padding(30);
            label7.Name = "label7";
            label7.Size = new Size(309, 31);
            label7.TabIndex = 14;
            label7.Text = "Залишок коштів в банкоматі";
            // 
            // labelCostsInATM
            // 
            labelCostsInATM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelCostsInATM.AutoSize = true;
            labelCostsInATM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCostsInATM.Location = new Point(797, 257);
            labelCostsInATM.Margin = new Padding(30);
            labelCostsInATM.Name = "labelCostsInATM";
            labelCostsInATM.Size = new Size(309, 31);
            labelCostsInATM.TabIndex = 15;
            labelCostsInATM.Text = "Залишок коштів в банкоматі";
            // 
            // labelNumberCardPerekaz
            // 
            labelNumberCardPerekaz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelNumberCardPerekaz.AutoSize = true;
            labelNumberCardPerekaz.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberCardPerekaz.Location = new Point(408, 15);
            labelNumberCardPerekaz.Margin = new Padding(30);
            labelNumberCardPerekaz.Name = "labelNumberCardPerekaz";
            labelNumberCardPerekaz.Size = new Size(150, 31);
            labelNumberCardPerekaz.TabIndex = 16;
            labelNumberCardPerekaz.Text = "Номер карти";
            labelNumberCardPerekaz.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(637, 15);
            label9.Margin = new Padding(30);
            label9.Name = "label9";
            label9.Size = new Size(62, 31);
            label9.TabIndex = 17;
            label9.Text = ">>>";
            label9.Visible = false;
            // 
            // textBoxNumberCardPerekaz
            // 
            textBoxNumberCardPerekaz.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumberCardPerekaz.Location = new Point(732, 15);
            textBoxNumberCardPerekaz.Name = "textBoxNumberCardPerekaz";
            textBoxNumberCardPerekaz.Size = new Size(309, 38);
            textBoxNumberCardPerekaz.TabIndex = 18;
            textBoxNumberCardPerekaz.Text = "Введіть номер карти";
            textBoxNumberCardPerekaz.Visible = false;
            textBoxNumberCardPerekaz.MouseClick += textBoxNumberCardPerekaz_MouseClick_1;
            textBoxNumberCardPerekaz.TextChanged += textBoxNumberCardPerekaz_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(408, 51);
            button3.Name = "button3";
            button3.Size = new Size(217, 38);
            button3.TabIndex = 19;
            button3.Text = "Переслати";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // textBoxCostPerecaz
            // 
            textBoxCostPerecaz.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCostPerecaz.Location = new Point(732, 71);
            textBoxCostPerecaz.Name = "textBoxCostPerecaz";
            textBoxCostPerecaz.Size = new Size(309, 38);
            textBoxCostPerecaz.TabIndex = 20;
            textBoxCostPerecaz.Text = "Введіть суму переказу";
            textBoxCostPerecaz.Visible = false;
            textBoxCostPerecaz.MouseClick += textBoxCostPerecaz_MouseClick_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(408, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 38);
            textBox2.TabIndex = 25;
            textBox2.Text = "Введіть скільки хочете зняти";
            textBox2.Visible = false;
            textBox2.MouseClick += textBox2_MouseClick_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(732, 165);
            button4.Name = "button4";
            button4.Size = new Size(309, 38);
            button4.TabIndex = 24;
            button4.Text = "Зняти кошти";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(408, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 38);
            textBox3.TabIndex = 26;
            textBox3.Text = "Введіть скільки хочете внести";
            textBox3.Visible = false;
            textBox3.MouseClick += textBox3_MouseClick_1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(732, 271);
            button5.Name = "button5";
            button5.Size = new Size(309, 38);
            button5.TabIndex = 27;
            button5.Text = "Внести кошти";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(408, 92);
            label8.Name = "label8";
            label8.Size = new Size(29, 31);
            label8.TabIndex = 28;
            label8.Text = "...";
            label8.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 74);
            panel1.TabIndex = 29;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(26, 23);
            label10.Margin = new Padding(30);
            label10.Name = "label10";
            label10.Size = new Size(63, 31);
            label10.TabIndex = 30;
            label10.Text = "Банк";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(buttonPerekazCost);
            panel2.Controls.Add(labelNumberCardPerekaz);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBoxNumberCardPerekaz);
            panel2.Controls.Add(textBoxCostPerecaz);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(25, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(1216, 340);
            panel2.TabIndex = 30;
            // 
            // Cabinet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelCostsInATM);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(labelATMName);
            Controls.Add(label6);
            Controls.Add(labelBankName);
            Controls.Add(labelCostInCard);
            Controls.Add(labelNumberCard);
            Controls.Add(labelPIB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "Cabinet";
            Text = "Cabinet";
            Load += Cabinet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label labelPIB;
        private Label labelNumberCard;
        private Label labelCostInCard;
        private Button buttonPerekazCost;
        private Button button1;
        private Button button2;
        private Label labelBankName;
        private Label label6;
        private Label labelATMName;
        private Label label3;
        private Label label7;
        private Label labelCostsInATM;
        private Label labelNumberCardPerekaz;
        private Label label9;
        private TextBox textBoxNumberCardPerekaz;
        private Button button3;
        private TextBox textBoxCostPerecaz;
        private TextBox textBox2;
        private Button button4;
        private TextBox textBox3;
        private Button button5;
        private Label label8;
        private Panel panel1;
        private Label label10;
        private Panel panel2;
    }
}
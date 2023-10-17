namespace WinFormsApp1
{
    partial class Master
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(65, 32);
            label1.Name = "label1";
            label1.Size = new Size(329, 62);
            label1.TabIndex = 0;
            label1.Text = "Виберіть банк";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(431, 411);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Середа Іван ВТ-22-1";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "1";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ПриватБанк", "ОщадБанк" });
            comboBox1.Location = new Point(60, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(329, 28);
            comboBox1.TabIndex = 0;
            comboBox1.ValueMember = "0";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 164);
            label3.Name = "label3";
            label3.Size = new Size(512, 46);
            label3.TabIndex = 2;
            label3.Text = "Виберіть банкомат цього банку";
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(60, 242);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(500, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Location = new Point(60, 304);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(512, 57);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(246, 50);
            button1.TabIndex = 0;
            button1.Text = "Реєстрація";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 3);
            button2.Name = "button2";
            button2.Size = new Size(245, 50);
            button2.TabIndex = 1;
            button2.Text = "Ввійти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 107);
            panel1.TabIndex = 5;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 440);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Name = "Master";
            Text = "Banking";
            Load += Master_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}
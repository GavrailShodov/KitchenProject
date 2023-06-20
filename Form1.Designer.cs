namespace KitchenProject
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
            components = new System.ComponentModel.Container();
            EnterButton = new Button();
            furnitureBindingSource = new BindingSource(components);
            HeightBox = new TextBox();
            WidthBox = new TextBox();
            DepthBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FurnitureNameBox = new TextBox();
            OutputBox = new TextBox();
            TypesBox = new ComboBox();
            label6 = new Label();
            ShowButton = new Button();
            panel1 = new Panel();
            labelblenda = new Label();
            cokulBox = new TextBox();
            label9 = new Label();
            raftoveBox = new TextBox();
            label8 = new Label();
            kantBox = new TextBox();
            label7 = new Label();
            categoryBox = new ComboBox();
            button1 = new Button();
            downloadButton = new Button();
            orderNameBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(425, 49);
            EnterButton.Margin = new Padding(3, 2, 3, 2);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(93, 29);
            EnterButton.TabIndex = 0;
            EnterButton.Text = "Добави";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += button1_Click;
            // 
            // furnitureBindingSource
            // 
            furnitureBindingSource.DataSource = typeof(Models.Furniture);
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(15, 326);
            HeightBox.Margin = new Padding(3, 2, 3, 2);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(125, 24);
            HeightBox.TabIndex = 3;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(199, 326);
            WidthBox.Margin = new Padding(3, 2, 3, 2);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(125, 24);
            WidthBox.TabIndex = 4;
            WidthBox.TextChanged += textBox2_TextChanged;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(393, 326);
            DepthBox.Margin = new Padding(3, 2, 3, 2);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(125, 24);
            DepthBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 7;
            label1.Text = "Име на поръчка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 306);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 8;
            label2.Text = "Височина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 303);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 9;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 303);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 10;
            label4.Text = "Дълбочина";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 159);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 11;
            label5.Text = "Вид мебел";
            // 
            // FurnitureNameBox
            // 
            FurnitureNameBox.Location = new Point(15, 270);
            FurnitureNameBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureNameBox.Name = "FurnitureNameBox";
            FurnitureNameBox.Size = new Size(125, 24);
            FurnitureNameBox.TabIndex = 12;
            // 
            // OutputBox
            // 
            OutputBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputBox.Location = new Point(759, 25);
            OutputBox.Margin = new Padding(3, 2, 3, 2);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.ScrollBars = ScrollBars.Vertical;
            OutputBox.Size = new Size(673, 680);
            OutputBox.TabIndex = 14;
            // 
            // TypesBox
            // 
            TypesBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypesBox.FormattingEnabled = true;
            TypesBox.Location = new Point(14, 181);
            TypesBox.Margin = new Padding(3, 4, 3, 4);
            TypesBox.Name = "TypesBox";
            TypesBox.Size = new Size(632, 26);
            TypesBox.TabIndex = 16;
            TypesBox.SelectedIndexChanged += TypesBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 247);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 17;
            label6.Text = "Име мебел";
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(548, 47);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(96, 29);
            ShowButton.TabIndex = 18;
            ShowButton.Text = "Покажи";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(labelblenda);
            panel1.Controls.Add(cokulBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(raftoveBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(kantBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(categoryBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(downloadButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(orderNameBox);
            panel1.Controls.Add(FurnitureNameBox);
            panel1.Controls.Add(TypesBox);
            panel1.Controls.Add(EnterButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(WidthBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(HeightBox);
            panel1.Controls.Add(DepthBox);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 518);
            panel1.TabIndex = 19;
            // 
            // labelblenda
            // 
            labelblenda.AutoSize = true;
            labelblenda.Location = new Point(393, 366);
            labelblenda.Name = "labelblenda";
            labelblenda.Size = new Size(59, 18);
            labelblenda.TabIndex = 28;
            labelblenda.Text = "Цокъл";
            // 
            // cokulBox
            // 
            cokulBox.Location = new Point(393, 386);
            cokulBox.Margin = new Padding(3, 2, 3, 2);
            cokulBox.Name = "cokulBox";
            cokulBox.Size = new Size(125, 24);
            cokulBox.TabIndex = 27;
            cokulBox.TextChanged += blendaBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(199, 366);
            label9.Name = "label9";
            label9.Size = new Size(78, 18);
            label9.TabIndex = 26;
            label9.Text = "Рафтове";
            // 
            // raftoveBox
            // 
            raftoveBox.Location = new Point(199, 386);
            raftoveBox.Margin = new Padding(3, 2, 3, 2);
            raftoveBox.Name = "raftoveBox";
            raftoveBox.Size = new Size(125, 24);
            raftoveBox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 366);
            label8.Name = "label8";
            label8.Size = new Size(125, 18);
            label8.TabIndex = 24;
            label8.Text = "Кант дебелина";
            // 
            // kantBox
            // 
            kantBox.Location = new Point(14, 386);
            kantBox.Margin = new Padding(3, 2, 3, 2);
            kantBox.Name = "kantBox";
            kantBox.Size = new Size(125, 24);
            kantBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 107);
            label7.Name = "label7";
            label7.Size = new Size(89, 18);
            label7.TabIndex = 22;
            label7.Text = "Категория";
            label7.Click += label7_Click;
            // 
            // categoryBox
            // 
            categoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Гардероб", "Надстройкa" });
            categoryBox.Location = new Point(15, 129);
            categoryBox.Margin = new Padding(3, 4, 3, 4);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(319, 26);
            categoryBox.TabIndex = 21;
            categoryBox.SelectedIndexChanged += categoryBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(232, 471);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(216, 33);
            button1.TabIndex = 20;
            button1.Text = "Свали материали";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(14, 473);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(188, 29);
            downloadButton.TabIndex = 19;
            downloadButton.Text = "Свали поръчка";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += button1_Click_1;
            // 
            // orderNameBox
            // 
            orderNameBox.FormattingEnabled = true;
            orderNameBox.Location = new Point(18, 51);
            orderNameBox.Name = "orderNameBox";
            orderNameBox.Size = new Size(151, 26);
            orderNameBox.TabIndex = 6;
            orderNameBox.SelectedIndexChanged += orderNameBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1453, 685);
            Controls.Add(ShowButton);
            Controls.Add(OutputBox);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterButton;
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zDataGridViewTextBoxColumn;
        private TextBox HeightBox;
        private TextBox WidthBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox DepthBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox FurnitureNameBox;
        private ComboBox TypesBox;
        private Label label6;
        public TextBox OutputBox;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource furnitureBindingSource;
        private Button ShowButton;
        private Panel panel1;
        private ComboBox orderNameBox;
        private Button downloadButton;
        private Button button1;
        private Label label7;
        private ComboBox categoryBox;
        private Label label9;
        private TextBox raftoveBox;
        private Label label8;
        private TextBox kantBox;
        private Label labelblenda;
        private TextBox cokulBox;
    }
}
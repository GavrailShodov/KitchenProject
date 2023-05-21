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
            dataGridView1 = new DataGridView();
            orderNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            depthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            orderNameBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderNameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, depthDataGridViewTextBoxColumn });
            dataGridView1.DataSource = furnitureBindingSource;
            dataGridView1.Location = new Point(15, 258);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(695, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orderNameDataGridViewTextBoxColumn
            // 
            orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
            orderNameDataGridViewTextBoxColumn.HeaderText = "OrderName";
            orderNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
            orderNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.Width = 125;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Width";
            widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.Width = 125;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            depthDataGridViewTextBoxColumn.MinimumWidth = 6;
            depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            depthDataGridViewTextBoxColumn.Width = 125;
            // 
            // furnitureBindingSource
            // 
            furnitureBindingSource.DataSource = typeof(Models.Furniture);
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(13, 171);
            HeightBox.Margin = new Padding(3, 2, 3, 2);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(125, 29);
            HeightBox.TabIndex = 3;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(197, 171);
            WidthBox.Margin = new Padding(3, 2, 3, 2);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(125, 29);
            WidthBox.TabIndex = 4;
            WidthBox.TextChanged += textBox2_TextChanged;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(391, 171);
            DepthBox.Margin = new Padding(3, 2, 3, 2);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(125, 29);
            DepthBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 7;
            label1.Text = "Име на поръчка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 148);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 8;
            label2.Text = "Височина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 148);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 9;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 148);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 10;
            label4.Text = "Дълбочина";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 89);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 11;
            label5.Text = "Вид мебел";
            // 
            // FurnitureNameBox
            // 
            FurnitureNameBox.Location = new Point(13, 115);
            FurnitureNameBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureNameBox.Name = "FurnitureNameBox";
            FurnitureNameBox.Size = new Size(125, 29);
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
            TypesBox.Items.AddRange(new object[] { "Обикновен шкаф" });
            TypesBox.Location = new Point(197, 112);
            TypesBox.Margin = new Padding(3, 4, 3, 4);
            TypesBox.Name = "TypesBox";
            TypesBox.Size = new Size(319, 32);
            TypesBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 92);
            label6.Name = "label6";
            label6.Size = new Size(117, 24);
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
            panel1.Controls.Add(orderNameBox);
            panel1.Controls.Add(EnterButton);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 255);
            panel1.TabIndex = 19;
            // 
            // orderNameBox
            // 
            orderNameBox.FormattingEnabled = true;
            orderNameBox.Location = new Point(15, 54);
            orderNameBox.Name = "orderNameBox";
            orderNameBox.Size = new Size(151, 32);
            orderNameBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1453, 685);
            Controls.Add(ShowButton);
            Controls.Add(label6);
            Controls.Add(TypesBox);
            Controls.Add(OutputBox);
            Controls.Add(FurnitureNameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DepthBox);
            Controls.Add(WidthBox);
            Controls.Add(HeightBox);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterButton;
        private DataGridView dataGridView1;
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
        private DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private BindingSource furnitureBindingSource;
        private Button ShowButton;
        private Panel panel1;
        private ComboBox orderNameBox;
    }
}
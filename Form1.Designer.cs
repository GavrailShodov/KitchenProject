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
            furnitureBindingSource2 = new BindingSource(components);
            furnitureBindingSource1 = new BindingSource(components);
            furnitureBindingSource = new BindingSource(components);
            HeightBox = new TextBox();
            WidthBox = new TextBox();
            orderNameBox = new TextBox();
            DepthBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FurnitureNameBox = new TextBox();
            OutputBox = new TextBox();
            listBox1 = new ListBox();
            TypesBox = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(634, 72);
            EnterButton.Margin = new Padding(5, 4, 5, 4);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(141, 44);
            EnterButton.TabIndex = 0;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderNameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, depthDataGridViewTextBoxColumn });
            dataGridView1.DataSource = furnitureBindingSource2;
            dataGridView1.Location = new Point(21, 758);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1042, 282);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orderNameDataGridViewTextBoxColumn
            // 
            orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
            orderNameDataGridViewTextBoxColumn.HeaderText = "OrderName";
            orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Width";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // depthDataGridViewTextBoxColumn
            // 
            depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            // 
            // furnitureBindingSource2
            // 
            furnitureBindingSource2.DataSource = typeof(Models.Furniture);
            // 
            // furnitureBindingSource1
            // 
            furnitureBindingSource1.DataSource = typeof(Models.Furniture);
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(21, 256);
            HeightBox.Margin = new Padding(5, 4, 5, 4);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(186, 35);
            HeightBox.TabIndex = 3;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(295, 256);
            WidthBox.Margin = new Padding(5, 4, 5, 4);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(186, 35);
            WidthBox.TabIndex = 4;
            WidthBox.TextChanged += textBox2_TextChanged;
            // 
            // orderNameBox
            // 
            orderNameBox.Location = new Point(21, 72);
            orderNameBox.Margin = new Padding(5, 4, 5, 4);
            orderNameBox.Name = "orderNameBox";
            orderNameBox.Size = new Size(186, 35);
            orderNameBox.TabIndex = 5;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(586, 256);
            DepthBox.Margin = new Padding(5, 4, 5, 4);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(186, 35);
            DepthBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 7;
            label1.Text = "Име на поръчка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 222);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 8;
            label2.Text = "Височина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 222);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 9;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 222);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 10;
            label4.Text = "Дълбочина";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 134);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 30);
            label5.TabIndex = 11;
            label5.Text = "Вид мебел";
            // 
            // FurnitureNameBox
            // 
            FurnitureNameBox.Location = new Point(21, 172);
            FurnitureNameBox.Margin = new Padding(5, 4, 5, 4);
            FurnitureNameBox.Name = "FurnitureNameBox";
            FurnitureNameBox.Size = new Size(186, 35);
            FurnitureNameBox.TabIndex = 12;
            // 
            // OutputBox
            // 
            OutputBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputBox.Location = new Point(1138, 38);
            OutputBox.Margin = new Padding(5, 4, 5, 4);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.ScrollBars = ScrollBars.Vertical;
            OutputBox.Size = new Size(264, 569);
            OutputBox.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(586, 326);
            listBox1.Margin = new Padding(5, 6, 5, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 184);
            listBox1.TabIndex = 15;
            // 
            // TypesBox
            // 
            TypesBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypesBox.FormattingEnabled = true;
            TypesBox.Items.AddRange(new object[] { "Обикновен шкаф" });
            TypesBox.Location = new Point(295, 170);
            TypesBox.Margin = new Padding(5, 6, 5, 6);
            TypesBox.Name = "TypesBox";
            TypesBox.Size = new Size(186, 38);
            TypesBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 138);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 30);
            label6.TabIndex = 17;
            label6.Text = "Име мебел";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1436, 578);
            Controls.Add(label6);
            Controls.Add(TypesBox);
            Controls.Add(listBox1);
            Controls.Add(OutputBox);
            Controls.Add(FurnitureNameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DepthBox);
            Controls.Add(orderNameBox);
            Controls.Add(WidthBox);
            Controls.Add(HeightBox);
            Controls.Add(dataGridView1);
            Controls.Add(EnterButton);
            Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            //Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zDataGridViewTextBoxColumn;
        private BindingSource furnitureBindingSource;
        private TextBox HeightBox;
        private TextBox WidthBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource furnitureBindingSource1;
        private TextBox orderNameBox;
        private TextBox DepthBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox FurnitureNameBox;
        private DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private BindingSource furnitureBindingSource2;
        private ListBox listBox1;
        private ComboBox TypesBox;
        private Label label6;
        public TextBox OutputBox;
    }
}
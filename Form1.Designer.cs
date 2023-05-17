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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(370, 36);
            EnterButton.Margin = new Padding(3, 2, 3, 2);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(82, 22);
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
            dataGridView1.Location = new Point(12, 379);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(608, 141);
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
            HeightBox.Location = new Point(12, 128);
            HeightBox.Margin = new Padding(3, 2, 3, 2);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(110, 23);
            HeightBox.TabIndex = 3;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(172, 128);
            WidthBox.Margin = new Padding(3, 2, 3, 2);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(110, 23);
            WidthBox.TabIndex = 4;
            WidthBox.TextChanged += textBox2_TextChanged;
            // 
            // orderNameBox
            // 
            orderNameBox.Location = new Point(12, 36);
            orderNameBox.Margin = new Padding(3, 2, 3, 2);
            orderNameBox.Name = "orderNameBox";
            orderNameBox.Size = new Size(110, 23);
            orderNameBox.TabIndex = 5;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(342, 128);
            DepthBox.Margin = new Padding(3, 2, 3, 2);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(110, 23);
            DepthBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 7;
            label1.Text = "Име на поръчка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Височина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 111);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Дълбочина";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 11;
            label5.Text = "Вид мебел";
            // 
            // FurnitureNameBox
            // 
            FurnitureNameBox.Location = new Point(12, 86);
            FurnitureNameBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureNameBox.Name = "FurnitureNameBox";
            FurnitureNameBox.Size = new Size(110, 23);
            FurnitureNameBox.TabIndex = 12;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(664, 19);
            OutputBox.Margin = new Padding(3, 2, 3, 2);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.Size = new Size(777, 501);
            OutputBox.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 569);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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
        private TextBox OutputBox;
    }
}
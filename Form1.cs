using KitchenProject.Models;
using KitchenProject.Services;
using System.Security.AccessControl;
using System.Text;

namespace KitchenProject
{
    public partial class Form1 : Form
    {
        FileService fs = new FileService();
        FurnitureCalculateService fcs = new FurnitureCalculateService();
        public Form1()
        {
            createFolderOrdeers();
            InitializeComponent();
            addExistingOrders();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Furniture> input = new List<Furniture>();
            Furniture newItem = new Furniture();
            newItem.OrderName = orderNameBox.Text.ToString();
            newItem.Name = FurnitureNameBox.Text.ToString();
            newItem.Type = TypesBox.Text.ToString();
            newItem.Height = double.Parse(HeightBox.Text.ToString());
            newItem.Width = double.Parse(WidthBox.Text.ToString());
            newItem.Depth = double.Parse(DepthBox.Text.ToString());

            var scvPath = Path.Combine(Environment.CurrentDirectory + "/Поръчки", orderNameBox.Text.ToString() + $".scv");
            if (!File.Exists(scvPath))
            {
                input.Add(newItem);
                fs.SaveInFile(orderNameBox.Text.ToString(), input);
            }
            else
            {

                List<Furniture> Items = fs.ReadFile(orderNameBox.Text.ToString());
                Furniture item = Items.FirstOrDefault(x => x.Name == FurnitureNameBox.Text.ToString() && x.Type == TypesBox.Text.ToString());
                if (item == null)
                {
                    input.Add(newItem);
                    fs.SaveInFile(orderNameBox.Text.ToString(), input);
                }
                else
                {
                    MessageBox.Show(
                         "Не може да имаш две неща с еднакво име и еднакъв тип. Кво пак не разбра. :)",
                         "Пак съм аз",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning
                    );
                }

            }





            List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());
            dataGridView1.DataSource = furnitures;

            OutputBox.Text = fcs.ListInfo(furnitures);
        }
        private void addExistingOrders()
        {
            var orders = fs.getExistingOrdersNames();

            foreach (var order in orders)
            {
                orderNameBox.Items.Add(order);
            }
        }

        private void createFolderOrdeers()
        {
            string projectPath = Directory.GetCurrentDirectory();
            string folderName = Path.Combine(projectPath, "Поръчки");
            if (!Directory.Exists(folderName))
            {
                System.IO.Directory.CreateDirectory(folderName);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Furniture newItem = new Furniture();
            newItem.Type = TypesBox.Text.ToString();
            List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());
            dataGridView1.DataSource = furnitures;

            OutputBox.Text = fcs.ListInfo(furnitures);
        }

        private void orderNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());
            fs.ExportOrder(furnitures, fcs, orderNameBox.Text.ToString());
        }

        private void orderNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());
            dataGridView1.DataSource = furnitures;

            OutputBox.Text = fcs.ListInfo(furnitures);
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());

            //e.Graphics.DrawImage(bitmap,0,0);
            e.Graphics.DrawString(fcs.ListInfo(furnitures), new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {


        }
    }
}
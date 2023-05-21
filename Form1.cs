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
            input.Add(newItem);

            fs.SaveInFile(orderNameBox.Text.ToString(), input);

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
    }
}
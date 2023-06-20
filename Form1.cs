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
        ExelService exelService = new ExelService();
        public Form1()
        {
            createFolderOrdeers();
            InitializeComponent();
            addExistingOrders();
            setDefaultValue();

        }
        private void setDefaultValue()
        {
            HeightBox.Text = "0";
            WidthBox.Text = "0";
            DepthBox.Text = "0";
            kantBox.Text = "0";
            raftoveBox.Text = "0";
            cokulBox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Furniture> input = new List<Furniture>();
            Furniture newItem = new Furniture();
            newItem.OrderName = orderNameBox.Text.ToString();
            newItem.Name = FurnitureNameBox.Text.ToString();
            string type = string.Concat(categoryBox.Text.ToString(), " ", TypesBox.Text.ToString());
            newItem.Type = type;
            newItem.Height = double.Parse(HeightBox.Text.ToString());
            newItem.Width = double.Parse(WidthBox.Text.ToString());
            newItem.Depth = double.Parse(DepthBox.Text.ToString());
            newItem.Kant = double.Parse(kantBox.Text.ToString());
            newItem.Shelfs = double.Parse(raftoveBox.Text.ToString());
            newItem.cokul = double.Parse(cokulBox.Text.ToString());


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
            // Furniture newItem = new Furniture();
            //newItem.Type = TypesBox.Text.ToString();
            //List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());
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

            OutputBox.Text = fcs.ListInfo(furnitures);
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<Furniture> furnitures = fs.ReadFile(orderNameBox.Text.ToString());

            exelService.WriteExelFile(fcs.Materials(furnitures), orderNameBox.Text.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TypesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> wardrobes = new List<string> { "Еднокрилен,без крачета", "Обикновен шкаф" };
            List<string> upbuildings = new List<string> { "за Еднокрилен, без таван" };
            switch (categoryBox.Text)
            {
                case "Гардероб":
                    TypesBox.Items.Clear();
                    TypesBox.Items.AddRange(wardrobes.ToArray());
                    break;
                case "Надстройкa":
                    TypesBox.Items.Clear();
                    TypesBox.Items.AddRange(upbuildings.ToArray());
                    break;
            }
        }

        private void blendaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
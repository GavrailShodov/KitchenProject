using KitchenProject.Models;
using KitchenProject.Services;
using System.Text;

namespace KitchenProject
{
    public partial class Form1 : Form
    {
        FurnitureService fs = new FurnitureService();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Furniture> furnitures = new List<Furniture>();
            Furniture newItem = new Furniture();
            newItem.OrderName = orderNameBox.Text.ToString();
            newItem.Name = FurnitureNameBox.Text.ToString();
            newItem.Height = double.Parse(HeightBox.Text.ToString());
            newItem.Width = double.Parse(WidthBox.Text.ToString());
            newItem.Depth = double.Parse(DepthBox.Text.ToString());
            furnitures.Add(newItem);

            fs.SaveInFile(orderNameBox.Text.ToString(), furnitures);

            List<Furniture> furniture = fs.ReadFile(orderNameBox.Text.ToString());
            dataGridView1.DataSource = furniture;

            foreach (var item in furniture)
            {
                StringBuilder sb = new StringBuilder(OutputBox.Text);
                sb.AppendLine("dsadsaasda " + item.Name + item.Height + item.Width + item.Depth);
                

                OutputBox.Text = sb.ToString();
                
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
    }
}
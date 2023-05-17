using KitchenProject.Models;
using KitchenProject.Services;

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

            fs.SaveInFile();
            //dataGridView1.DataSource = fs.furnitures;

            List<Furniture> furniture = fs.ReadFile("1");
            dataGridView1.DataSource = furniture;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final
{
    public partial class Customer : Form
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = client.GetDatabase("Car_rental_system");
        static IMongoCollection<Customerss> collection = db.GetCollection<Customerss>("Customers");

        public void ReadAllDocuments()
        {
            List<Customerss> list = collection.AsQueryable().ToList<Customerss>();
            dataGridView1.DataSource = list;

            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();

        }

        public Customer()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customerss s = new Customerss(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, int.Parse(textBox6.Text));
            collection.InsertOne(s);
            ReadAllDocuments();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateField = Builders<Customerss>.Update
        .Set("name", textBox2.Text)
        .Set("address", textBox3.Text)
        .Set("phoneNumber", textBox4.Text)
            .Set("renting", textBox5.Text)
            .Set("timesRenting", textBox6.Text);

            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateField);
            ReadAllDocuments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Vehicles_Collection diaa = new Vehicles_Collection();
            diaa.Show();


        }
    }
}

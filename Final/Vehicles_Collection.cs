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

namespace Final
{
    public partial class Vehicles_Collection : Form
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = client.GetDatabase("Car_rental_system");
        static IMongoCollection<Vehicles> collection = db.GetCollection<Vehicles>("vehicles");
        public void ReadAllDocuments()
        {
            List<Vehicles> list = collection.AsQueryable().ToList<Vehicles>();
            dataGridView1.DataSource = list;

            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();

        }
        public Vehicles_Collection()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void Vehicles_Collection_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            Vehicles s = new Vehicles(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            collection.InsertOne(s);
            ReadAllDocuments();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateField = Builders<Vehicles>.Update
      .Set("type", textBox2.Text)
      .Set("name_model", textBox3.Text)
      .Set("year", textBox4.Text)
      .Set("price", textBox5.Text)
      .Set("rented", textBox6.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateField);
            ReadAllDocuments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer diaa2 = new Customer();
            diaa2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

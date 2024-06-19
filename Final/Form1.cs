using MongoDB.Bson;
using MongoDB.Driver;

namespace Final
{
    public partial class Form1 : Form
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = client.GetDatabase("Car_rental_system");
        static IMongoCollection<Employess> collection = db.GetCollection<Employess>("employess");
        public void ReadAllDocuments()
        {
            List<Employess> list = collection.AsQueryable().ToList<Employess>();
            dataGridView1.DataSource = list;

            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

        }
        public Form1()
        {

            InitializeComponent();
            ReadAllDocuments();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employess s = new Employess(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            collection.InsertOne(s);
            ReadAllDocuments();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateField = Builders<Employess>.Update
        .Set("name", textBox2.Text)
        .Set("phoneNumber", textBox3.Text)
        .Set("address", textBox4.Text)
        .Set("rentalLocationName", textBox5.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateField);
            ReadAllDocuments();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer diaa = new Customer();
            diaa.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

using WinFormsApp4;
namespace WinFormsApp4
{


    public partial class Form1 : Form
    {
        public List<Item> items = new List<Item>();

 
        public Form1()
        {
            Form2 form = new Form2(this);
            InitializeComponent();
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = items;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            UpdateListBox();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = items.Count;
            Form2 form2 = new Form2(this);
            form2.Show();
            if(temp < items.Count)
            {
                items.RemoveAt(listBox1.SelectedIndex);
                UpdateListBox();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             items.RemoveAt(listBox1.SelectedIndex);
             UpdateListBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            items.Clear();
            UpdateListBox();
        }
    }
}
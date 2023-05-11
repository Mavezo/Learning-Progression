using System.Text;

namespace SP_9__dz_lab_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<CV> list = new List<CV>();
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] files = openFileDialog1.FileNames;

            foreach(string file in files)
            { 
                using (TextReader reader = new StreamReader(file))
                {
                    list.Add(new CV(reader.ReadToEnd()));
                }
            }


            listBox1.ValueMember = "Text";
            listBox1.DisplayMember = "FullName";
            listBox1.DataSource = list;

            textBox1.Text = listBox1.SelectedValue.ToString();

            //Statistic
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The most experienced candidate (by number of years of experience): {list.AsParallel().MaxBy(t => t.Experience).FullName}\r\n");
            sb.AppendLine($"The most inexperienced candidate (by number of years of experience): {list.AsParallel().MinBy(t=>t.Experience).FullName}\r\n");
            sb.AppendLine($"The candidate with the lowest salary requirements: {list.AsParallel().MinBy(t=>t.Salary).FullName}\r\n");
            sb.AppendLine($" Candidate with the highest salary requirements: {list.AsParallel().MaxBy(t=>t.Salary).FullName}\r\n");
            textBox2.Text = sb.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            list = new List<CV>();
            openFileDialog1.Filter = "|*.txt";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = list[listBox1.SelectedIndex].Text;
        }
    }
}
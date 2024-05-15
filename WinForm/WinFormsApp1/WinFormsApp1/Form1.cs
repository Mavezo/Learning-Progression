using System;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Oil> lo = new List<Oil> {  new Oil(49.48, "Бензин А-95"),
                                                    new Oil(50.16, "Бензин А-95 премиум"),
                                                    new Oil(47.89, "Бензин А-92"),
                                                    new Oil(53.18, "Дизельное топливо"),
                                                    new Oil(57.05, "Дизельное топливо премиум"),
                                                    new Oil(26.11, "Газ авто­мобильный"),
        };
        double totalPrice = 0;
        double oilCount = 0;
        double oilPrice = 0;

        double totalHotDogs = 0;
        double totalHamburgers = 0;
        double totalPotato = 0;
        double totalCola = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            comboBox_oil.DataSource= lo;
            textBox_price_Oil.Text = lo[0].price.ToString(); 
        }
        private void amount_CheckedChanged(object sender, EventArgs e)
        {
            if (amount.Checked)
            {
                textBox3.ReadOnly = true;
                textBox2.ReadOnly = false;
            }
            else
            {
                price.Enabled = true;
                price_CheckedChanged(sender, e); 
            }
        }
        private void price_CheckedChanged(object sender, EventArgs e)
        {
            if (price.Checked)
            {
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = false;
            }
            else
            {
                amount.Enabled = true;
                amount_CheckedChanged(sender, e);
            }
        }
        private void comboBox_oil_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_price_Oil.Text = (comboBox_oil.SelectedItem as Oil).price.ToString();
            if (textBox2.ReadOnly)
            {
                textBox3_TextChanged(sender, e);
            }
            if (textBox3.ReadOnly)
            {
                textBox2_TextChanged(sender, e);
            }
        }

        bool FromTextBox2 = false;
        bool FromTextBox3 = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (FromTextBox3)
            {
                oilPrice = oilCount * double.Parse(textBox_price_Oil.Text);
                label1.Text = oilPrice.ToString("f2");
                FromTextBox3 = false;
                return;
            }
            if(!double.TryParse(textBox2.Text, out oilCount))
            {
                if (textBox2.Text == "")
                {
                    return;
                }
                textBox2.Text = null;
                MessageBox.Show("Wrong number!");
            }
            else
            {
                oilPrice = oilCount * double.Parse(textBox_price_Oil.Text);
                label1.Text = oilPrice.ToString("f2");
                FromTextBox2 = true;
                textBox3.Text = oilPrice.ToString("f2");
                FromTextBox3 = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (FromTextBox2)
            {
                label1.Text = oilPrice.ToString("f2");
                oilCount = oilPrice / double.Parse(textBox_price_Oil.Text);
                FromTextBox2 = false;
                return;
            }
            if (!double.TryParse(textBox3.Text, out oilPrice))
            {
                if(textBox3.Text == "")
                {
                    return;
                }
                textBox2.Text = null;
                MessageBox.Show("Wrong number!");
            }
            else
            {

                label1.Text = oilPrice.ToString("f2");
                oilCount = oilPrice / double.Parse(textBox_price_Oil.Text);
                FromTextBox3 = true;
                textBox2.Text = oilCount.ToString("f2");
            }
        }

        private void checkbox1_HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox1_HotDog.Checked == true)
            {
                textBox_Counter_Hotdog.ReadOnly = false;
            }
            else
            {
                textBox_Counter_Hotdog.Text = "";
                textBox_Counter_Hotdog.ReadOnly = true;
            }
        }

        private void checkBox2_Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_Hamburger.Checked == true)
            {
                textBox_Counter_Hamburger.ReadOnly = false;
            }
            else
            {
                textBox_Counter_Hamburger.Text = "";
                textBox_Counter_Hamburger.ReadOnly = true;
            }
        }

        private void checkBox3_Potato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_Potato.Checked == true)
            {
                textBox_Counter_Potato.ReadOnly = false;
            }
            else
            {
                textBox_Counter_Potato.Text = "";
                textBox_Counter_Potato.ReadOnly = true;
            }
        }

        private void checkBox4_CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4_Cola.Checked == true)
            {
                textBox_Counter_Cola.ReadOnly = false;
            }
            else
            {
                textBox_Counter_Cola.Text = "";
                textBox_Counter_Cola.ReadOnly = true;
            }
        }

        private void textBox_Counter_Hotdog_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Counter_Hotdog.Text == "")
            {
                return;
            }
            else
            {
                double temp;
                if(double.TryParse(textBox_Counter_Hotdog.Text,out temp) == false)
                {
                    MessageBox.Show("Wrong number");
                    textBox_Counter_Hotdog.Text = "";
                    return;
                }
                   totalHotDogs = (double.Parse(textBox_Counter_Hotdog.Text) * double.Parse(textBox_Price_HotDog.Text));
                   Cafe_Changed(sender, e);
            }
        }

        private void Cafe_Changed(object sender, EventArgs e)
        {
            label2.Text = (totalHotDogs + totalHamburgers + totalCola + totalPotato).ToString("f2");
        }

        private void textBox_Counter_Hamburger_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Counter_Hamburger.Text == "")
            {
                return;
            }
            else
            {
                double temp;
                if (double.TryParse(textBox_Counter_Hamburger.Text, out temp) == false)
                {
                    MessageBox.Show("Wrong number");
                    textBox_Counter_Hamburger.Text = "";
                    return;
                }
                totalHamburgers = (double.Parse(textBox_Counter_Hamburger.Text) * double.Parse(textBox_Price_Hamburger.Text));
                Cafe_Changed(sender, e);
            }

        }

        private void textBox_Counter_Potato_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Counter_Potato.Text == "")
            {
                return;
            }
            else
            {
                double temp;
                if (double.TryParse(textBox_Counter_Potato.Text, out temp) == false)
                {
                    MessageBox.Show("Wrong number");
                    textBox_Counter_Potato.Text = "";
                    return;
                }
                totalPotato = (double.Parse(textBox_Counter_Potato.Text) * double.Parse(textBox_Price_Potato.Text));
                Cafe_Changed(sender, e);
            }
        }

        private void textBox_Counter_Cola_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Counter_Cola.Text == "")
            {
                return;
            }
            else
            {
                double temp;
                if (double.TryParse(textBox_Counter_Cola.Text, out temp) == false)
                {
                    MessageBox.Show("Wrong number");
                    textBox_Counter_Cola.Text = "";
                    return;
                }
                totalCola = (double.Parse(textBox_Counter_Cola.Text) * double.Parse(textBox_Price_Cola.Text));
                Cafe_Changed(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = (double.Parse(label1.Text) + double.Parse(label2.Text)).ToString("f2");
            if(double.Parse(label5.Text) < 0)
            {
                Thread th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void open(object obj)
        {
            Application.Run(new Form2());
        }
        DateTime dt = DateTime.Now;

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            toolStripStatusLabel1.Text = dt.ToLongTimeString();
            switch (((int)dt.DayOfWeek))
            {
 
                case 1:
                    toolStripStatusLabel2.Text = "Понедельник";
                    break;
                case 2:
                    toolStripStatusLabel2.Text = "Вторник";
                    break;
                case 3:
                    toolStripStatusLabel2.Text = "Среда";
                    break;
                case 4:
                    toolStripStatusLabel2.Text = "Четверг";
                    break;
                case 5:
                    toolStripStatusLabel2.Text = "Пятница";
                    break;
                case 6:
                    toolStripStatusLabel2.Text = "Суббота";
                    break;
                case 7:
                    toolStripStatusLabel2.Text = "Воскресенье";
                    break;
            }
        }

        private void label4_Price_Click(object sender, EventArgs e)
        {

        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new
            System.Globalization.CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new
           System.Globalization.CultureInfo("ru-RU");
            System.ComponentModel.ComponentResourceManager manager = new
           ComponentResourceManager(this.GetType());
            manager.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                manager.ApplyResources(c, c.Name);
                foreach (Control item in c.Controls)
                {
                    manager.ApplyResources(item, item.Name);
                    if(item.Controls.Count>0)
                    {
                        foreach(Control item1 in item.Controls)
                        {
                            manager.ApplyResources(item1, item1.Name);
                        }
                    }
                }
            }

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new
                      System.Globalization.CultureInfo("");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new
           System.Globalization.CultureInfo("");
            System.ComponentModel.ComponentResourceManager manager = new
           ComponentResourceManager(this.GetType());
            manager.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                manager.ApplyResources(c, c.Name);
                foreach (Control item in c.Controls)
                {
                    manager.ApplyResources(item, item.Name);
                    if (item.Controls.Count > 0)
                    {
                        foreach (Control item1 in item.Controls)
                        {
                            manager.ApplyResources(item1, item1.Name);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    class Oil
    {
        public double price { get; set; }
        public string name { get; set; }
        public Oil(double Price, string Name)
        {
            price = Price;
            name = Name;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }

}
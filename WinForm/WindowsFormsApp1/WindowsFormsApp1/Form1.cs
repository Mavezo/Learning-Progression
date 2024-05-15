using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
               
                //var countries = dt.Country.Select(t => $"{t.CountryName}");
                //var countries = dt.Country.Select(t => $"{t.CapitalName}");
                //var countries = dt.Country.Where(t=> t.Area > 500000).Select(t => $"{t.CountryName}");
                var countries = dt.Country.
                    Where(t => t.CountryName.ToLower().IndexOf("н") >= 0 || t.CountryName.ToLower().Contains("к")).
                    Select(t => $"{t.CountryName}");
                //var countries = dt.Country.Where(t=> t.CountryName.ToLower().StartsWith("н")).Select(t=>t.CountryName); 
       



                foreach(var data in countries)
                {
                    listBox1.Items.Add(data);
                }




            }
        }
    }
}

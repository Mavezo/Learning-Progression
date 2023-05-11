using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTzad2
{
    public partial class AddItem : Form
    {
        public List<string> Types { get; set; }
        public Item item { get; set; }
        Form1 parentForm;
        public AddItem(List<string> types, Form1 parentForm)
        {
            Types = types;
            InitializeComponent();
            typeCombo.Items.AddRange(Types.ToArray());
            this.parentForm = parentForm;
        }
        public AddItem()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            item = new Item(productText.Text, typeCombo.SelectedIndex + 1, Convert.ToInt32(costText.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void createType_Click(object sender, EventArgs e)
        {
            AddType form = new AddType();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string sqlQuery = string.Empty;
                if(parentForm.currentProvider == "System.Data.SqlClient")                
                sqlQuery = $"Insert ItemsType values ('{form.type.TypeName}')";
                else if(parentForm.currentProvider == "Npgsql")
                sqlQuery = $"insert into \"ItemsType\"(\"Type\") values ('{form.type.TypeName}')";
                parentForm.InsertWithCommand(sqlQuery);
                Types.Add(form.type.TypeName);
                typeCombo.Items.Clear();
                typeCombo.Items.AddRange(Types.ToArray());
            }



        }

    }
}

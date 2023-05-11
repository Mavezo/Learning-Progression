using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTzad2
{
    public partial class AddType : Form
    {
        private Label label1;
        private Button button1;
        private TextBox typeText;

        public Type type { get; set; }
        public AddType()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = new Type(typeText.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.typeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(65, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sumbit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeText
            // 
            this.typeText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeText.Location = new System.Drawing.Point(33, 128);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(332, 41);
            this.typeText.TabIndex = 2;
            // 
            // AddType
            // 
            this.ClientSize = new System.Drawing.Size(406, 435);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

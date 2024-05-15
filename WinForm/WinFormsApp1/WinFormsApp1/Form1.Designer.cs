namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.RadioButton();
            this.amount = new System.Windows.Forms.RadioButton();
            this.textBox_price_Oil = new System.Windows.Forms.TextBox();
            this.price_oil = new System.Windows.Forms.Label();
            this.oil_label = new System.Windows.Forms.Label();
            this.comboBox_oil = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Counter_Cola = new System.Windows.Forms.TextBox();
            this.textBox_Price_Cola = new System.Windows.Forms.TextBox();
            this.textBox_Counter_Potato = new System.Windows.Forms.TextBox();
            this.textBox_Price_Potato = new System.Windows.Forms.TextBox();
            this.textBox_Counter_Hamburger = new System.Windows.Forms.TextBox();
            this.textBox_Price_Hamburger = new System.Windows.Forms.TextBox();
            this.textBox_Counter_Hotdog = new System.Windows.Forms.TextBox();
            this.textBox_Price_HotDog = new System.Windows.Forms.TextBox();
            this.label4_counter = new System.Windows.Forms.Label();
            this.label4_Price = new System.Windows.Forms.Label();
            this.checkBox4_Cola = new System.Windows.Forms.CheckBox();
            this.checkBox3_Potato = new System.Windows.Forms.CheckBox();
            this.checkBox2_Hamburger = new System.Windows.Forms.CheckBox();
            this.checkbox1_HotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox_price_Oil);
            this.groupBox1.Controls.Add(this.price_oil);
            this.groupBox1.Controls.Add(this.oil_label);
            this.groupBox1.Controls.Add(this.comboBox_oil);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.value);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // value
            // 
            resources.ApplyResources(this.value, "value");
            this.value.ForeColor = System.Drawing.Color.Black;
            this.value.Name = "value";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Name = "panel1";
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Name = "price";
            this.price.TabStop = true;
            this.price.UseVisualStyleBackColor = true;
            this.price.CheckedChanged += new System.EventHandler(this.price_CheckedChanged);
            // 
            // amount
            // 
            resources.ApplyResources(this.amount, "amount");
            this.amount.ForeColor = System.Drawing.Color.Black;
            this.amount.Name = "amount";
            this.amount.TabStop = true;
            this.amount.UseVisualStyleBackColor = true;
            this.amount.CheckedChanged += new System.EventHandler(this.amount_CheckedChanged);
            // 
            // textBox_price_Oil
            // 
            resources.ApplyResources(this.textBox_price_Oil, "textBox_price_Oil");
            this.textBox_price_Oil.Name = "textBox_price_Oil";
            this.textBox_price_Oil.ReadOnly = true;
            // 
            // price_oil
            // 
            resources.ApplyResources(this.price_oil, "price_oil");
            this.price_oil.ForeColor = System.Drawing.Color.Black;
            this.price_oil.Name = "price_oil";
            // 
            // oil_label
            // 
            resources.ApplyResources(this.oil_label, "oil_label");
            this.oil_label.ForeColor = System.Drawing.Color.Black;
            this.oil_label.Name = "oil_label";
            // 
            // comboBox_oil
            // 
            resources.ApplyResources(this.comboBox_oil, "comboBox_oil");
            this.comboBox_oil.FormattingEnabled = true;
            this.comboBox_oil.Name = "comboBox_oil";
            this.comboBox_oil.SelectedIndexChanged += new System.EventHandler(this.comboBox_oil_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.textBox_Counter_Cola);
            this.groupBox2.Controls.Add(this.textBox_Price_Cola);
            this.groupBox2.Controls.Add(this.textBox_Counter_Potato);
            this.groupBox2.Controls.Add(this.textBox_Price_Potato);
            this.groupBox2.Controls.Add(this.textBox_Counter_Hamburger);
            this.groupBox2.Controls.Add(this.textBox_Price_Hamburger);
            this.groupBox2.Controls.Add(this.textBox_Counter_Hotdog);
            this.groupBox2.Controls.Add(this.textBox_Price_HotDog);
            this.groupBox2.Controls.Add(this.label4_counter);
            this.groupBox2.Controls.Add(this.label4_Price);
            this.groupBox2.Controls.Add(this.checkBox4_Cola);
            this.groupBox2.Controls.Add(this.checkBox3_Potato);
            this.groupBox2.Controls.Add(this.checkBox2_Hamburger);
            this.groupBox2.Controls.Add(this.checkbox1_HotDog);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBox_Counter_Cola
            // 
            resources.ApplyResources(this.textBox_Counter_Cola, "textBox_Counter_Cola");
            this.textBox_Counter_Cola.Name = "textBox_Counter_Cola";
            this.textBox_Counter_Cola.ReadOnly = true;
            this.textBox_Counter_Cola.TextChanged += new System.EventHandler(this.textBox_Counter_Cola_TextChanged);
            // 
            // textBox_Price_Cola
            // 
            resources.ApplyResources(this.textBox_Price_Cola, "textBox_Price_Cola");
            this.textBox_Price_Cola.Name = "textBox_Price_Cola";
            this.textBox_Price_Cola.ReadOnly = true;
            // 
            // textBox_Counter_Potato
            // 
            resources.ApplyResources(this.textBox_Counter_Potato, "textBox_Counter_Potato");
            this.textBox_Counter_Potato.Name = "textBox_Counter_Potato";
            this.textBox_Counter_Potato.ReadOnly = true;
            this.textBox_Counter_Potato.TextChanged += new System.EventHandler(this.textBox_Counter_Potato_TextChanged);
            // 
            // textBox_Price_Potato
            // 
            resources.ApplyResources(this.textBox_Price_Potato, "textBox_Price_Potato");
            this.textBox_Price_Potato.Name = "textBox_Price_Potato";
            this.textBox_Price_Potato.ReadOnly = true;
            // 
            // textBox_Counter_Hamburger
            // 
            resources.ApplyResources(this.textBox_Counter_Hamburger, "textBox_Counter_Hamburger");
            this.textBox_Counter_Hamburger.Name = "textBox_Counter_Hamburger";
            this.textBox_Counter_Hamburger.ReadOnly = true;
            this.textBox_Counter_Hamburger.TextChanged += new System.EventHandler(this.textBox_Counter_Hamburger_TextChanged);
            // 
            // textBox_Price_Hamburger
            // 
            resources.ApplyResources(this.textBox_Price_Hamburger, "textBox_Price_Hamburger");
            this.textBox_Price_Hamburger.Name = "textBox_Price_Hamburger";
            this.textBox_Price_Hamburger.ReadOnly = true;
            // 
            // textBox_Counter_Hotdog
            // 
            resources.ApplyResources(this.textBox_Counter_Hotdog, "textBox_Counter_Hotdog");
            this.textBox_Counter_Hotdog.Name = "textBox_Counter_Hotdog";
            this.textBox_Counter_Hotdog.ReadOnly = true;
            this.textBox_Counter_Hotdog.TextChanged += new System.EventHandler(this.textBox_Counter_Hotdog_TextChanged);
            // 
            // textBox_Price_HotDog
            // 
            resources.ApplyResources(this.textBox_Price_HotDog, "textBox_Price_HotDog");
            this.textBox_Price_HotDog.Name = "textBox_Price_HotDog";
            this.textBox_Price_HotDog.ReadOnly = true;
            // 
            // label4_counter
            // 
            resources.ApplyResources(this.label4_counter, "label4_counter");
            this.label4_counter.ForeColor = System.Drawing.Color.Black;
            this.label4_counter.Name = "label4_counter";
            // 
            // label4_Price
            // 
            resources.ApplyResources(this.label4_Price, "label4_Price");
            this.label4_Price.ForeColor = System.Drawing.Color.Black;
            this.label4_Price.Name = "label4_Price";
            this.label4_Price.Click += new System.EventHandler(this.label4_Price_Click);
            // 
            // checkBox4_Cola
            // 
            resources.ApplyResources(this.checkBox4_Cola, "checkBox4_Cola");
            this.checkBox4_Cola.ForeColor = System.Drawing.Color.Black;
            this.checkBox4_Cola.Name = "checkBox4_Cola";
            this.checkBox4_Cola.UseVisualStyleBackColor = true;
            this.checkBox4_Cola.CheckedChanged += new System.EventHandler(this.checkBox4_CocaCola_CheckedChanged);
            // 
            // checkBox3_Potato
            // 
            resources.ApplyResources(this.checkBox3_Potato, "checkBox3_Potato");
            this.checkBox3_Potato.ForeColor = System.Drawing.Color.Black;
            this.checkBox3_Potato.Name = "checkBox3_Potato";
            this.checkBox3_Potato.UseVisualStyleBackColor = true;
            this.checkBox3_Potato.CheckedChanged += new System.EventHandler(this.checkBox3_Potato_CheckedChanged);
            // 
            // checkBox2_Hamburger
            // 
            resources.ApplyResources(this.checkBox2_Hamburger, "checkBox2_Hamburger");
            this.checkBox2_Hamburger.ForeColor = System.Drawing.Color.Black;
            this.checkBox2_Hamburger.Name = "checkBox2_Hamburger";
            this.checkBox2_Hamburger.UseVisualStyleBackColor = true;
            this.checkBox2_Hamburger.CheckedChanged += new System.EventHandler(this.checkBox2_Hamburger_CheckedChanged);
            // 
            // checkbox1_HotDog
            // 
            resources.ApplyResources(this.checkbox1_HotDog, "checkbox1_HotDog");
            this.checkbox1_HotDog.ForeColor = System.Drawing.Color.Black;
            this.checkbox1_HotDog.Name = "checkbox1_HotDog";
            this.checkbox1_HotDog.UseVisualStyleBackColor = true;
            this.checkbox1_HotDog.CheckedChanged += new System.EventHandler(this.checkbox1_HotDog_CheckedChanged);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.label2.TextChanged += new System.EventHandler(this.Cafe_Changed);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.cat_Kapitalist;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripDropDownButton1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.russianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // russianToolStripMenuItem
            // 
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_price_Oil;
        private Label price_oil;
        private Label oil_label;
        private ComboBox comboBox_oil;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel1;
        private RadioButton price;
        private RadioButton amount;
        private Label value;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox_Counter_Cola;
        private TextBox textBox_Price_Cola;
        private TextBox textBox_Counter_Potato;
        private TextBox textBox_Price_Potato;
        private TextBox textBox_Counter_Hamburger;
        private TextBox textBox_Price_Hamburger;
        private TextBox textBox_Counter_Hotdog;
        private TextBox textBox_Price_HotDog;
        private Label label4_counter;
        private Label label4_Price;
        private CheckBox checkBox4_Cola;
        private CheckBox checkBox3_Potato;
        private CheckBox checkBox2_Hamburger;
        private CheckBox checkbox1_HotDog;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem russianToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private Label label4;
    }
}
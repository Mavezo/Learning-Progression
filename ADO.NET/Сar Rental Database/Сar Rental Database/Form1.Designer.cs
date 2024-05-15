namespace Сar_Rental_Database
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
            this.cars_ListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costOfRentingPerDay_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.brand_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.promotion_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.model_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.maxDistance_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cars_ListBox
            // 
            this.cars_ListBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cars_ListBox.FormattingEnabled = true;
            this.cars_ListBox.ItemHeight = 30;
            this.cars_ListBox.Location = new System.Drawing.Point(18, 41);
            this.cars_ListBox.Name = "cars_ListBox";
            this.cars_ListBox.Size = new System.Drawing.Size(167, 634);
            this.cars_ListBox.TabIndex = 0;
            this.cars_ListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costOfRentingPerDay_RichTextBox);
            this.groupBox1.Controls.Add(this.brand_RichTextBox);
            this.groupBox1.Controls.Add(this.promotion_RichTextBox);
            this.groupBox1.Controls.Add(this.model_RichTextBox);
            this.groupBox1.Controls.Add(this.maxDistance_RichTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(233, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 693);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information System";
            // 
            // costOfRentingPerDay_RichTextBox
            // 
            this.costOfRentingPerDay_RichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costOfRentingPerDay_RichTextBox.Location = new System.Drawing.Point(23, 611);
            this.costOfRentingPerDay_RichTextBox.Name = "costOfRentingPerDay_RichTextBox";
            this.costOfRentingPerDay_RichTextBox.ReadOnly = true;
            this.costOfRentingPerDay_RichTextBox.Size = new System.Drawing.Size(275, 34);
            this.costOfRentingPerDay_RichTextBox.TabIndex = 15;
            this.costOfRentingPerDay_RichTextBox.Text = "";
            // 
            // brand_RichTextBox
            // 
            this.brand_RichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brand_RichTextBox.Location = new System.Drawing.Point(23, 72);
            this.brand_RichTextBox.Name = "brand_RichTextBox";
            this.brand_RichTextBox.ReadOnly = true;
            this.brand_RichTextBox.Size = new System.Drawing.Size(275, 34);
            this.brand_RichTextBox.TabIndex = 14;
            this.brand_RichTextBox.Text = "";
            // 
            // promotion_RichTextBox
            // 
            this.promotion_RichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promotion_RichTextBox.Location = new System.Drawing.Point(23, 329);
            this.promotion_RichTextBox.Name = "promotion_RichTextBox";
            this.promotion_RichTextBox.ReadOnly = true;
            this.promotion_RichTextBox.Size = new System.Drawing.Size(275, 34);
            this.promotion_RichTextBox.TabIndex = 13;
            this.promotion_RichTextBox.Text = "";
            // 
            // model_RichTextBox
            // 
            this.model_RichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.model_RichTextBox.Location = new System.Drawing.Point(23, 199);
            this.model_RichTextBox.Name = "model_RichTextBox";
            this.model_RichTextBox.ReadOnly = true;
            this.model_RichTextBox.Size = new System.Drawing.Size(275, 34);
            this.model_RichTextBox.TabIndex = 12;
            this.model_RichTextBox.Text = "";
            // 
            // maxDistance_RichTextBox
            // 
            this.maxDistance_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDistance_RichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxDistance_RichTextBox.Location = new System.Drawing.Point(23, 471);
            this.maxDistance_RichTextBox.Name = "maxDistance_RichTextBox";
            this.maxDistance_RichTextBox.ReadOnly = true;
            this.maxDistance_RichTextBox.Size = new System.Drawing.Size(275, 34);
            this.maxDistance_RichTextBox.TabIndex = 11;
            this.maxDistance_RichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Promotion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost Of Renting Per Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cars_ListBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 698);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 709);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox cars_ListBox;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox maxDistance_RichTextBox;
        private RichTextBox model_RichTextBox;
        private RichTextBox costOfRentingPerDay_RichTextBox;
        private RichTextBox brand_RichTextBox;
        private RichTextBox promotion_RichTextBox;
    }
}
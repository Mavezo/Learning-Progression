namespace NP_6__lab_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Global_CheckBox = new System.Windows.Forms.CheckBox();
            this.Trade_CheckBox = new System.Windows.Forms.CheckBox();
            this.Local_CheckBox = new System.Windows.Forms.CheckBox();
            this.message_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.local_TabPage = new System.Windows.Forms.TabPage();
            this.local_TextBox = new System.Windows.Forms.TextBox();
            this.trade_TabPage = new System.Windows.Forms.TabPage();
            this.trade_TextBox = new System.Windows.Forms.TextBox();
            this.global_TabPage = new System.Windows.Forms.TabPage();
            this.global_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.local_TabPage.SuspendLayout();
            this.trade_TabPage.SuspendLayout();
            this.global_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Global_CheckBox);
            this.groupBox1.Controls.Add(this.Trade_CheckBox);
            this.groupBox1.Controls.Add(this.Local_CheckBox);
            this.groupBox1.Controls.Add(this.message_TextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message params";
            // 
            // Global_CheckBox
            // 
            this.Global_CheckBox.AutoSize = true;
            this.Global_CheckBox.Location = new System.Drawing.Point(270, 139);
            this.Global_CheckBox.Name = "Global_CheckBox";
            this.Global_CheckBox.Size = new System.Drawing.Size(75, 24);
            this.Global_CheckBox.TabIndex = 5;
            this.Global_CheckBox.Text = "Global";
            this.Global_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Trade_CheckBox
            // 
            this.Trade_CheckBox.AutoSize = true;
            this.Trade_CheckBox.Location = new System.Drawing.Point(141, 139);
            this.Trade_CheckBox.Name = "Trade_CheckBox";
            this.Trade_CheckBox.Size = new System.Drawing.Size(68, 24);
            this.Trade_CheckBox.TabIndex = 4;
            this.Trade_CheckBox.Text = "Trade";
            this.Trade_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Local_CheckBox
            // 
            this.Local_CheckBox.AutoSize = true;
            this.Local_CheckBox.Location = new System.Drawing.Point(21, 139);
            this.Local_CheckBox.Name = "Local_CheckBox";
            this.Local_CheckBox.Size = new System.Drawing.Size(66, 24);
            this.Local_CheckBox.TabIndex = 0;
            this.Local_CheckBox.Text = "Local";
            this.Local_CheckBox.UseVisualStyleBackColor = true;
            // 
            // message_TextBox
            // 
            this.message_TextBox.Location = new System.Drawing.Point(18, 27);
            this.message_TextBox.Multiline = true;
            this.message_TextBox.Name = "message_TextBox";
            this.message_TextBox.Size = new System.Drawing.Size(511, 86);
            this.message_TextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 513);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.local_TabPage);
            this.tabControl1.Controls.Add(this.trade_TabPage);
            this.tabControl1.Controls.Add(this.global_TabPage);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(170, 30);
            this.tabControl1.Location = new System.Drawing.Point(14, 37);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 470);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // local_TabPage
            // 
            this.local_TabPage.Controls.Add(this.local_TextBox);
            this.local_TabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.local_TabPage.Location = new System.Drawing.Point(4, 34);
            this.local_TabPage.Name = "local_TabPage";
            this.local_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.local_TabPage.Size = new System.Drawing.Size(507, 432);
            this.local_TabPage.TabIndex = 0;
            this.local_TabPage.Text = "Local";
            this.local_TabPage.UseVisualStyleBackColor = true;
            // 
            // local_TextBox
            // 
            this.local_TextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.local_TextBox.Location = new System.Drawing.Point(-5, -1);
            this.local_TextBox.Multiline = true;
            this.local_TextBox.Name = "local_TextBox";
            this.local_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.local_TextBox.Size = new System.Drawing.Size(515, 436);
            this.local_TextBox.TabIndex = 0;
            // 
            // trade_TabPage
            // 
            this.trade_TabPage.Controls.Add(this.trade_TextBox);
            this.trade_TabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trade_TabPage.Location = new System.Drawing.Point(4, 34);
            this.trade_TabPage.Name = "trade_TabPage";
            this.trade_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trade_TabPage.Size = new System.Drawing.Size(507, 432);
            this.trade_TabPage.TabIndex = 1;
            this.trade_TabPage.Text = "Trade";
            this.trade_TabPage.UseVisualStyleBackColor = true;
            // 
            // trade_TextBox
            // 
            this.trade_TextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trade_TextBox.Location = new System.Drawing.Point(-5, -3);
            this.trade_TextBox.Multiline = true;
            this.trade_TextBox.Name = "trade_TextBox";
            this.trade_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trade_TextBox.Size = new System.Drawing.Size(515, 436);
            this.trade_TextBox.TabIndex = 1;
            // 
            // global_TabPage
            // 
            this.global_TabPage.Controls.Add(this.global_TextBox);
            this.global_TabPage.Location = new System.Drawing.Point(4, 34);
            this.global_TabPage.Name = "global_TabPage";
            this.global_TabPage.Size = new System.Drawing.Size(507, 432);
            this.global_TabPage.TabIndex = 2;
            this.global_TabPage.Text = "Global";
            this.global_TabPage.UseVisualStyleBackColor = true;
            // 
            // global_TextBox
            // 
            this.global_TextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.global_TextBox.Location = new System.Drawing.Point(-4, -2);
            this.global_TextBox.Multiline = true;
            this.global_TextBox.Name = "global_TextBox";
            this.global_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.global_TextBox.Size = new System.Drawing.Size(515, 436);
            this.global_TextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 728);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.local_TabPage.ResumeLayout(false);
            this.local_TabPage.PerformLayout();
            this.trade_TabPage.ResumeLayout(false);
            this.trade_TabPage.PerformLayout();
            this.global_TabPage.ResumeLayout(false);
            this.global_TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage local_TabPage;
        internal TabPage trade_TabPage;
        private TabPage global_TabPage;
        private CheckBox Global_CheckBox;
        private CheckBox Trade_CheckBox;
        private CheckBox Local_CheckBox;
        private TextBox message_TextBox;
        private Button button1;
        private TextBox local_TextBox;
        private TextBox trade_TextBox;
        private TextBox global_TextBox;
    }
}
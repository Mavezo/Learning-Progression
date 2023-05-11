using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Text;
using static System.Windows.Forms.ListBox;

namespace SP1_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<dynamic> currentProcesses;
        private void button1_Click(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses()
              .Select(t => new { Name = t.ProcessName, Priority = t.BasePriority, Id = t.Id, Result = $"{t.Id}. {t.ProcessName}, {t.BasePriority}" })
              .OrderBy(x => x.Id).ToList();

            if (currentProcesses != null)
            {

                var temp = new BindingList<dynamic>(currentProcesses.ToList());
                foreach (var item in temp) // нельзя удалять при использовании форыча
                {
                    if (!processes.Contains(item))
                    {
                        currentProcesses.Remove(item);
                    }
                }

                foreach (var process in processes)
                {
                    if (!currentProcesses.Contains(process))
                    {
                        currentProcesses.Add(process);
                    }
                }




            }
            else //currentProcesses = null;
            {
                currentProcesses = new BindingList<dynamic>();
                foreach (var process in processes)
                {
                    currentProcesses.Add(process);
                }
                listBox1.DataSource = null;
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "Result";
                listBox1.DataSource = currentProcesses;
            }


        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (!int.TryParse(textBox2.Text, out int value))
            //{
            //    textBox2.Text = string.Empty;
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                timer1.Interval = value * 1000;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Process process = Process.GetProcessById(int.Parse(listBox1.SelectedValue.ToString()));
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Id: {process.Id}");
                sb.AppendLine($"Name: {process.ProcessName}");
                sb.AppendLine($"Priority: {process.BasePriority}");
                sb.AppendLine($"MemoryTest: {process.VirtualMemorySize64}");
                textBox1.Text = string.Empty;
                textBox1.Text = sb.ToString();

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var process = currentProcesses.Where(t => t.Name == textBox3.Text).FirstOrDefault();
            if (process != null)
            {
                listBox1.SelectedItem = process;
            }



            //    if (process != null) {
            //        var temp = listBox1.DataSource as IList<dynamic>;
            //        foreach (var item in temp)
            //        {
            //            if((item as dynamic).Id == process.Id)
            //            {
            //                listBox1.SelectedItem = currentProcesses.Where(t=>t.Id == process.Id).FirstOrDefault();
            //            }
            //        }


            //    } 
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {




            if (listBox1.SelectedIndex != -1)
            {
                int processId = int.Parse(listBox1.SelectedValue.ToString());


                if (listBox1.SelectedIndex != -1)
                {
                    Process process = Process.GetProcessById(int.Parse(listBox1.SelectedValue.ToString()));

                    try
                    {
                        if (!process.CloseMainWindow())
                        {
                            process.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }
    }
}
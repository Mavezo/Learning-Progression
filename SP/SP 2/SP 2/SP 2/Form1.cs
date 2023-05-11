using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Management;

namespace SP_2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, nuint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const uint WM_SETTEXT = 0x000C;

        BindingList<Process> startedProcess = new BindingList<Process>();
        //BindingList<string> awailableProcess = new BindingList<string>();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.DataSource = null;
            listBox2.DisplayMember = nameof(Process.ProcessName);
            listBox2.ValueMember = nameof(Process.Id);
            listBox2.DataSource = startedProcess;
            //listBox1.DataSource = null;
            //listBox1.DataSource = awailableProcess;
            LoadAvailableAssemblies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                string? assemblyName = listBox1.SelectedItem.ToString();
                Process process = Process.Start(assemblyName);
                process.EnableRaisingEvents= true;
                process.Exited += Process_Exited;
                startedProcess.Add(process);
                if(Process.GetCurrentProcess().Id == GetParentProcessId(process.Id))
                {
                    MessageBox.Show($"Process with id = {process.Id} is a child process");
                }
                //awailableProcess.Remove(listBox1.SelectedItem as string);
                listBox1.Items.Remove(listBox1.SelectedItem as string);
                SendMessageToChildProcess(process.Handle, "Привет!");
                UpdateStartProcessList();

            }
        }

        private void UpdateStartProcessList()
        {
            listBox2.DataSource = null;
            listBox2.DisplayMember = nameof(Process.ProcessName);
            listBox2.ValueMember = nameof(Process.Id);
            listBox2.DataSource = startedProcess;
            //listBox1.DataSource = null;
            //listBox1.DataSource = awailableProcess;
        }

        private void SendMessageToChildProcess(IntPtr handle, string message)
        {
            SendMessage(handle, WM_SETTEXT, 0, message);
        }

        private void Process_Exited(object? sender, EventArgs e)
        {
            startedProcess.Remove(sender as Process);
            //RemoveFromListBox(sender as Process);
            AddToListBox((sender as Process).ProcessName);
            //awailableProcess.Add((sender as Process).ProcessName);          
            UpdateStartProcessList();
        }

        private void RemoveFromListBox(Process process)
        {
            if (listBox2.InvokeRequired)
            {
                listBox2.Invoke(new Action<Process>(RemoveFromListBox), process);
            }
            else
            {
                //listBox2.Items.Remove(process);
                startedProcess.Remove(process);
            }
        }

        private int GetParentProcessId(int childProcessId)
        {
            int parentId = 0;
            using (ManagementObject obj = new ManagementObject($"win32_process.handle={childProcessId}")) {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
            }
            return parentId;
        }
        private void AddToListBox(string data)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action<string>(AddToListBox), data);
            }
            else
            {
                //(list.DataSource as IList<object>).Add(data);
                listBox1.Items.Add(data);
                UpdateStartProcessList();
            }

        }

        private void LoadAvailableAssemblies()
        {
            //awailableProcess.Clear(); 
            listBox1.Items.Clear();
            string assemblyName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            
            foreach (string file in Directory.GetFiles(Application.StartupPath, "*.exe"))
            {
                if (Path.GetFileNameWithoutExtension(file) != assemblyName)
                {
                    AddToListBox(Path.GetFileNameWithoutExtension(file));
                }
            }


        }
        
    }
}
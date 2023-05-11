using System.Management;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Diagnostics.Eventing.Reader;
using System;
using System.Drawing.Text;

namespace SP_2_Lab_Dz__ProcessTreeEvaluator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var processes = Process.GetProcesses();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //key = processID, value = parentProcessID
            foreach (var process in processes)
            {
                int parentId = GetParentId(process.Id);
                dictionary.Add(process.Id, parentId);
            }
            //Creating roots:
            TreeNode temp;
            foreach (var item in dictionary)
            {
                try
                { 
                    if (item.Value == item.Key || item.Value == 0 || !dictionary.ContainsKey(item.Value))
                    {
                        Process process = Process.GetProcessById(item.Key);
                        TreeNode root = new TreeNode($"{process.ProcessName} PID={process.Id}, ParentPID={item.Value}");
                        root.Tag = process;
                        treeView1.Nodes.Add(root);
                    }

                    /*
                     *                     //WRONG
                    //if (!dictionary.ContainsKey(item.Value))
                    //{

                    //    //Process process = Process.GetProcessById(item.Key);
                    //    //TreeNode root = new TreeNode($"{process.ProcessName} PID={process.Id}, ParentPID={item.Value}");
                    //    //root.Tag = process;
                    //    //treeView1.Nodes.Add(root);
                    //    //dictionary.Remove(item.Key);


                    //    // Process test = Process.GetProcessById(item.Value);
                    //    //temp = new TreeNode($"{test.ProcessName} PID={test.Id}, ParentPID={GetParentId(item.Key)}");
                    //    temp = new TreeNode($"{item.Value}");
                    //    foreach (var subItem in dictionary.Where(t => t.Value == item.Value).ToList())
                    //    {
                    //        Process subProcess = Process.GetProcessById(subItem.Key);
                    //        TreeNode subTreeNode = new TreeNode($"{subProcess.ProcessName} PID={subProcess.Id}, ParentPID={subItem.Value}");
                    //        subTreeNode.Tag = subProcess;
                    //        temp.Nodes.Add(subTreeNode);
                    //        //       dictionary.Remove(subItem.Key);
                    //    }
                    //    treeView1.Nodes.Add(temp);
                    //}
                    */
                }
                catch { }
            }
            MessageBox.Show(dictionary.Count.ToString());

            //Creating Nodes:
            foreach (TreeNode node in treeView1.Nodes)
            {
                AddChildProcess(dictionary, node);
            }





            /*
            //WRONG
            //while(dictionary.Count > 0)
            //{
            //    foreach (var item in dictionary) {
            //        foreach (TreeNode root in treeView1.Nodes)
            //        {
            //            Process rootProcess = root.Tag as Process;
            //            if (rootProcess.Id == item.Value)
            //            {
            //                Process process = Process.GetProcessById(item.Key);
            //                TreeNode treeNode = new TreeNode($"{process.ProcessName} PID={process.Id}, ParentPID={item.Value}");
            //                treeNode.Tag = process;
            //                root.Nodes.Add(treeNode);
            //                dictionary.Remove(item.Key);
            //            }
            //        }
            //    }
            //
            */
            /*
            //WRONG
            //while (dictionary.Count > 0)
            //{
            //    foreach (var item in dictionary)
            //    {
            //        try
            //        {
            //            Process parentProcess = Process.GetProcessById(item.Value);
            //            var nodes = treeView1.Nodes.Find($"{parentProcess.ProcessName} [{parentProcess.Id}]", true);
            //            //решить ебаный поиск
            //            TreeNode node = nodes.Where(t => (t.Tag as Process).Id == item.Value).FirstOrDefault();
            //            if (node != null)
            //            {
            //                Process process = Process.GetProcessById(item.Key);
            //                TreeNode newNode = new TreeNode($"{process.ProcessName} PID={process.Id}, ParentPID={item.Value}");
            //                newNode.Tag = item.Key;
            //                node.Nodes.Add(newNode);
            //            }
            //            dictionary.Remove(item.Key);
            //        }
            //        catch
            //        {
            //        }
            //    }
            //}
            */
        }

        private void AddChildProcess(Dictionary<int, int> actualDictionary, TreeNode actualTreeNode)
        {
            Process parentProcess = actualTreeNode.Tag as Process;
            foreach (var item in actualDictionary)
            {
                if(item.Value == parentProcess.Id)
                {
                    Process process = Process.GetProcessById(item.Key);
                    TreeNode newNode = new TreeNode($"{process.ProcessName} PID={process.Id}, ParentPID={item.Value}");
                    newNode.Tag = process;
                    actualTreeNode.Nodes.Add(newNode);
                    actualDictionary.Remove(item.Key);
                }
            }
            foreach(TreeNode nodes in actualTreeNode.Nodes)
            {
                AddChildProcess(actualDictionary, nodes);
            }
        }
        

        private int GetParentId(int processId)
        {
            int parentId = 0;
            using(ManagementObject obj = new ManagementObject($"win32_process.handle={processId}"))
            {
                try
                {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
                }
                catch 
                {
                }
            }
            return parentId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
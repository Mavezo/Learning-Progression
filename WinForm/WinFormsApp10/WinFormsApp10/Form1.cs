using System.ComponentModel;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                /*tv.Nodes.Add(drive.Name)*/
                ;
                TreeNode driveItem = treeView1.Nodes.Add(drive.Name);
                scanDirectories(driveItem, 0);
            }
        }
        private void scanDirectories(TreeNode node, int level)
        {
            try
            {
                if (level < 10)
                {
                    DirectoryInfo directory = new DirectoryInfo(node.FullPath);
                    foreach (DirectoryInfo di in directory.GetDirectories())
                    {
                        TreeNode child = node.Nodes.Add(di.Name);
                        scanDirectories(child, ++level);
                    }
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
        TreeNode root;

        private TreeNode LoadTree(string[]? directories, TreeNode node)
        {
            if(directories.Length != 0)
            {
                foreach(var item in directories)
                {
                    var direct = Directory.GetDirectories(item);
                    TreeNode temp = node;
                    if(node != (temp = LoadTree(direct, temp.Nodes.Add(Path.GetFileName(item))))){
                        node.Nodes.Add(temp);
                    }
                }
            }
            return node;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            var directories = Directory.GetDirectories(dialog.SelectedPath);
            TreeNode root = new TreeNode(Path.GetFileName(dialog.SelectedPath));
            TreeNode node = new TreeNode();
            root.Nodes.Add(LoadTree(directories, node));
            treeView1.Nodes.Add(root);
        }
    }
}
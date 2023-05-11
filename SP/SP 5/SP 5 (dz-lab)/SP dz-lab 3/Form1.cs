namespace SP_dz_lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
              Mutex mutexx = Mutex.OpenExisting("first");
               if (mutexx != null)
                {
                    MessageBox.Show($"Not first application run");
                    Close();
                }
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                MessageBox.Show($"First application run");
                Mutex mutex = new Mutex(true, "first");
            }

        }
    }
}
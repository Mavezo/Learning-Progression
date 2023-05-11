namespace SP_dz_lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                for (; ; )
                {
                    Thread.Sleep(100);
                    string text = textBox1.Text;
                    int countVowel = 0;
                    int countConsonants = 0;
                    int countSymbols = 0;
                    foreach (var item in text.ToCharArray())
                    {
                        if (item == 'ó' || item == 'å' || item == 'û'
                            || item == 'à' || item == 'î' || item == 'ý'
                            || item == 'è' || item == 'e' || item == 'y'
                            || item == 'u' || item == 'i' || item == 'o' || item == 'a')
                        {
                            countVowel++;
                        }
                        else if (item == '!' || item == '@' || item == '#' || item == '$' || item == '%' || item == '^'
                            || item == '&' || item == '*' || item == '(' || item == ')' || item == '-' || item == '+'
                            || item == '_' || item == '=' || item == '/' || item == ',' || item == '.' || item == '?'
                            || item == '\"' || item == '\'' || item == '<' || item == '>' || item == ':' || item == ';'
                            || item == '[' || item == ']' || item == '{' || item == '}' || item == '|' || item == '\\' || item == ' ' 
                            || item == '\r' || item == '\n')
                        {
                            countSymbols++;
                        }
                        else
                        {
                            countConsonants++;
                        }
                    }
                    if (InvokeRequired)
                    {
                        try
                        {
                            Invoke(() =>
                            {
                                label1.Text = $"Vowels: {countVowel}";
                                label2.Text = $"Consonants: {countConsonants}";
                                label3.Text = $"Symbols: {countSymbols}";
                            });
                        }
                        catch { }
                    }
                    else
                    {
                        label1.Text = $"Vowels: {countVowel}";
                        label2.Text = $"Consonants: {countConsonants}";
                        label3.Text = $"Symbols: {countSymbols}";
                    }
                }
            });
            await task;
        }
    }
}
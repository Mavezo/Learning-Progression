using System.Text;

namespace SP_8__dz_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Task task = new Task((object? obj) =>
            {
                string text = obj.ToString();
                string[] words = text.Split(' ', '\r');
                int sentencesCount = 0;
                int exclamationsCount = 0;
                int questionsCount = 0;

                foreach (string word in words) 
                {
                    switch (word[word.Length - 1])
                    {
                        case '.':
                            sentencesCount++;
                            break;
                        case '!':
                            sentencesCount++;
                            exclamationsCount++;
                            break;
                        case '?':
                            sentencesCount++;
                            questionsCount++;
                            break;
                    }
                }
                int symbolsCount = text.Length;
                int wordsCount = words.Length;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Count of sentences: {sentencesCount}");
                sb.AppendLine($"Count of symbols: {symbolsCount}");
                sb.AppendLine($"Count of words: {wordsCount}");
                sb.AppendLine($"Count of questions: {questionsCount}");
                sb.AppendLine($"Count of exclamations: {exclamationsCount}");
                if (InvokeRequired)
                {
                    Invoke(() =>
                    {
                        textBox2.Text = sb.ToString();
                    });
                }
                else
                {
                    textBox2.Text = sb.ToString();
                }

            }, text);
            task.Start();
            //task.Wait();

        }
    
    }
}
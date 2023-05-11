using System.Collections.Specialized;
using System.IO.Pipes;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

ParameterizedThreadStart firstThreadStart = new ParameterizedThreadStart((object obj) =>
{
lock (obj)
{
    string fileDirection = obj.ToString();
        string text = string.Empty;
        using (TextReader reader = new StreamReader(fileDirection))
        {
            text = reader.ReadToEnd();
            int count = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == '!' && text[i + 1] == '?')
                {
                    i++;
                    count++;
                    continue;

                }

                if (text[i] == '?' && text[i + 1] == '!')
                {
                    i++;
                    count++;
                    continue;

                }

                if (text[i] == '.' && text[i + 1] == '.')
                {
                    i += 2;
                    count++;
                    continue;
                }

                if (text[i] == '.')
                {
                    count++;
                    continue;
                }

                if (text[i] == '!')
                {
                    count++;
                    continue;
                }

                if (text[i] == '?')
                {
                    count++;
                    continue;
                }

            }
            Console.WriteLine($"Total count of sentences: {count}");
        }
    }
});

ParameterizedThreadStart secondThreadStart = new ParameterizedThreadStart((object obj) =>
{
lock (obj)
{
    string fileDirectory = obj.ToString();
        string text = string.Empty;
        using (TextReader reader = new StreamReader(fileDirectory))
        {
            text = reader.ReadToEnd();
            text = text.Replace('!', '#');
        }
        using (TextWriter writer = new StreamWriter(fileDirectory, false)) 
        {
            writer.Write(text);
        }


    }


});

string fileDirectory = "file.txt";
Thread firstThread = new Thread(firstThreadStart);
firstThread.Start(fileDirectory);
firstThread.Join();
Thread secondThread = new Thread(secondThreadStart);
secondThread.Start(fileDirectory);
secondThread.Join();
firstThread = new Thread(firstThreadStart);
firstThread.Start(fileDirectory);
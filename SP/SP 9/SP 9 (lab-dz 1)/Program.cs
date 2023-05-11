//Приложение считывает набор целых значений из
//файла в список. Необходимо посчитать количество
//уникальных значений. Для решения задачи используйте
//возможности PLINQ.

List<int> list = new List<int> { 0, 0, 0, 1, 1, 1, 1};
using (TextWriter writer = new StreamWriter("text.txt"))
{
    string text = string.Empty;
    foreach (int i in list)
    {
        text += i + ", ";
    }
    text = text.Trim(' ', ',');
    writer.Write(text);
}

using (TextReader reader = new StreamReader("text.txt"))
{
    string text = reader.ReadToEnd();
    string[] elements = text.Split(", ");
    Console.WriteLine(elements.AsParallel().Distinct().Count());
}







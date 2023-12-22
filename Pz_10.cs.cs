namespace pz10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите несколько строк(для завершения введите пустую строку):");

            List<string> inputStrings = new List<string>();
            String input;
            do
            {
                input = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(input))
                {
                    inputStrings.Add(input);
                }
            } 
            while (!string.IsNullOrWhiteSpace(input)) ;

            String concatenatedString = String.Join(" ", inputStrings); // конкатенация строк
            String[] words = concatenatedString.Split(' '); // разделение строки на слова

            List<string> uniqueWords = new List<string>();
            // Проверка на уникальность слов и их удаление, если они повторяются
            foreach(string word in words)
            {
                if(!uniqueWords.Contains(word))
                {
                    uniqueWords.Add(word);
                }
            }
            String resultString = String.Join(" ", uniqueWords); // объединение уникальных слов в строку
            Console.WriteLine("Результат после конкатенации и удаления повторяющихся слов:");
            Console.WriteLine(resultString);

        }
    }
}
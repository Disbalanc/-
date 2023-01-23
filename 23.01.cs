using static System.Net.Mime.MediaTypeNames;
internal class TV
{
    public int currentChannel = 1;
    public int channelLimit = 10;
    public TV()
    {
        int answer;
        Console.WriteLine($"Лимит каналов: {channelLimit}");
        do
        {
            Console.WriteLine($"Текущий канал: {currentChannel}");
            Console.WriteLine($"\n\t1 - следующий канал!\n\t2 - предыдущий канал!\n\t3 - выбора канала по числу!\n\t4 - выход из программы");
            Console.Write("Ваш выбор: ");
            
            if (!int.TryParse(Console.ReadLine().ToLower().Trim(), out answer))
            {
                Console.WriteLine("\nОшибка! не-то что-то ввели");
            }
            if (answer == 1)
                NextChannel();
            else if (answer == 2)
            {
                PreviousChannel();
            }
            else if (answer == 3)
            {
                Console.Write("Введите число: ");
                int numberOfChannel = Convert.ToInt32(Console.ReadLine());
                MoveToChannel(numberOfChannel);
            }
            else if (answer > 4 || answer < 0)
            {
                Console.WriteLine("\nЧисло не является ни одним из пунктов программы!\n");
            }
        }
        while (answer != 4);
    }
    public void NextChannel()
    {
        currentChannel++;
        if (currentChannel > channelLimit)
            currentChannel = 1;
    }
    public void PreviousChannel()
    {
        currentChannel--;
        if (currentChannel < 1)
            currentChannel = channelLimit;
    }

    public void MoveToChannel(int number)
    {
        currentChannel = number;
        if (number > channelLimit)
        {
            currentChannel = 1;
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        TV tv = new TV();
    }
}

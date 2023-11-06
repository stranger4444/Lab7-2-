using ConsoleApp10;
class Program
{
    static void Main()
    {
        Repository<int> intRepository = new Repository<int>();

        intRepository.Add(1);
        intRepository.Add(2);
        intRepository.Add(3);
        intRepository.Add(4);
        intRepository.Add(5);


        Repository<int>.Criteria<int> isEven = x => x % 2 == 0;

        List<int> evenNumbers = intRepository.Find(isEven);

        Console.WriteLine("Парні числа:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
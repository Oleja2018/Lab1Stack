
internal class Program
{
    public static void Qestion()
    {
        Console.WriteLine("Задание 2: составить программу для обработки очередей и стеков. ");
        Console.WriteLine("Составить программу, формирующую очередь L из всех положительных n элементов из стеков S1 и S2.");

    }
    private static void Main(string[] args)
    {
        Qestion();
        // Создаем стек для полоэительных чисел
        Queue<int> Elements = new Queue<int>();


        Stack<int> Mystack = new Stack<int>();

        Console.WriteLine("Введите числа через пробел");

        string input = Console.ReadLine(); // 100 200 300 400 500
        
        string[] numbers = input.Split(' ');
        for (int i = 0; i < numbers.Length; i++)
        {
            Mystack.Push(int.Parse(numbers[i]));
            if (int.Parse(numbers[i]) > 0)  //Если число положительное закидываем в очередь
            {
                Elements.Enqueue(int.Parse(numbers[i])); 
            }
        }
        while (Mystack.Count != 0)
        {
            Console.Write(Mystack.Pop() + " ");
        }

        // Создаем второй стак
        Stack<int> MyStackSecond = new Stack<int>();
        Console.WriteLine(" ");
        Console.WriteLine("Введите числа через пробел");
        string InputSecond = Console.ReadLine();
        string[] NumbersSecond = InputSecond.Split(' ');
        for (int i = 0; i < NumbersSecond.Length; i++)
        {
            Mystack.Push(int.Parse(NumbersSecond[i]));
            if (int.Parse(NumbersSecond[i]) > 0) // Если число положительное закидываем в очередь
            {
                Elements.Enqueue(int.Parse(numbers[i]));
            }

        }
        while (MyStackSecond.Count != 0)
        {
            Console.Write(MyStackSecond.Pop() + " ");
        }

        if (Elements.Count == 0) // Легкая првоерка вдруг очередь пустая
        {
            Console.WriteLine("Очередь пустая");
        }
        else {
            while (Elements.Count > 0)
            {
                var number = Elements.Dequeue();
                Console.Write($"очередь: {number}, ");
            }
        }
        // Выводим очередь 
        





    }


}
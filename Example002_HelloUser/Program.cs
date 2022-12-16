using System;
class WriteAFewLines
{
    static void Main()
    {
        Console.WriteLine("Введите Ваше любимое слово: ");
        string favouriteWord = Console.ReadLine();
        
        Console.WriteLine("Сколько раз его напечатать? ");
        int numberOfTimes = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfTimes; i++)
        {
            Console.WriteLine(favouriteWord);
        }


    }
}

using System;

public class Program
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length != 10)
        {
            throw new ArgumentException("Массив должен содержать ровно 10 цифр.");
        }

        return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        string phoneNumber = CreatePhoneNumber(numbers);
        Console.WriteLine(phoneNumber);
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int[] number = new int[] { 10, 12, 15, 45, 65, 35, 18, 25, 16, 19, 25, 50, 55, 46 };

for (var i = 0; i < number.Length; i++)
{
    for (int j = 0; j < number.Length; j++)
    {

        if (number[i] + number[j] == 100 && number[i] != number[j])
        {

            
            
                System.Console.WriteLine($"{number[i]},{number[j]}");
            
            


        }


    }
}
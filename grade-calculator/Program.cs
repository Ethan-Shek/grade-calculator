/*
Ethan Shek
IGME 201 01
Due on Oct 13, 2024 
*/
namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student = "Ethan";
            int[] grades = new int[10];
            grades[0] = 100;
            grades[1] = 92;
            grades[2] = 87;
            grades[3] = 200;
            grades[4] = -20;
            grades[5] = 52;
            grades[6] = 82;
            grades[7] = 75;
            grades[8] = 67;
            grades[9] = 88;

            Console.WriteLine("Greeting student! Welcome " + student + "!");
            Console.WriteLine("Here are your grades: ");

            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                if(grades[i] >= 90 && grades[i] <=100)
                {
                    Console.WriteLine("This grade is A!");
                    if(grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if(grades[i] >= 80 && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is A!");
                }
            }
        }
    }
}

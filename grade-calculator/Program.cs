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
            int avg = 0;
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
                if (grades[i] >= 90 && grades[i] <= 100)
                {
                    Console.WriteLine("This grade is A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (grades[i] >= 80 && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is B.");
                }
                else if (grades[i] >= 70 && grades[i] <= 79)
                {
                    Console.WriteLine("This grade is C.");
                }
                else if (grades[i] >= 65 && grades[i] <= 69)
                {
                    Console.WriteLine("This grade is D.");
                }
                else if (grades[i] >= 0 && grades[i] <= 64)
                {
                    Console.WriteLine("This grade is F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }
            for (int z = 0; z < grades.Length; z++)
            {
                avg += grades[z];
            }
            avg /= grades.Length;
            Console.WriteLine("Your final average is: " + avg);
            Console.WriteLine("We have displayed all the grades for " + student);
        }
    }
}

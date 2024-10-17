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
            // intialize variables
            string student = "Ethan";
            int[] grades = new int[10];
            int avg = 0;
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

            // Intro to the program: welcome intro
            Console.WriteLine("Greeting student! Welcome " + student + "!");
            Console.WriteLine("Here are your grades: ");

            // loop that iterates through the array of grades by grading based off a range
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                if (grades[i] >= 90 && grades[i] <= 100)
                {
                    Console.WriteLine("This grade is A!");
                    if (grades[i] == 100)
                    {
                        // if a 100 is scored a special message is displayed
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
                    //if a negative is scored a special message is displayed
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }

            /* this loop will iterate through the length of the arrayand add them all together 
            which is stored in the avg variable that divide by the length after the for loop is finsihed
            iterating and then in the console it will print out the avg along with a concluding sentence*/
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

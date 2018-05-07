using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    //tesst
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            start:
            Console.WriteLine("Welcome\n This is a Collection of Quizzes\n CHOOSE:\n");
            Console.WriteLine(" A. Math\n B. Science\n C. Filipino\n D. English\n");
            Console.WriteLine("You Choose");
            A = Console.ReadLine();

            Console.WriteLine("\n");

            Math selectA = new Math();
            Science selectB = new Science();
            Filipino selectC = new Filipino();
            English selectD = new English();

            if (A == "A" || A == "a")
            {
                selectA.MathQuiz();
            }
            else if (A == "B" || A == "b")
            {
                selectB.ScienceQuiz();
            }
            else if (A == "C" || A == "c")
            {
                selectC.FilipinoQuiz();
            }
            else if (A == "D" || A == "d")
            {
                selectD.EnglishQuiz();
            }
            else
            {
                { 
                    if (A == "")
                    {
                        Console.WriteLine("No Letter");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Letter");
                    }

                }
            }
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
    class Quiz
    {
        public void Quizzes()
        {
            Console.WriteLine("This program has 4 quizzes");
        }
    }
    class Math : Quiz
    {
        public void MathQuiz()
        {
            int a;
            Console.WriteLine("Math Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the product of 20 and 25?");
            a = Convert.ToInt32(Console.ReadLine());
            if(a == 500)
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: 500");
            }
            int b;
            Console.WriteLine("2. What is the sum of 1025 and 1250?");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 2275)
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: 2275");
            }
            int c;
            Console.WriteLine("3. What is the difference of 2058 and 1253?");
            c = Convert.ToInt32(Console.ReadLine());
            if (c == 805)
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: 805");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
    class Science : Quiz
    {
        public void ScienceQuiz()
        {
            string a;
            Console.WriteLine("Science Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the shape of the Earth?");
            a = Console.ReadLine();
            if (a == "Sphere" || a == "sphere")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Sphere");
            }
            string b;
            Console.WriteLine("2. What is the third planet in the Solar System?");
            b = Console.ReadLine();
            if (b == "Earth" || b == "earth")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Earth");
            }
            string c;
            Console.WriteLine("3. What is the biggest planet in the Solar System?");
            c = Console.ReadLine();
            if (c == "Jupiter" || c == "jupiter")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Jupiter");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
    class Filipino : Quiz
    {
        public void FilipinoQuiz()
        {
            string d;
            Console.WriteLine("Science Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the national language of the Philippines?");
            d = Console.ReadLine();
            if (d == "Filipino" || d == "filipino")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Filipino");
            }
            string e;
            Console.WriteLine("2. What is the capital of the Philippines?");
            e = Console.ReadLine();
            if (e == "Manila" || e == "manila")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Manila");
            }
            string f;
            Console.WriteLine("3. What is the biggest city in the Philippines?");
            f = Console.ReadLine();
            if (f == "Quezon City" || f == "quezon city")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Quezon City");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
    class English : Quiz
    {
        public void EnglishQuiz()
        {
            string g;
            Console.WriteLine("English Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the substitute of Noun?");
            g = Console.ReadLine();
            if (g == "Pronoun" || g == "pronoun")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Pronoun");
            }
            string h;
            Console.WriteLine("2. What is an action word?");
            h = Console.ReadLine();
            if (h == "Verb" || h == "verb")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Verb");
            }
            string i;
            Console.WriteLine("3. What is a person, place or thing?");
            i = Console.ReadLine();
            if (i == "Noun" || i == "noun")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Noun");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
}

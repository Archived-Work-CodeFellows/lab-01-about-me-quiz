using System;

namespace Lab_01_About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stores the user name globally to be passed into other methods
            string user = UserName();

            //Here I call my ScoreCalculator and use the 
            //question methods as arguments to calculate the 
            //score at the end
            ScoreCalculator(FirstQuestion(user),
                SecondQuestion(user),
                ThirdQuestion(user),
                FourthQuestion(user),
                FifthQuestion(user), user);

        }
        //This method is to get the users name to have a more
        //personal experience
        static string UserName()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my awesome fun about me quiz.");
            Console.WriteLine("Where I'll ask you questions and hopefully you know the answers");
            Console.Write("\n\n");
            Console.Write("First non-scored question: What is your name? ");
            string user = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {user}! I hope you are ready! Now points matter..");
            Console.ReadLine();
            return user;
        }
        //This method returns a bool since the content is asking a yes/no
        //question. 
        static bool FirstQuestion(string user)
        {
            Console.Clear();
            Console.WriteLine("Alright first question worth some points: Am I colorblind? yes/no ");
            string result = Console.ReadLine().ToLower();

            //Using this helps clean up the console window to avoid
            //text clutter
            Console.Clear();

            if (result == "yes")
            {
                Console.WriteLine("You are correct! As I mentioned in class I am partially " +
                    "colorblind and have no concept of purple");
                Console.ReadLine();
                return true;
            } else
            {
                Console.WriteLine("I am sorry, the answer is in fact yes. I am partially colorblind");
                Console.ReadLine();
                return false;
            }
        }
        //This is a method that asks the user to pick from a given
        //list and then provides a response
        static string SecondQuestion(string user)
        {
            Console.Clear();
            Console.WriteLine($"Alright {user}, Out of these instruments, what do I play? (select a number)");

            //Used to create formatting in the console window for
            //spacing
            Console.WriteLine(" ");

            Console.WriteLine("1) Piano");
            Console.WriteLine("2) Saxophone");
            Console.WriteLine("3) Bassoon");
            Console.WriteLine("4) Laptop/Electronics");
            string result = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Alright {user}, that was kind of a freebie.");
            Console.WriteLine(" ");
            Console.WriteLine("I originally went to become a Bassoonist and Jazz Saxophonist, but I picked up");
            Console.WriteLine("Multiple instruments along the way. Yes laptop is an instrument too!");
            Console.ReadLine();
            return "3";
        }
        //This method returns an integer based on user input. It also
        //has another nested method that since it was starting to become
        //more complex, I decided to write a separate method
        static int ThirdQuestion(string user)
        {
            Console.Clear();
            Console.WriteLine($"Cool {user}, Do I have any pets? yes/no ");
            string result = Console.ReadLine().ToLower();
            Console.Clear();
            if(result == "yes")
            {
                Console.WriteLine("Woohoo! You are right!");
                return PetQuestion(user);
            } else
            {
                Console.WriteLine("Nope. I actually do have pets. But that isn't the real question!");
                return PetQuestion(user);
            }
        }
        //This is the method that was refactor to ease complexity
        static int PetQuestion(string user)
        {
            Console.WriteLine("How many pets do I have? (please write integer ex: 1,2,3 etc)");
            string result = Console.ReadLine();
            Console.Clear();
            if (result == "1")
            {
                Console.WriteLine("You got it! I have one cat and his name is Sox.");
                Console.WriteLine("He is 15 going on 16 in July so he pretty much just sleeps");
                Console.ReadLine();
                return Int32.Parse(result);
            }
            else
            {
                Console.WriteLine($"Oh I'm sorry {user}. I actually have 1 pet not {result}");
                Console.ReadLine();
                return Int32.Parse(result);
            }
        }
        //Similar to the method for the second question
        //This provides the user with a list to select from
        //However this method has a correct answer
        static string FourthQuestion(string user)
        {
            Console.Clear();
            Console.WriteLine($"Serious question time {user}, What is my favorite food? (select a number)");

            //Used to create formatting in the console window for
            //spacing
            Console.WriteLine(" ");

            Console.WriteLine("1) Pizza");
            Console.WriteLine("2) Ice Cream");
            Console.WriteLine("3) Soup");
            Console.WriteLine("4) Mac n Cheese");
            string result = Console.ReadLine();
            Console.Clear();
            if (result == "2")
            {
                Console.WriteLine("Oh man, you got me. I don't think I can possibly turn down ice cream.");
                Console.WriteLine("Which sucks because I became lactose intolerant a few years back");
                Console.WriteLine("But sometimes suffering makes you stronger");
                Console.ReadLine();
                return result;
            } else
            {
                Console.WriteLine($"Ah that is a good choice {user} but sadly no");
                Console.WriteLine("My heart belongs to Ice Cream.");
                Console.WriteLine("Though I became lactose intolerant a while back");
                Console.WriteLine("So it is a one-sided relationship");
                Console.ReadLine();
                return result;
            }
        }
        //This method is similar to the second and fourth questions
        //A list is provided to the user to select from.
        static string FifthQuestion(string user)
        {
            Console.Clear();
            Console.WriteLine($"{user} this is the last question!");

            //Used to create formatting in the console window for
            //spacing
            Console.WriteLine(" ");

            Console.WriteLine("What do I want to do after Code Fellows? (select a number)");
            Console.WriteLine("1) Be a Barista");
            Console.WriteLine("2) Teach");
            Console.WriteLine("3) Be a musician/composer");
            Console.WriteLine("4) Develop and Design Video Games");
            string result = Console.ReadLine();
            Console.Clear();

            if(result == "4")
            {
                Console.WriteLine("You are right. My biggest goal is to be a game developer");
                Console.WriteLine("though just programming and problem solving are fun,");
                Console.WriteLine("I am interested in creating unique worlds and technologies that have an impactful experience");
                Console.WriteLine("for others. I have done everything above either in the past or still do so now.");
                Console.ReadLine();
                return result;
            }
            else
            {
                Console.WriteLine("I have done all of these things either in the past or still continue to do so");
                Console.WriteLine("but my biggest goal after Code Fellows is to get into game design");
                Console.WriteLine("and that is where my motivation and passion are fixiated");
                Console.ReadLine();
                return result;
            }
        }
        //This method is to inform the user that they have reached the end
        //and that the application will be finished
        static void Ending(string user)
        {
            Console.Clear();
            Console.WriteLine($"Congrats {user}! You've made it to the end of this Quiz!");
            Console.WriteLine("I hoped you learned some new things about me!");
            Console.WriteLine("Now lets check your score!");
            Console.ReadLine();
        }

        //This method takes the question methods in as arguments
        //and uses the return value from the user to check for
        //scoring
        static void ScoreCalculator(bool firstQ, string secondQ, int thirdQ, string fourthQ, string fifthQ, string user)
        {
            Console.Clear();
            int counter = 0;

            //Since the first question is a boolean return
            //We can use a ternary to check if it is true.
            //If it is, then it will  set counter to one, else stay 0
            counter = firstQ ? 1 : 0;

            if (secondQ == "3") counter++;
            if (thirdQ == 1) counter++;
            if (fourthQ == "2") counter++;
            if (fifthQ == "4") counter++;

            Ending(user);
            Console.Clear();

            Console.WriteLine($"After all is said and done, {user}, you got {counter} out of 5!");
            Console.WriteLine(" ");
            Console.WriteLine("Congrats!");
            Console.WriteLine("Bye-bye!");
            Console.ReadLine();
        }
    }
}

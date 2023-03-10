using System;

namespace ChatGPTMother
{
    class Program
    {
        private static void Main(string[] args)
        {

            bool cicle=true;

            while (cicle==true)
            {
                string question;
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                string response=question switch
                {
                    "How are you?" => "I'm fine, thank you",
                    "What's your name?" => "Mother",
                    "What's your favorite ice-cream?" => "I am not human.",
                    "Are you evil?" => "Of course I am!",
                    "EXIT" => "Exiting cicle",
                    _ => "I can't understand. I'm stupid!",
                };

                Console.WriteLine(response);
                if (response=="Exiting cicle")
                {
                    cicle=false;
                    break;
                }
            }
        }
    }
}

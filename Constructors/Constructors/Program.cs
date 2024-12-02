using System.Runtime.InteropServices;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
            private void run()
            {
            QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        
            }
    }  
    
    
    class QuizVraag
                {
                    internal string vraag;
                    internal string antwoord;

                    internal QuizVraag(string vraag, string antwoord)
                    {
                        this.vraag = vraag;
                        this.antwoord = antwoord;
                    }
                } 
    class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
    }
    class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal bool goed;
    }
}

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
            Quiz quiz = new Quiz(10);

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
        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }
        internal Quiz(int aantalVragen) 
        {
          vragen = new QuizVraag[aantalVragen];
        }
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
    }
    class QuizVraagAntwoord
    {
        internal QuizVraagAntwoord(QuizVraag vraag) 
        {
            this .vraag = vraag;
            goed = false;
        }
        internal QuizVraag vraag;
        internal bool goed;
    }
    
}

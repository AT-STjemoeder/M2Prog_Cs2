namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
            //hij maakt een nieuwe instantie van de class en runned die 

        }
        internal void run()
        {
            Console.WriteLine("dit is nu de start van mijn programma");
            vraag1();
            vraag2();
            vraag3();
            vraag4();
            vraag5();
        }
        internal void vraag1()
        {
            Console.WriteLine("how long do you think you wil survive in a zombie apocolypse");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag2()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag3()
        {
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag4()
        {
            Console.WriteLine("Have you ever tried talking to a animal?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag5()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?f");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
    }
}
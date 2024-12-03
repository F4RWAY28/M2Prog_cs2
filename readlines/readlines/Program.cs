namespace readlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            Console.WriteLine("Did it work?");
            Vraag1();
        }

        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal string Vraag7()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord7 = Console.ReadLine();
            return antwoord7;
        }

        internal string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan?"
        };

        internal string GetVraag(int vraagIndex)
        {
            if (vraagIndex >= 0 && vraagIndex < vragen.Length)
            {
                return vragen[vraagIndex];
            }
            else
            {
                return "Invalid vraag index.";
            }
        }

        internal string GetRandomVraag()
        {
            Random random = new Random();
            int randomIndex = random.Next(vragen.Length);
            return GetVraag(randomIndex);
        }
        internal string AskRandomQuestion();
        
        internal void Run()
        {
            Console.WriteLine("We gaan nu vier willekeurige vragen stellen:");

            // Gebruik de nieuwe functie vier keer
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
        }
    }
}


namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 69.69 };

            string[] artikelen = { "snoepje", "luxe broodje", "lunch menu", "Hooters Classic" };

            Formulier[] formulieren = new Formulier[3];

            formulieren[0] = new Formulier()
            {
                Feedback = "Prijzig, maar lekker.",
                Sterren = 5
            };

            formulieren[1] = new Formulier()
            {
                Feedback = "Goedkoop en gezond.",
                Sterren = 4
            };

            formulieren[2] = new Formulier()
            {
                Feedback = "Lekker en warm.",
                Sterren = 69
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artikelen[i]);
            }

            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
            }
        }
    }
}

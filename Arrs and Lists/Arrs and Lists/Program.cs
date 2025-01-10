using System.Xml.Linq;

namespace Arrs_and_Lists
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
                String[] characters = {
        "Pac - Man",
        "Samus",
        "Crash Bandicoot",
        "Spyro the Dragon",
        "Donkey Kong",
        "Mario",
        "Luigi",
        "Astro",
        "Solid Snake",
        "Master Chief",
        "Kratos",
        "Sonic the Hedgehog",
        "Link" };

            List<string> characterList = new List<string>();

            characterList.Add("Freddy Freakbear");

            for (int i = 0; i < characters.Length; i++)
            {
                characterList.Add(characters[i]);
            }

            Console.WriteLine(characterList.Count());

            foreach (var item in characterList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

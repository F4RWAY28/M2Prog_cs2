
using Rijschool;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Auto auto1 = new Auto() {
                automaat = true,
                kenteken = "AA824H",
                kilometerstand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto() {
                automaat = false,
                kenteken = "KU786G",
                kilometerstand = 65739,
                merk = "volvo"
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,
                tijd = 1330
            };

            TheorieTest theorieTest = new TheorieTest()
            {
                aantalFouten = 10,
                gehaald = true,
                afnameDatum = new DateTime(2024, 4, 28)
            };

            Student student = new Student()
            {
                lesUur = lesUur,
                lesPakket = lesPakket,
                theorieTest = theorieTest,
                rijTest = rijTest
            };

            Dag dag = new Dag()
            {
                datum = new DateTime(2024, 4, 28),
                LesUur = lesUur
            };
               
            


            
            Student student2 = new Student()
            {
                lesUur = lesUur,
                lesPakket = lesPakket,
                theorieTest = theorieTest,
                rijTest = rijTest
            };




        }
    }
}

using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace OOPSandkasse
{
    class MinException : Exception
    {
        public string Message { get; set; }
        public MinException(string message) : base(message)
        {
            Message = message;
        }
        public MinException() { Console.WriteLine("Test"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valg = Convert.ToInt32(Metode(null));
            }
            catch(MinException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("Hejsa");
            }
            Console.ReadKey();

            Box box1 = new Box(BoxType.lille);
            Box box2 = new Box(BoxType.lille);
            Box box3 = box1 + box2;

            Console.WriteLine(box1.boxType);
            Console.WriteLine(box2.boxType);
            Console.WriteLine(box3.boxType);
            Console.ReadKey();

            Person person1 = new Person();
            person1.Navn = "Abraham";
            person1.Efternavn = "Lincoln";
            person1.Adresse = "Hvide Hus";
            person1.Tlf = "12345678";

            Person person2 = new Person();
            person2.Navn = "Gilbert";
            person2.Efternavn = "Skysovs";

            Person person3 = new Person();
            person3.Navn = "Blomme";

            Person person4 = new Person();
            person4.Navn = "Flomme";

            Person person5 = new Person();
            person5.Navn = "Alexandre";


            Kunde kunde = new Kunde();
            kunde.Navn = "John";

            Ansat ansat = new Ansat();
            ansat.Navn = "Doe";

            Figur figur = new Firkant(); // Giver fejl, da figur er abstract
            Firkant firkant = new Firkant();
            figur.Rumfang();

            List<Person> people = new List<Person>();
            people.AddRange(new List<Person> { person1, person2, person3, person4, person5});
            people.Sort();

            Dictionary<string, Person> pairs = new Dictionary<string, Person>();
            pairs.Add("Olle@gmail.com", person1);

            foreach (var item in people)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadKey();

            //Bil oliverBil = new Bil();
            //oliverBil.Mærke = "Skoda";
            //oliverBil.AntalDøre = 5;
            //oliverBil.Hestekrafter = 115;
            //oliverBil.Model = "Skala";


            //Bil halimeBil = new Bil("Folkevogn", "T-roc", 5, 140);

            Produkt egg = new Produkt();
            egg.kg = 1;
            egg.størrelse = "Stor";
            egg.Pris = 700;
            Console.WriteLine(egg.Moms);

            HashSet<int> ints = new HashSet<int>(); // Bingo Listen
            ints.Add(1);
            ints.Add(1);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            //#region Noter


            ////List<Bil> bils = new List<Bil>();
            ////bils.Add(oliverBil);
            ////bils.Add(halimeBil);

            ////foreach (var item in bils)
            ////{
            ////    Console.WriteLine(item.Mærke);
            ////    Console.WriteLine(item.Hestekrafter);
            ////    Console.WriteLine(item.AntalDøre);
            ////    Console.WriteLine(item.Model);
            ////    Console.WriteLine();
            ////}

            ////Console.WriteLine("Vælg kører");
            ////Console.WriteLine("1. Skoda");
            ////Console.WriteLine("2. Folkevogn");
            ////if (int.TryParse(Console.ReadLine(), out int valg)) { }
            ////else valg = 1;
            //#endregion

            //bool isRunning = true;
            //while(isRunning)
            //{
            //    //Console.Clear();
            //    Console.WriteLine("1. For speeder");
            //    Console.WriteLine("2. For bremse");
            //    Console.WriteLine("3. For Stop");
            //    int køreValg = int.Parse(Console.ReadLine());
            //    switch (køreValg)
            //    {
            //        case 1:
            //            oliverBil.Accelerer(1);
            //            break;
            //        case 2:
            //            oliverBil.Bremse(1);
            //            break;
            //        case 3:
            //            isRunning = oliverBil.Stop();
            //            break;
            //        default:
            //            Console.WriteLine("Cruiser");
            //            break;
            //    }
            //    Console.ReadKey();
            //}

            ////Console.WriteLine(halimeBil.Mærke);
            //Console.ReadKey();
        }

        private static bool Metode(string v)
        {
            throw new MinException("Metode Fejl");
        }
    }
}

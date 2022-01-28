internal class Program
{


    public static void Main()
    {
        List<Ime> Imena = new();

        do
        {

            Ime i = new();


            Console.Write("Unesite izbor:");
            i._choice = Console.ReadLine();
            Console.Clear();

            Console.Write("Unesite ime:");
            i._name = Console.ReadLine();



            Console.Write("Unesite broj indeksa:");
            i._index = Console.ReadLine();

            Console.Write("Unesite ime grada od faxa:");
            i._city = Console.ReadLine();

            Console.Write("unesite ulicu:");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            i._street = Console.ReadLine();

            Imena.Add(i);
            int dex = 0;
            foreach (Ime nesto in Imena)
            {
                Console.WriteLine($"{++dex}.{nesto._choice}");
                Console.WriteLine($"{++dex}.{nesto._name}");
                Console.WriteLine($"{++dex}.{nesto._index}");
                Console.WriteLine($"{++dex}.{nesto._city}");
                Console.WriteLine($"{++dex}.{nesto._street}");
            }

            if (Imena.Count < dex)
            {
                Console.WriteLine("Bravo :-)");
            }
            /*else
            {
                Imena.RemoveAt(0);
                Console.WriteLine("JOK");
            }*/

        } while (true);
    }
    internal class Ime
    {
        public string _choice;

        public string _name;

        public string _index;

        public string _city;

        public string _street;

        //private string moja_nesto;



        /*public void StampajMeni()
            {
                Console.WriteLine($"Hej, ja sam {_choice} :D");
            }*/

    }
}



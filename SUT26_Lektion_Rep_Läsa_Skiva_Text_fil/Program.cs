namespace SUT26_Lektion_Rep_Läsa_Skiva_Text_fil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------
            // 1. VILLKORSSATSER (if / else if / else)
            // -----------------------------------------------------
            Console.WriteLine("=== Villkorssatser ===");
            Console.Write("Ange din ålder: ");
            int alder = int.Parse(Console.ReadLine());

            if (alder < 0)
            {
                Console.WriteLine("Ogiltig ålder.");
            }
            else if (alder < 18)
            {
                Console.WriteLine("Du är minderårig.");
            }
            else if (alder < 65)
            {
                Console.WriteLine("Du är vuxen.");
            }
            else
            {
                Console.WriteLine("Du är pensionär.");
            }

            // switch – bra vid många fasta alternativ
            Console.Write("Ange betyg (A-F): ");
            string betyg = Console.ReadLine().ToUpper();

            switch (betyg)
            {
                case "A":
                case "B":
                    Console.WriteLine("Mycket bra!");
                    break;
                case "C":
                case "D":
                    Console.WriteLine("Godkänt.");
                    break;
                case "E":
                    Console.WriteLine("Precis godkänt.");
                    break;
                case "F":
                    Console.WriteLine("Ej godkänt.");
                    break;
                default:
                    Console.WriteLine("Okänt betyg.");
                    break;
            }

            // -----------------------------------------------------
            // 2. WHILE-loop – kör så länge villkoret är sant
            // -----------------------------------------------------
            Console.WriteLine("\n=== While-loop ===");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("While-varv: " + i);
                i++;
            }

            // -----------------------------------------------------
            // 3. DO WHILE-loop – kör MINST en gång, kollar villkor efteråt
            // -----------------------------------------------------
            Console.WriteLine("\n=== Do While-loop ===");
            string svar;
            do
            {
                Console.Write("Skriv 'ja' för att fortsätta: ");
                svar = Console.ReadLine().ToLower();
            }
            while (svar != "ja");
            Console.WriteLine("Du skrev ja!");

            // -----------------------------------------------------
            // 4. FOR-loop – när du vet antal varv
            // -----------------------------------------------------
            Console.WriteLine("\n=== For-loop ===");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("For-varv: " + j);
            }

            // -----------------------------------------------------
            // 5. FOREACH-loop – går igenom varje element i en samling
            // -----------------------------------------------------
            Console.WriteLine("\n=== Foreach-loop ===");
            string[] namn = { "Anna", "Erik", "Sara", "Omar" };
            foreach (string n in namn)
            {
                Console.WriteLine("Hej " + n + "!");
            }

            Console.WriteLine("\nKlart! Tryck valfri tangent.");


            //----------------------------------------------------------------

            // -----------------------------------------------------
            // 1. SKRIVA till fil (skapar/skriver över)
            // -----------------------------------------------------
            string filnamn = "anteckningar.txt";

            Console.WriteLine("=== Spara till fil ===");
            Console.Write("Skriv en rad text: ");
            string text = Console.ReadLine();

            File.WriteAllText(filnamn, text);
            Console.WriteLine("Sparat till " + filnamn);


            // -----------------------------------------------------
            // 2. LÄGGA TILL rader (append) med loop
            // -----------------------------------------------------
            Console.WriteLine("\n=== Lägg till rader (skriv 'stop' för att avsluta) ===");
            string rad;
            while (true)
            {
                Console.Write("Ny rad: ");
                rad = Console.ReadLine();

                if (rad.ToLower() == "stop")
                    break;

                File.AppendAllText(filnamn, Environment.NewLine + rad);
            }


            // -----------------------------------------------------
            // 3. LÄSA hela filen
            // -----------------------------------------------------
            Console.WriteLine("\n=== Läsa från fil ===");
            if (File.Exists(filnamn))
            {
                string innehall = File.ReadAllText(filnamn);
                Console.WriteLine("Innehåll:\n" + innehall);
            }
            else
            {
                Console.WriteLine("Filen finns inte.");
            }


            // -----------------------------------------------------
            // 4. LÄSA rad för rad med foreach (kombinerar Del 1 + 2)
            // -----------------------------------------------------
            Console.WriteLine("\n=== Läsa rad för rad ===");
            string[] rader = File.ReadAllLines(filnamn);
            int nr = 1;
            foreach (string r in rader)
            {
                Console.WriteLine(nr + ": " + r);
                nr++;
            }


            Console.ReadKey();
        }
    }
}

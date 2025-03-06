using System.Threading.Channels;

namespace _5._2
{
    enum sassocartaforbici
    {
        sasso=0,
        carta=1,
        forbice=2,
        fine=3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire sasso carta o forbice o fine");
            string scelta = Console.ReadLine();
            Random rnd = new Random();  
            int countMacchina = 0;
            int countUtente = 0;
            while (scelta != "fine")
            {
                sassocartaforbici sceltaUtente = sassocartaforbici.sasso;
                switch (scelta)
                {
                    case "sasso":
                        sceltaUtente = sassocartaforbici.sasso;
                        break;
                    case "carta":
                        sceltaUtente = sassocartaforbici.carta;
                        break;
                    case "forbice":
                        sceltaUtente = sassocartaforbici.forbice;
                        break;
                    default:
                        Console.WriteLine("scelta non valida");
                        break;
                }
                sassocartaforbici sceltaComputer = (sassocartaforbici)rnd.Next(0, 3);
                Console.WriteLine("scelta computer: {0}", sceltaComputer);
              
                if (sceltaComputer == sceltaUtente)
                {
                    Console.WriteLine("pareggio");
                }
                else if (sceltaComputer == sassocartaforbici.sasso && sceltaUtente == sassocartaforbici.forbice)
                {
                    Console.WriteLine("vince computer");
                    countMacchina++;
                }
                else if (sceltaComputer == sassocartaforbici.carta && sceltaUtente == sassocartaforbici.sasso)
                {
                    Console.WriteLine("vince computer");
                    countMacchina++;
                }
                else if (sceltaComputer == sassocartaforbici.forbice && sceltaUtente == sassocartaforbici.carta)
                {
                    Console.WriteLine("vince computer");
                    countMacchina++;
                }
                else
                {
                    Console.WriteLine("vince utente");
                    countUtente++;
                }
                Console.WriteLine("inserire sasso carta o forbice o fine");
                scelta = Console.ReadLine();
            }
            Console.WriteLine("hai vinto {0} volte, hai perso {1} volte", countUtente, countMacchina);
        }
    }
}

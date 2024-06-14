using System.Security.Cryptography.X509Certificates;

namespace Harry_Potter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("velkommen trollmann, vennligs skriv navnet ditt.");
            string Wizardname = Console.ReadLine();

            Console.WriteLine($"velkommen " + Wizardname + " hvilket hus er du i?");
            string Wizardhouse = Console.ReadLine();

            var wizard = new Wizard(Wizardname, Wizardhouse);

            Console.WriteLine($"Velkommen " + wizard.GetName() + " fra " + wizard.GetHouse());
            Game();
            void Game() {

                Console.Clear();

                Shop shop = new Shop();
            Console.WriteLine("Hva vill du gjøre?");

            Console.WriteLine("1. Kjøp kjeledyr");

            Console.WriteLine("2. Kjøp tryllestav");

            Console.WriteLine("3. Bruk magi");

            Console.WriteLine("4. Vis inventory");

            Console.WriteLine("5. For å avslutte programmet.");

                string menyValg = Console.ReadLine();
            switch(menyValg){

                case "1":
                    Console.Clear();
                    BuyPet(wizard);
                break;

                case "2":
                    Console.Clear();
                    BuyWand(wizard);
                    break;

                case "3":
                Console.Clear();
                    BrukMagi();
                break;

                case "4":
                Console.Clear();
                wizard.GetItems();
                break;

                case "5":
                    Console.WriteLine("Sees på Hogwarts!");
                    System.Environment.Exit(0);
                    break;

                        Console.WriteLine("1.Back");
                
                string backinput = Console.ReadLine();

                switch(backinput){
                    case "1": Game();
                    break;
                    
                    default: Console.WriteLine("Invalid input.");
                    break;
                }


                break;


                default:
                Console.WriteLine("error");
                break;
            }   
            void BrukMagi()
            {
                
                Console.WriteLine("Si nøyaktig formelen du vil bruke.");
            string spellinput = Console.ReadLine();
            switch(spellinput){

            case "vingardium leviosa": Console.WriteLine("Du får en fjer til å fly");
                BrukMagi();
       break; 
            case "hokus pokus": Console.WriteLine("Du fyrer av fyrverkerier");
                BrukMagi();
       break;
            default: Console.WriteLine("Ingenting skjer...");
                Game();
       break;


            }


            }
              void BuyPet(Wizard wizard)
            {
                Console.WriteLine("Velg et dyr: 1. Ugle 2. Rotte 3. Katt 4.Gå tilbake");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Du har lagt til Ugle");
                        wizard.Items.Add("Ugle");
                        BuyPet(wizard);
                        break;
                    case "2":
                        Console.WriteLine("Du har lagt til Rotte");
                        wizard.Items.Add("Rotte");
                        BuyPet(wizard);
                        break;
                    case "3":
                        Console.WriteLine("Du har lagt til Katt");
                        wizard.Items.Add("Katt");
                        BuyPet(wizard);
                        break;
                    case "4":
                        Game();
                        break;

                    default:
                        Console.WriteLine("Ugyldig valg");
                        break;
                }

            }
             void BuyWand(Wizard wizard)
            {
                Console.WriteLine("Velg en tryllestav: 1. Føniksstav 2. Unikornstav 3. Trollstav 4.Gå tilbake");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Du har lagt til Føniksstav");
                        wizard.Items.Add("Føniksstav");
                        BuyWand(wizard);
                        break;
                    case "2":
                        Console.WriteLine("Du har lagt til Unikornstav");
                        wizard.Items.Add("Unikornstav");
                        BuyWand(wizard);
                        break;
                    case "3":
                        Console.WriteLine("Du har lagt til Trollstav");
                        wizard.Items.Add("Trollstav");
                        BuyWand(wizard);
                        break;

                    case "4":
                        Game();


                        break;
                    default:
                        Console.WriteLine("Ugyldig valg");
                        break;
                }
            }
        }


      

           
            }
    }

            


            }




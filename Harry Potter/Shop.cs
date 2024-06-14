using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Harry_Potter
{
    internal class Shop
    {
        
        public void BuyPet(Wizard wizard)
        {
            Console.WriteLine("Velg et dyr: 1. Ugle 2. Rotte 3. Katt 4.Gå tilbake");
            string choice = Console.ReadLine();
            switch (choice) 
            { 
            case "1": Console.WriteLine("Du har lagt til Ugle");
            wizard.Items.Add("Ugle");
            BuyPet(wizard);
                    break;
            case "2": Console.WriteLine("Du har lagt til Rotte");
                wizard.Items.Add("Rotte");
                BuyPet(wizard);
                    break;
            case "3": Console.WriteLine("Du har lagt til Katt");
                    wizard.Items.Add("Katt");
                    BuyPet(wizard);
                    break;
            case "4":
                bool shopping = false;
                break;

                default:
                    Console.WriteLine("Ugyldig valg");
                    break;
            }

        }
        public void BuyWand(Wizard wizard)
        {
            Console.WriteLine("Velg en tryllestav: 1. Føniksstav 2. Unikornstav 3. Trollstav 4.Gå tilbake");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": Console.WriteLine("Du har lagt til Føniksstav");
                    wizard.Items.Add("Føniksstav");
                    BuyWand(wizard);
                    break;
                case "2": Console.WriteLine("Du har lagt til Unikornstav");
                    wizard.Items.Add("Unikornstav");
                    BuyWand(wizard);
                    break;
                case "3": Console.WriteLine("Du har lagt til Trollstav");
                    wizard.Items.Add("Trollstav");
                    BuyWand(wizard);
                    break;

                case "4":
                    bool shopping = false;
                    

                    break;
break;
                default:
                    Console.WriteLine("Ugyldig valg");
                    break;
            }
        }
    }


}

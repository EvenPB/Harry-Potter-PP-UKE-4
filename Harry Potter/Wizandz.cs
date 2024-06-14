namespace Harry_Potter
{
    public class Wizard
    {
        public string Name { get; set; }
        public string House { get; set; }

        public List<string> Items { get; set; }

        public Wizard(string name, string house)
        {
            Name = name;
            House = house;
            Items = new List<string>();
        }

        public string GetName(){
        return Name;
    }

        public string GetHouse(){
            return House;
        }

        public void GetItems(){
            if (Items.Count > 0) {
                foreach (var item in Items)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine("Du har ingen items");
            }
           
        }


    }
}
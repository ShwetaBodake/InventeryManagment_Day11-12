//using InventaryMangement;
using InventoryManagement;

namespace InventaryMangement
{
    public class Program
    {
        public static void Main(string[] args)
        {


            string path = "/Users/shwetabodake/Projects/Inventary Mangement/Inventary Mangement/Inventary.json";



            FetchInventoryDetails FetchInventoryDetails = new FetchInventoryDetails();

            Details data = FetchInventoryDetails.Read(path);


            Console.WriteLine("----Types of Rice-----");
            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine(data.typesOfRice[i].weight);

                int Totalprice = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("The price for" + data.typesOfRice[i].weight + "Kg is: " + Totalprice);
            }
            Console.WriteLine("----Types of Wheat-----");
            for (int i = 0; i < data.typesOfWheats.Count; i++)
            {
                Console.WriteLine(data.typesOfWheats[i].name);
                Console.WriteLine(data.typesOfWheats[i].price);
                Console.WriteLine(data.typesOfWheats[i].weight);

                int Totalprice = data.typesOfWheats[i].weight * data.typesOfWheats[i].price;
                Console.WriteLine("The price for" + data.typesOfWheats[i].weight + "Kg is: " + Totalprice);
            }

            Console.WriteLine("----Types of Pulses-----");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].price);
                Console.WriteLine(data.typesOfPulses[i].weight);

                int Totalprice = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
                Console.WriteLine("The price for" + data.typesOfPulses[i].weight + "Kg is: " + Totalprice);
            }
           

        
        }
    }
}

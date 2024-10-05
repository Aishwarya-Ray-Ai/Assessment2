using System.Security.Cryptography.X509Certificates;

namespace Assmnt2Ques1
{
    public  class Fish
    {
        public string Species { get; set; }
        public double PricePerFish { get; set; }

        public int numOfFish { get; }

        // constructor for passing the argument
        public Fish(string species, double priceoffish)
        {
            Species = species;
            PricePerFish = priceoffish;
            //numOfFish = numFish;
        }



        public List<Fish> FishAvailable = new List<Fish>();
        public  void AddFish(string Spesies, double PricePerFish)
        {
            Fish newFish = new Fish(Species, PricePerFish);
            FishAvailable.Add(newFish);
           // Console.WriteLine("The new fish is added to the Aqua shop");

        }
        public  bool BuyFish(string Species)
        {
            Fish fishBuy = FishAvailable.Find(x => x.Species == Species); // to find out the fish in the list
            if (fishBuy != null)
            {
                double TotalPrice = Convert.ToDouble(CalculatePrice(numOfFish));
                return true;

            }
            else
            {
                Console.WriteLine("OOPS!!! SORRY We don't have the fish.. You can try another.");
                return false;
            }
        }

        public  double CalculatePrice(int numberOfFishes)
        {
            double packingCharges = 0;
            if (Species == "goldfish")
            {
                packingCharges = 150;
            }
            else if (Species == "clownfish")
            {
                packingCharges = 100;
            }
            else
            {
                packingCharges = 100;
            }
            return PricePerFish * numberOfFishes + packingCharges;
        }
        public class Program {
            public static void Main(string[] args)
            {


                Console.WriteLine("Enter the spesies to buy: ");
                string fishName = Console.ReadLine();

                Console.WriteLine("Enter the number of fishes : ");
                int numberOfFish = int.Parse(Console.ReadLine());

                Fish shop = new Fish(fishName, numberOfFish);
                shop.AddFish("Goldfish", 5.99);
                shop.AddFish("Betta", 10.50);
                shop.AddFish("Clownfish", 25.75);


                Console.WriteLine($"Your total cost is :{shop.CalculatePrice( numberOfFish)} ");

            }
        }
    }
}
    
       
    

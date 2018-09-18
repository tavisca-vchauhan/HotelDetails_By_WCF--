using Hotel.ServiceReference1;
using HotelsServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel
{
    class HotelMain
    {
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                HotelServiceClient dc = new HotelServiceClient("BasicHttpBinding_IHotelService");
                Console.WriteLine("Which operation you want to perform :\n1 to get hotel details by Id\n2 to get list of all hotels");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter Hotel ID :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n---------------------------------------------------------");
                        Console.WriteLine(dc.GetHotelById(id));
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                    case 2:
                        List<HotelDetails> hotels = dc.GetHotelData().ToList();
                        for (int index = 0; index < hotels.Count; index++)
                        {
                            Console.WriteLine("\n---------------------------------------------------------");
                            Console.WriteLine("Hotel Name is : {0}\nHotel ID is : {1}\nHotel address is : {2}\nHotel rating is : {3}", hotels[index].HotelName, hotels[index].HotelId, hotels[index].Address, hotels[index].StarRating);
                            Console.WriteLine("---------------------------------------------------------");
                        }

                        break;
                    default:
                        Console.WriteLine("You have entered wrong choice !");
                        break;
                }
                Console.Write("Do you wanna continue...! (Y/N)");
                choice = Console.ReadLine();
            }
            while (choice.ToLower() == "y");
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelsServiceLibrary
{
    public class Hotel : IHotelService
    {

        public string GetHotelById(int id)
            {
                using (StreamReader r = new StreamReader("../../HotelData.json"))
                {
                    string json = r.ReadToEnd();
                    List<HotelDetails> hotels = JsonConvert.DeserializeObject<List<HotelDetails>>(json);

                    for (int index = 0; index < hotels.Count; index++)
                    {
                        if (id == Convert.ToInt32(hotels[index].HotelId))
                            return string.Format("Hotel Name is : {0}\nHotel ID is : {1}\nHotel address is : {2}\nHotel rating is : {3}", hotels[index].HotelName, hotels[index].HotelId, hotels[index].Address, hotels[index].StarRating);
                    }
                }
                return string.Format("Wrong ID !");

            }

            public List<HotelDetails> GetHotelData()
            {
                using (StreamReader r = new StreamReader("../../HotelData.json"))
                {
                    string json = r.ReadToEnd();
                    List<HotelDetails> hotels = JsonConvert.DeserializeObject<List<HotelDetails>>(json);
                    return hotels;
                }
            }       
    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelsServiceLibrary
{
    [DataContract]
    public class HotelDetails
    {
        [DataMember]
        public string HotelName { get; set; }
        [DataMember]
        public string HotelId { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public double StarRating { get; set; }
    }

}

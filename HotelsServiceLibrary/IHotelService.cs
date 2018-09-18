using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelsServiceLibrary
{
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        List<HotelDetails> GetHotelData();

        [OperationContract]
        string GetHotelById(int id);

    }
}

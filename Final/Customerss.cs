using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Customerss
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string CustomerName { get; set; }
        [BsonElement("address")]
        public string CustomerAddress { get; set; }
        [BsonElement("phoneNumber")]
        public string CustomerphoneNumber { get; set; }
        [BsonElement("renting")]
        public string CustomerRenting { get; set; }
       
        [BsonElement("timesRenting")]
        public int CustomertimesRenting { get; set; }

        public Customerss(string customerName, string customerAddress, string customerphoneNumber, string customerRenting, int customertimesRenting)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerphoneNumber = customerphoneNumber;
            CustomerRenting = customerRenting;
            CustomertimesRenting = customertimesRenting;
        }
    }
}

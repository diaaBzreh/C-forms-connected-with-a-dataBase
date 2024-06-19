using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Final
{
    internal class Employess
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string EmpolyeeName { get; set; }

        [BsonElement("phoneNumber")]
        public string EmpolyeePhoneNumber { get; set; }

        [BsonElement("address")]
        public string EmpolyeeAddress { get; set; }

        [BsonElement("rentalLocationName")]
        public string EmpolyeeRentalLocationName { get; set; }

        public Employess(string empolyeeName, string empolyeePhoneNumber, string empolyeeAddress, string empolyeeRentalLocationName)
        {
            EmpolyeeName = empolyeeName;
            EmpolyeePhoneNumber = empolyeePhoneNumber;
            EmpolyeeAddress = empolyeeAddress;
            EmpolyeeRentalLocationName = empolyeeRentalLocationName;
        }
    }
}

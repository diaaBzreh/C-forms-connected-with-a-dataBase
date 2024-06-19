using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Vehicles
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("type")]
        public string vehiclesType { get; set; }
        [BsonElement("name_model")]
        public string vehiclesName_model { get; set; }
        [BsonElement("year")]
        public string vehiclesYear { get; set; }
        [BsonElement("price")]
        public string vehiclesPrice { get; set; }

        [BsonElement("rented")]
        public string vehiclesRented { get; set; }

        public Vehicles(string vehiclesType, string vehiclesName_model, string vehiclesYear, string vehiclesPrice, string vehiclesRented)
        {
            this.vehiclesType = vehiclesType;
            this.vehiclesName_model = vehiclesName_model;
            this.vehiclesYear = vehiclesYear;
            this.vehiclesPrice = vehiclesPrice;
            this.vehiclesRented = vehiclesRented;
        }
    }
}

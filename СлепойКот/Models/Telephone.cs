using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace СлепойКот.Models
{
    internal class Telephone 
    {
        [JsonPropertyName("Articul")]
        public int Articul { get; set; }

        [JsonPropertyName("NameTelephone")]
        public string NameTelephone { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("Cost")]
        public decimal Cost { get; set; }

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("Manufacturer")]
        public string Manufacturer { get; set; }

        public string Manuf
        {
            get { return Articul + " " + NameTelephone + " " + Category + " " + Cost + " " + Count + " " + Manufacturer + " "; }
        }
    }
}

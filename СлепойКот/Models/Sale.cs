using System;
using System.Threading;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace СлепойКот.Models
{
    internal class Sale
    {
        [JsonPropertyName("DateSale")]
        public DateTime DateSale { get; set; }

        [JsonPropertyName("Client")]
        public Client Client { get; set; }

        [JsonPropertyName("Telephones")]
        public List<Telephone> Telephones { get; set; }
        
    }
}

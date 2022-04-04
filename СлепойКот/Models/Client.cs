using System;
using System.Linq;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace СлепойКот.Models
{
    internal class Client
    {
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("Patronymic")]
        public string Patronymic { get; set; }

        public string FullName
        {
            get { return LastName + " " + FirstName.FirstOrDefault() + ". " + Patronymic.FirstOrDefault() + '.'; }
        }
    }
}

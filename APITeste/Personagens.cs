using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APITeste
{
    public class Personagens
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName ("name")]
        public string Name { get; set; }
        [JsonPropertyName ("species")]
        public string Species {  get; set; }
    }
}

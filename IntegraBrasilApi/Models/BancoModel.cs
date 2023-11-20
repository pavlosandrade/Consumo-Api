using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models{
    
    public class BancoModel{
        [JsonPropertyName("ispb")]
        public string? Isbp { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("code")]
        public int? Code { get; set; }

        [JsonPropertyName("fullname")]
        public string? FullName { get; set; }
    }
}
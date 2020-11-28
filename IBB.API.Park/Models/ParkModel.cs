using Newtonsoft.Json;

namespace IBB.API.Park.Models
{
    public class ParkModel
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public int ID { get; init; }

        /// <summary>
        /// Park adı
        /// </summary>
        [JsonProperty(PropertyName ="Parkin Adi")]
        public string Name { get; init; }
        
        /// <summary>
        /// Enlem
        /// </summary>
        [JsonProperty(PropertyName ="Sehir Rehberi Konum Bilgisi Enlem")]
        public decimal Latitude { get; init; }

        /// <summary>
        /// Boylam
        /// </summary>
        [JsonProperty(PropertyName ="Sehir Rehberi Konum Bilgisi Boylam")]
        public decimal Longitude { get; init; }

        /// <summary>
        /// Lokasyon link
        /// </summary>
        [JsonProperty(PropertyName ="Lokasyon Linki")]
        public string LocationUrl { get; init; }
    }
}

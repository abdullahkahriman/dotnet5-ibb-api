using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace IBB.API.Park.Models
{
    public class ParkBaseModel
    {
        [JsonProperty(PropertyName = "odata.metadata")]
        string OData { get; init; }

        [JsonProperty(PropertyName ="value")]
        public List<ParkModel> Park { get; init; }
    }
}
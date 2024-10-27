using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Book
{

    [JsonIgnore]
    public int PublishingHouseId { get; set; }
    [JsonPropertyName("Title")]
    public string Name { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
}

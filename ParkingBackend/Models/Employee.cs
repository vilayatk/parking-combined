using System.Text.Json.Serialization;

namespace ParkingBackend.Models
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public Team Team { get; set; }
    }
}

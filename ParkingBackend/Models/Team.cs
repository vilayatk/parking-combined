namespace ParkingBackend.Models
{
    public class Team
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        List<Employee> TeamMembers { get; set; } 
    }
}

namespace Rent_house.models
{
    public class City
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Id_Country { get; set; }

        public List<District>? Cities { get; set; }

        public City() 
        {
            Cities = new List<District>();
            
        }
    }
}

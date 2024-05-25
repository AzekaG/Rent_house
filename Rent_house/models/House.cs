namespace Rent_house.models
{
    public class House
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Price { get; set; }

        public string? Description { get; set; }


        public int? Area { get; set; }

        public int? CountRoom { get; set; }

        public int? CountFloor { get; set; }

        public int? Rating { get; set; }

        public DateTime? CreatedDate { get; set; }

        static public List<string>? Adittional_description { get; set; }

        public List<string>? Images_Path { get; set; }

        

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int District_id { get; set; }
        public int User_id { get; set; }

        public House() 
        {
            Adittional_description = new List<string>();
            Images_Path = new List<string>();

        }









    }
}

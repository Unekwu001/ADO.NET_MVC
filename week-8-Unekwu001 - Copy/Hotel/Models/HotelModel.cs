namespace Hotel.Models
{
    public class HotelModel
    {
        public HotelModel(int id, string? picURL, string? city, string? location, decimal? price, string? description, string? popularity,
            string hotelImageUrl2,string hotelImageUrl3, string hotelAboutDPlace, int bedRoom, int livingRoom, int bathRoom,int diningRoom,
            int mbps,int unitsReady,int refrigerator,int television)
        {
            Id = id;
            ImgURL = picURL;
            Name = city;
            Location = location;
            Price = price;
            Description = description;
            Popularity = popularity;
            HotelImageUrl2 = hotelImageUrl2;
            HotelImageUrl3 = hotelImageUrl3;
            HotelAboutDPlace = hotelAboutDPlace;
            BedRoom = bedRoom;
            LivingRoom = livingRoom;
            BathRoom = bathRoom;
            DiningRoom = diningRoom;
            Mbps = mbps;
            UnitsReady = unitsReady;
            Refrigerator = refrigerator;
            Television = television;
        }

        public int Id { get; set; }
        public string? ImgURL { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? Popularity { get; set; }
        public string? HotelImageUrl2 { get; set; }
        public string? HotelImageUrl3 { get; set; }
        public string?  HotelAboutDPlace { get; set; }
        public int BedRoom { get; set; }
        public int LivingRoom { get; set; }
        public int BathRoom  { get; set; }
        public int DiningRoom { get; set; }
        public int Mbps { get; set; }
        public int UnitsReady { get; set; }
        public int Refrigerator { get; set;}
        public int Television { get; set;}



    }
}

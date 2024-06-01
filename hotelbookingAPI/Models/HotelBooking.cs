namespace hotelbookingAPI.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public int RoomNumber {
            set;
            get;
        }
        public string? ClientsName { set; get; }
    }
}

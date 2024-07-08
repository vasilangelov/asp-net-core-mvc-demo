namespace Parking_Demo.Models
{
    public class RequestInputModel
    {
        public string VehicleNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ParkingId { get; set; }
    }
}

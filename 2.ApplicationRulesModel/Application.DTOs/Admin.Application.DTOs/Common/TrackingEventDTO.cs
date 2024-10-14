namespace Admin.Application.DTOs.Common
{
    public class TrackingEventDTO
    {
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public string User { get; set; }
        public string Status { get; set; }
    }
}
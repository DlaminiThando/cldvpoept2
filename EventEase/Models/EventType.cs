namespace EventEase.Models
{
    public class EventType
    {
        public int EventTypeID { get; set; }
        public string EventTypeName { get; set; }

        // Optional: Navigation property (if needed)
        public ICollection<Events>? Events { get; set; }
    }
}

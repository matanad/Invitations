using System.Text.Json.Serialization;

namespace backend.Models
{
    public enum OrderStatus
    {
        Pending,
        Approved,
        Rejected
    }
    public class Invitation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
        public bool IsExceptional { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
    }
}

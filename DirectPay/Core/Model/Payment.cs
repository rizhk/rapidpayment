namespace DirectPay.Core.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";


        public int UserId { get; set; }

        public User User { get; set; }

        // Add more properties as needed
    }
}     
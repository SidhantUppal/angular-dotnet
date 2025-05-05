namespace dotnet_angular.Server.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Method { get; set; }
    }
}

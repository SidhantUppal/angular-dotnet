namespace dotnet_angular.Server.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
        public ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
    }
}

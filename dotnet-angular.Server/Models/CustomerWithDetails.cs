namespace dotnet_angular.Server.Models
{
    public class CustomerWithDetails
    {
        public Customer Customer { get; set; } = new Customer();
        public List<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
        public List<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
    }
}

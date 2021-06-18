using System.Collections.Generic;
using System.ValueObjects;

namespace System.Domain
{
    public class Order {

        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public Client Client { get; private set; }
        public DateTime Initial { get; private set; }
        public DateTime Finish { get; private set; }
        public ShippingType ShippingType { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public string Observation { get; private set; }
        public ICollection<Order> Iten { get; private set; }
    }   
}
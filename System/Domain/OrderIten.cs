namespace System.Domain
{

    public class OrderIten {

        public int Id { get; private set; }
        public int OrderId { get; private set; }
        public Order Order { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Value { get; private set; }
        public decimal Discont { get; private set; }
    }
    
}
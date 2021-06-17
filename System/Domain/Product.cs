using System.ValueObjects;

namespace System.Domain
{
    public class Product {

        public int Id { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public string CodeBar { get; private set; }
        public ProductType ProductType { get; set; }
        public bool Active { get; private set; }

    }
}
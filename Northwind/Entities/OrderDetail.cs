namespace Northwind.Entities
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public override string ToString()
        {
            return $"OrderID: {OrderID}, ProductID: {ProductID}, UnitPrice: {UnitPrice:C}, Quantity: {Quantity}, Discount: {Discount:P}";
        }
    }
}

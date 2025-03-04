namespace Northwind.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipperID { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public override string ToString()
        {
            return $"OrderID: {OrderID}, CustomerID: {CustomerID}, EmployeeID: {EmployeeID}, OrderDate: {OrderDate}, RequiredDate: {RequiredDate}, ShippedDate: {ShippedDate}, ShipVia: {ShipperID}, Freight: {Freight}, ShipName: {ShipName}, ShipAddress: {ShipAddress}, ShipCity: {ShipCity}, ShipRegion: {ShipRegion}, ShipPostalCode: {ShipPostalCode}, ShipCountry: {ShipCountry}";
        }
    }
}

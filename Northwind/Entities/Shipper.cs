namespace Northwind.Entities
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"ShipperID: {ShipperID}, CompanyName: {CompanyName}, Phone: {Phone}";
        }
    }
}

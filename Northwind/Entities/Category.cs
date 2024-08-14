namespace Northwind.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"CategoryID: {CategoryID}, CategoryName: {CategoryName}, Description: {Description}";
        }
    }
}

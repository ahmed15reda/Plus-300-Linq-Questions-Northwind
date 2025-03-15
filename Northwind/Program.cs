using Northwind.Entities;
using System.Security.Cryptography;
using static Northwind.DataLists;
namespace Northwind
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Easy
            #region 1. Retrieve all products with a unit price greater than $50.
            //var products = Products.Where(x => x.UnitPrice > 50);

            //products = from product in Products
            //           where product.UnitPrice > 50
            //           select product;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. List the names of all customers from London.
            //var customers = Customers.Where(x => x.City == "London").Select(x => x.CompanyName);

            //customers = from customer in Customers
            //            where customer.City == "London"
            //            select customer.CompanyName;

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Find all orders shipped by "Speedy Express".
            //var orders = Orders.Join(Shippers,
            //                        order => order.ShipperID,
            //                        shipper => shipper.ShipperID,
            //                        (order, shipper) => new
            //                        {
            //                            Order = order,
            //                            Shipper = shipper
            //                        }).Where(x => x.Shipper.CompanyName == "Speedy Express").Select(x => x.Order);

            //orders = from order in Orders
            //         join shipper in Shippers
            //         on order.ShipperID equals shipper.ShipperID
            //         where shipper.CompanyName == "Speedy Express"
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total number of orders placed by customer "BONAP".
            //var count = Orders.Where(x => x.CustomerID == "BONAP").Count();
            //count = Orders.Count(x => x.CustomerID == "BONAP");

            //count = (from order in Orders
            //         where order.CustomerID == "BONAP"
            //         select order).Count();

            //Console.WriteLine(count);
            #endregion

            #region 5. List all employees who are managers.
            //var managers = Employees.Where(x => Employees.Any(e => e.ReportsTo == x.EmployeeID));

            //managers = from employee in Employees
            //           where Employees.Any(e => e.ReportsTo == employee.EmployeeID)
            //           select employee;

            //var managersIDs = Employees.Where(x => x.ReportsTo.HasValue)
            //    .Select(x => x.ReportsTo.Value).Distinct();

            //var managers = from e in Employees
            //               where managersIDs.Contains(e.EmployeeID)
            //               select e;

            //foreach (var item in managers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6. Find products that are discontinued.
            //var products = Products.Where(x => x.Discontinued);

            //products = from product in Products
            //           where product.Discontinued
            //           select product;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Retrieve the names and phone numbers of all suppliers.
            //var suppliers = Suppliers.Select(x => new { x.CompanyName, x.Phone });

            //suppliers = from supplier in Suppliers
            //            select new
            //            {
            //                supplier.CompanyName,
            //                supplier.Phone
            //            };

            //foreach (var item in suppliers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Get all orders placed in the year 1997.
            //var orders = Orders.Where(x => x.OrderDate.Year == 1997);

            //orders = from order in Orders
            //         where order.OrderDate.Year == 1997
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 9. Find all customers in the "USA".
            //var customers = Customers.Where(x => x.Country == "USA");

            //customers = from customer in Customers
            //            where customer.Country == "USA"
            //            select customer;

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10. List products that belong to category "Beverages".
            //var products = Products.Join(Categories,
            //                            p => p.CategoryID,
            //                            c => c.CategoryID,
            //                            (p, c) => new
            //                            {
            //                                Product = p,
            //                                Category = c
            //                            }).Where(x => x.Category.CategoryName == "Beverages")
            //                            .Select(x => x.Product);

            //products = from product in Products
            //           join category in Categories
            //           on product.CategoryID equals category.CategoryID
            //           where category.CategoryName == "Beverages"
            //           select product;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 11. Retrieve orders with a freight cost less than 20.
            //var orders = Orders.Where(x => x.Freight < 20);

            //orders = from order in Orders
            //         where order.Freight < 20
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 12. Get the names and titles of all employees.
            //var employees = Employees.Select(x => new { x.FirstName, x.LastName, x.Title });

            //employees = from employee in Employees
            //            select new { employee.FirstName, employee.LastName, employee.Title };

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 13. Find suppliers from "Germany".
            //var suppliers = Suppliers.Where(x => x.Country == "Germany");

            //suppliers = from supplier in Suppliers
            //            where supplier.Country == "Germany"
            //            select supplier;

            //foreach (var item in suppliers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 14. List all products with quantities between 10 and 50.
            //var products = Products.Where(x => x.UnitsInStock >= 10 && x.UnitsInStock <= 50);

            //products = from product in Products
            //           where product.UnitsInStock >= 10 && product.UnitsInStock <= 50
            //           select product;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 15. Retrieve orders that were shipped but not yet delivered.
            //var orders = Orders.Where(x => x.ShippedDate.HasValue && x.RequiredDate > DateTime.Now);

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 16. Get the total number of products in each category.
            //var products = Products.GroupBy(x => x.CategoryID)
            //                       .Select(group => new
            //                       {
            //                           CategoryId = group.Key,
            //                           Count = group.Count()
            //                       });

            //products = from product in Products
            //           group product by product.CategoryID into CatGroup
            //           select new
            //           {
            //               CategoryId = CatGroup.Key,
            //               Count = Categories.Count()
            //           };

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 17. List all orders placed by employee with ID 5.
            //var orders = Orders.Where(x => x.EmployeeID == 5);

            //orders = from order in Orders
            //         where order.EmployeeID == 5
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 18. Find the name of the supplier with the highest ID.
            //var supplier = Suppliers.FirstOrDefault(x => x.SupplierID == Suppliers.Max(x => x.SupplierID)).CompanyName;

            //supplier = Suppliers.OrderByDescending(x => x.SupplierID).Select(x => x.CompanyName).FirstOrDefault();

            //supplier = (from sup in Suppliers
            //            orderby sup.SupplierID descending
            //            select sup.CompanyName).FirstOrDefault();

            //Console.WriteLine(supplier);
            #endregion

            #region 19. Retrieve products that have "box" in their quantity per unit description.
            //var products = Products.Where(x => x.QuantityPerUnit.Contains("box"));

            //products = from product in Products
            //           where product.QuantityPerUnit.Contains("box")
            //           select product;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 20. List all customers from "Germany".
            //var customers = Customers
            //.Where(c => c.Country == "Germany")
            //.ToList();

            // customers = (from c in Customers
            //                            where c.Country == "Germany"
            //                            select c).ToList();

            #endregion

            #region 21. Find all products that have never been ordered.
            //var products = Products.Where(p => !OrderDetails.Any(od => od.ProductID == p.ProductID));

            //var products = Products.GroupJoin(OrderDetails,
            //                                p => p.ProductID,
            //                                od => od.ProductID,
            //                                (p, od) => new
            //                                {
            //                                    Product = p,
            //                                    Orders = od
            //                                }).Where(x => !x.Orders.Any())
            //                                .Select(x => x.Product);

            //products = from product in Products 
            //           join orderDetail in OrderDetails
            //           on product.ProductID equals orderDetail.ProductID into orderGroup
            //           where !orderGroup.Any()
            //           select product;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 22. Get all orders with a freight cost greater than 50.
            //var orders = Orders.Where(x => x.Freight > 50);

            //orders = from order in Orders
            //         where order.Freight > 50
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 23. Retrieve names of all categories.
            //var categories = Categories.Select(x => x.CategoryName);

            //categories = from category in Categories
            //             select category.CategoryName;

            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 24. List all orders where the ship city is "Mannheim".
            //var orders = Orders.Where(x => x.ShipCity == "Mannheim");

            //orders = from order in Orders
            //         where order.ShipCity == "Mannheim"
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 25. Find the employees who have "Sales" in their title.
            //var employees = Employees.Where(x => x.Title.Contains("Sales"));

            //employees = from employee in Employees
            //            where employee.Title.Contains("Sales")
            //            select employee;

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 26. Retrieve orders that were placed in the month of June.
            //var orders = Orders.Where(x => x.OrderDate.Month == 6);

            //orders = from order in orders
            //         where order.OrderDate.Month == 6
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 27. Get the names and phone numbers of suppliers from "Italy".
            //var suppliers = Suppliers.Where(x => x.Country == "Italy")
            //                         .Select(x => new { x.CompanyName, x.Phone });

            //suppliers = from supplier in Suppliers
            //            where supplier.Country == "Italy"
            //            select new { supplier.CompanyName, supplier.Phone };

            //foreach (var item in suppliers)
            //    Console.WriteLine(item);
            #endregion

            #region 28. List all products with unit prices less than 20.
            //var products = Products.Where(x => x.UnitPrice < 20);

            //products = from product in Products
            //           where product.UnitPrice < 20
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 29. Find orders that were shipped in 1997.
            //var orders = Orders.Where(x => x.ShippedDate.HasValue && x.ShippedDate.Value.Year == 1997);

            //orders = from order in Orders
            //         where order.ShippedDate.HasValue && order.ShippedDate.Value.Year == 1997
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 30. Retrieve the names of all customers who have placed more than 5 orders.
            //var customers = Orders.GroupBy(x => x.CustomerID)
            //                      .Where(group => group.Count() > 5)
            //                      .Select(x => x.Key)
            //                      .Join(Customers, 
            //                            customerId => customerId,
            //                            customer => customer.CustomerID,
            //                            (customerId, customer) => customer.CompanyName);

            //customers = from order in Orders
            //            group order by order.CustomerID into g
            //            where g.Count() > 5
            //            join customer in Customers
            //            on g.Key equals customer.CustomerID
            //            select customer.CompanyName;

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 31. List products with no quantity on order.
            //var products = Products.Where(x => x.UnitsOnOrder == 0);

            //products = from product in Products
            //           where product.UnitsOnOrder == 0
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 32. Get all categories with more than 5 products.
            //var categories = Products.GroupBy(x => x.CategoryID)
            //                         .Where(g => g.Count() > 5)
            //                         .Join(Categories ,
            //                                g => g.Key,
            //                                cat => cat.CategoryID,
            //                                (g, cat) => cat.CategoryName);

            //categories = from product in Products
            //             group product by product.CategoryID into g
            //             where g.Count() > 5
            //             join category in Categories
            //             on g.Key equals category.CategoryID
            //             select category.CategoryName;

            //foreach (var item in categories)
            //    Console.WriteLine(item);
            #endregion

            #region 33. Find the customer with the most recent order.
            //var customer = Orders.OrderByDescending(x => x.OrderDate)
            //                  .Select(x => Customers.FirstOrDefault(c => c.CustomerID == x.CustomerID))
            //                  .FirstOrDefault();

            //customer = (from order in Orders
            //            orderby order.OrderDate descending
            //            select Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID))
            //            .FirstOrDefault();

            //Console.WriteLine(customer);

            #endregion

            #region 34. Retrieve employees who work in "Sales".
            //var employees = Employees.Where(x => x.Title.Contains("Sales"));

            //employees = from employee in Employees
            //            where employee.Title.Contains("Sales")
            //            select employee;

            //foreach (var item in employees)
            //    Console.WriteLine(item);

            #endregion

            #region 35. List all products with a reorder level less than 10.
            //var products = Products.Where(x => x.ReorderLevel < 10);

            //products = from product in Products
            //           where product.ReorderLevel < 10
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 36. Find orders with a ship country of "UK" and a freight cost less than $20.
            //var orders = Orders.Where(x => x.ShipCountry == "UK" && x.Freight < 20);

            //orders = from order in Orders
            //         where order.ShipCountry == "UK" && order.Freight < 20
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 37. Get the names of suppliers who have a fax number.
            //var suppliers = Suppliers.Where(x => !string.IsNullOrEmpty(x.Fax))
            //                         .Select(x => x.CompanyName);

            //suppliers = from supplier in Suppliers
            //            where !string.IsNullOrEmpty(supplier.Fax)
            //            select supplier.CompanyName;

            //foreach (var item in suppliers)
            //    Console.WriteLine(item);
            #endregion

            #region 38. List all orders placed in the first quarter of 1998.
            //var orders = Orders.Where(x => x.OrderDate.Year == 1998 && x.OrderDate.Month <= 3);

            //orders = from order in Orders
            //         where order.OrderDate.Year == 1998 && order.OrderDate.Month <= 3
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 39. Retrieve products that have a unit price between $20 and $50.
            //var products = Products.Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50);

            //products = from product in Products
            //           where product.UnitPrice >= 20 && product.UnitPrice <= 50
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 40. Find customers who have a postal code starting with "9".
            //var customers = Customers.Where(x => x.PostalCode.StartsWith("9"));

            //customers = from customer in Customers
            //            where customer.PostalCode.StartsWith("9")
            //            select customer;

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 41. List all employees with their address details.
            //var employees = Employees.Select(x => new
            //{
            //    x.FirstName,
            //    x.LastName,
            //    x.Address,
            //    x.City,
            //    x.Region,
            //    x.PostalCode,
            //    x.Country
            //});

            //employees = from employee in Employees
            //            select new
            //            {
            //                employee.FirstName,
            //                employee.LastName,
            //                employee.Address,
            //                employee.City,
            //                employee.Region,
            //                employee.PostalCode,
            //                employee.Country
            //            };

            //foreach (var item in employees)
            //    Console.WriteLine(item);
            #endregion

            #region 42. Get all orders where the ship city is "London".
            //var orders = Orders.Where(x => x.ShipCity == "London");

            //orders = from order in Orders
            //         where order.ShipCity == "London"
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 43. Find all categories with at least one product in stock.
            //var categories = Categories.Where(x => Products.Any(p => p.CategoryID == x.CategoryID && p.UnitsInStock > 0));

            //categories = from category in Categories
            //             where Products.Any(p => p.CategoryID == category.CategoryID && p.UnitsInStock > 0)
            //             select category;

            //foreach (var item in categories)
            //    Console.WriteLine(item);
            #endregion

            #region 44. Retrieve the names and cities of customers who live in "USA".
            //var customers = Customers.Where(x => x.Country == "USA")
            //                         .Select(x => new { x.CompanyName, x.City });

            //customers = from customer in Customers
            //            where customer.Country == "USA"
            //            select new { customer.CompanyName, customer.City };

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 45. List products supplied by supplier with ID 10.
            //var products = Products.Where(x => x.SupplierID == 10);

            //products = from product in Products
            //           where product.SupplierID == 10
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 46. Find all orders where the ship name contains "snabbköp".
            //var orders = Orders.Where(x => x.ShipName.Contains("snabbköp"));

            //orders = from order in Orders
            //         where order.ShipName.Contains("snabbköp")
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 47. Get the details of products with more than 20 units in stock.
            //var products = Products.Where(x => x.UnitsInStock > 20);

            //products = from product in Products
            //           where product.UnitsInStock > 20
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 48. Retrieve all orders where the order date is in 1998.
            //var orders = Orders.Where(x => x.OrderDate.Year == 1998);

            //orders = from order in Orders
            //         where order.OrderDate.Year == 1998
            //         select order;

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 49. List all suppliers from "Canada" who have a phone number starting with "(416)".
            //var suppliers = Suppliers.Where(x => x.Country == "Canada" && x.Phone.StartsWith("(416)"));

            //suppliers = from supplier in Suppliers
            //            where supplier.Country == "Canada" && supplier.Phone.StartsWith("(416)")
            //            select supplier;

            //foreach (var item in suppliers)
            //    Console.WriteLine(item);

            #endregion

            #region 50. Find products that have been ordered more than 50 times.
            //var products = Products.Where(x => OrderDetails.Where(od => od.ProductID == x.ProductID).Sum(x => x.Quantity) > 50);

            //products = from product in Products
            //           where (from orderDetail in OrderDetails
            //                  where orderDetail.ProductID == product.ProductID
            //                  select orderDetail).Sum(x => x.Quantity) > 50
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 51. Get the names of all employees who are not managers
            //var employees = Employees.Where(x => x.ReportsTo != null)
            //                         .Select(x => new { x.FirstName, x.LastName });

            //employees = from employee in Employees
            //            where employee.ReportsTo != null
            //            select new { employee.FirstName, employee.LastName};

            //foreach (var item in employees)
            //    Console.WriteLine(item);
            #endregion

            #region 52. List orders where the ship country is "Mexico"
            //var orders = Orders.Where(x => x.ShipCountry == "Mexico");

            //orders = from order in Orders
            //         where order.ShipCountry == "Mexico"
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 53. Retrieve all products with a quantity per unit description containing "bottle"
            //var products = Products.Where(x => x.QuantityPerUnit.Contains("bottle"));

            //products = from product in Products
            //           where product.QuantityPerUnit.Contains("bottle")
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 54. Find the top 5 products with the highest unit price
            //var products = Products.OrderByDescending(x => x.UnitPrice)
            //                       .Take(5);

            //products = (from product in Products
            //           orderby product.UnitPrice descending
            //           select product).Take(5);

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 55. Get all customers who have a contact title of "Owner"
            //var customers = Customers.Where(x => x.ContactTitle == "Owner");

            //customers = from customer in Customers
            //            where customer.ContactTitle == "Owner"
            //            select customer;

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 56. List all employees who have their last name starting with "S"
            //var employees = Employees.Where(x => x.LastName.StartsWith("S"));

            //employees = from employee in Employees
            //            where employee.LastName.StartsWith("S")
            //            select employee;

            //foreach (var item in employees)
            //    Console.WriteLine(item);
            #endregion

            #region 57. Retrieve orders placed in the month of December
            //var orders = Orders.Where(x => x.OrderDate.Month == 12);

            //orders = from order in Orders
            //         where order.OrderDate.Month == 12
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 58. Find products that are neither discontinued nor have a reorder level of 0
            //var products = Products.Where(x => !x.Discontinued && x.ReorderLevel > 0);

            //products = from product in Products
            //           where !product.Discontinued && product.ReorderLevel > 0
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 59. Get the names of suppliers who have their country listed as "UK"
            //var suppliers = Suppliers.Where(x => x.Country == "UK")
            //                         .Select(x => x.CompanyName);

            //suppliers = from supplier in Suppliers
            //            where supplier.Country == "UK"
            //            select supplier.CompanyName;

            //foreach (var item in suppliers)
            //    Console.WriteLine(item);
            #endregion

            #region 60. List all orders with a ship city of "London" and a freight cost greater than $30
            //var orders = Orders.Where(x => x.ShipCity == "London" && x.Freight > 30);

            //orders = from order in Orders
            //         where order.ShipCity == "London" && order.Freight > 30
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 61. Retrieve all employees who were hired in 1997
            //var employees = Employees.Where(x => !string.IsNullOrEmpty(x.HireDate) && DateTime.Parse(x.HireDate).Year == 1997);

            //employees = from employee in Employees
            //            where !string.IsNullOrEmpty(employee.HireDate) && DateTime.Parse(employee.HireDate).Year == 1997
            //            select employee;

            //foreach (var item in employees)
            //    Console.WriteLine(item);
            #endregion
            ///////////////////
            #region 62. Find products that have been ordered by more than 10 different customers
            //var products = Products.Where(x =>
            //                Orders.Where(o => OrderDetails.Any(od => od.ProductID == x.ProductID))
            //                      .Select(o => o.CustomerID).Distinct().Count() > 10).Select(x => x.ProductID );

            //products = from product in Products
            //           where (from order in Orders
            //                  where OrderDetails.Any(od => od.ProductID == product.ProductID)
            //                  select order.CustomerID).Distinct().Count() > 10
            //           select product.ProductID;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 63. Get all categories that do not have any discontinued products
            //var categories = Categories.Where(x => !Products.Any(p => p.CategoryID == x.CategoryID && p.Discontinued));

            //categories = from category in Categories
            //             where !Products.Any(p => p.CategoryID == category.CategoryID && p.Discontinued)
            //             select category;

            //foreach (var item in categories)
            //    Console.WriteLine(item);
            #endregion

            #region 64. List all customers who have a region specified
            //var customers = Customers.Where(x => !string.IsNullOrEmpty(x.Region));

            //customers = from customer in Customers
            //            where !string.IsNullOrEmpty(customer.Region)
            //            select customer;

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 65. Retrieve products where the unit price is greater than the average unit price
            //var average = Products.Average(x => x.UnitPrice);

            //var products = Products.Where(x => x.UnitPrice > average);

            //products = from product in Products
            //           where product.UnitPrice > average 
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 66. Find the supplier with the most products
            //var supplierData = Products.GroupBy(x => x.SupplierID)
            //                        .OrderByDescending(g => g.Count())
            //                        .Select(g => new { SupplierId = g.Key, Count = g.Count() })
            //                        .FirstOrDefault();

            //supplierData = (from product in Products
            //               group product by product.SupplierID into g
            //               orderby g.Count() descending
            //               select new { SupplierId = g.Key, Count = g.Count() }).FirstOrDefault();

            //Console.WriteLine(supplierData);
            #endregion

            #region 67. Get all orders where the order date is after November 15, 1997
            //var orders = Orders.Where(x => x.OrderDate > new DateTime(1997, 11, 15));

            //orders = from order in Orders
            //         where order.OrderDate > new DateTime(1997, 11, 15)
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 68. List products with a unit price that is a multiple of 5
            //var products = Products.Where(x => x.UnitPrice % 5 == 0);

            //products = from product in Products
            //           where product.UnitPrice % 5 == 0
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 69. Retrieve the names of customers who have placed at least 3 orders
            //var customers = Customers.Where(x => Orders.Count(o => o.CustomerID == x.CustomerID) >= 3)
            //                         .Select(x => x.CompanyName);

            //customers = from customer in Customers
            //            where Orders.Count(o => o.CustomerID == customer.CustomerID) >= 3
            //            select customer.CompanyName;

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 70. Find all orders shipped by "United Package"
            //var orders = Orders.Where(x => Shippers.Any(s => s.ShipperID == x.ShipperID && s.CompanyName == "United Package"));

            //orders = from order in Orders
            //         where Shippers.Any(s => s.ShipperID == order.ShipperID && s.CompanyName == "United Package")
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 71. Get the details of orders that were shipped in "Berlin"
            //var orders = Orders.Where(x => x.ShipCity == "Berlin");

            //orders = from order in Orders
            //         where order.ShipCity == "Berlin"
            //         select order;

            //foreach (var item in orders)
            //    Console.WriteLine(item);
            #endregion

            #region 72. List products that have been discontinued and have a unit price greater than $20
            //var products = Products.Where(x => x.Discontinued && x.UnitPrice > 20);

            //products = from product in products
            //           where product.Discontinued && product.UnitPrice > 20
            //           select product;

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 73. Retrieve employees who have not shipped any orders
            //var employees = Employees.Where(x => !Orders.Any(o => o.EmployeeID == x.EmployeeID));

            //employees = from employee in Employees
            //            where !Orders.Any(o => o.EmployeeID == employee.EmployeeID)
            //            select employee;

            //foreach (var item in employees)
            //    Console.WriteLine(item);
            #endregion

            #region 74. Find customers who have orders with a discount applied
            //var customers = Customers.Where(x => Orders.Any(o => o.CustomerID == x.CustomerID
            //                && OrderDetails.Any(od => od.OrderID == o.OrderID && od.Discount > 0)));

            //customers = from customer in Customers
            //            where Orders.Any(o => o.CustomerID == customer.CustomerID
            //                && OrderDetails.Any(od => od.OrderID == o.OrderID && od.Discount > 0))
            //            select customer;

            //foreach (var item in customers)
            //    Console.WriteLine(item);
            #endregion

            #region 75. Get the top 3 most expensive products
            //var products = Products.OrderByDescending(x => x.UnitPrice)
            //                       .Take(3);

            //products = (from product in Products
            //           orderby product.UnitPrice descending
            //           select product).Take(3);

            //foreach (var item in products)
            //    Console.WriteLine(item);
            #endregion

            #region 76. List all suppliers with a home page
            #endregion

            #region 77. Retrieve orders where the freight cost is between $10 and $50
            #endregion

            #region 78. Find products supplied by a supplier with the name "Exotic Liquids"
            #endregion

            #region 79. Get all orders that were required before the order date
            #endregion

            #region 80. List products that have been ordered at least once in each year of the 1990s
            #endregion

            #region 81. Retrieve all orders where the ship city is "Seattle" or "Portland"
            #endregion

            #region 82. Find employees who have more than one phone number listed
            #endregion

            #region 83. Get the details of orders placed by the customer "ANATR"
            #endregion

            #region 84. List products with a quantity per unit description that includes "can"
            #endregion

            #region 85. Retrieve the names of all customers who have their contact name starting with "A"
            #endregion

            #region 86. Find all products with a unit price between $15 and $25
            #endregion

            #region 87. Get all orders that were shipped in the year 1997 but required before 1996
            #endregion

            #region 88. List all categories with at least one product that is not discontinued
            #endregion

            #region 89. Retrieve the names of suppliers who do not have a fax number
            #endregion

            #region 90. Find customers who live in cities starting with "S"
            #endregion

            #region 91. Get the total number of products for each supplier
            #endregion

            #region 92. List all orders where the freight cost is exactly $15
            #endregion

            #region 93. Retrieve employees who have a title containing "Manager"
            #endregion

            #region 94. Find products with a unit price that is not an integer
            #endregion

            #region 95. Get the names of all employees whose last name is "Davies"
            #endregion

            #region 96. List all orders shipped by "Federal Shipping"
            #endregion

            #region 97. Retrieve products with a unit price less than $25 and greater than $10
            #endregion

            #region 98. Find all customers with the same city as "Berlin"
            #endregion

            #region 99. Get the details of orders where the required date is within a week of the order date
            #endregion

            #region 100. List all products that have been ordered but have a quantity per unit of "6 boxes"
            #endregion


            #endregion Easy

            #region Medium

            #region List all products whose unit price is higher than the average unit price of all products.
            //var averageUnitPrice = Products.Average(x => x.UnitPrice);

            //var products = Products.Where(x => x.UnitPrice > averageUnitPrice).ToList();

            //foreach (var product in products)
            //    Console.WriteLine(product); 
            #endregion

            #region Retrieve the top 5 customers who have placed the highest number of orders.
            //var customers = (from customer in Customers
            //                 join order in Orders
            //                 on customer.CustomerID equals order.CustomerID
            //                 group order by customer.CustomerID
            //                /// For more clarifications you can group by ContactName also like below
            //                /// group order by new { customer.CustomerID, customer.ContactName }
            //                into CustomerGroup
            //                 orderby CustomerGroup.Count() descending
            //                 select new
            //                 {
            //                     /// if you have more than property at the group by clause 
            //                     /// you can read it as below
            //                     /// CustomerId = CustomerGroup.Key.CustomerId 
            //                     CustomerId = CustomerGroup.Key,
            //                     NumberOfOrders = CustomerGroup.Count()
            //                 }).Take(5);

            //foreach (var customer in customers)
            //    Console.WriteLine(customer); 
            #endregion

            #region Find all employees who have processed orders in more than 3 different countries.
            //var employees = Orders.GroupBy(x => new { x.EmployeeID, x.ShipCountry }).Select(x => new { x.Key.EmployeeID, x.Key.ShipCountry }).ToList();

            //foreach (var employee in employees)
            //    Console.WriteLine(employee);
            #endregion

            // Get the total number of orders shipped by each shipper.

            // List all products that have been ordered more than the average quantity ordered per product.

            // Retrieve the names of all customers who have ordered products from more than 5 different categories.

            // Find suppliers that have provided products in more than 3 different categories.

            // Get the details of the order with the maximum freight cost.

            // List all employees who have shipped orders to more than 10 different cities.

            // Retrieve all orders that were placed by customers from the same country as the employee who processed them.

            // Find the products that have the highest average discount applied.

            // Get the total number of products supplied by each supplier.

            // List all orders where the total freight cost exceeds the average freight cost of all orders.

            // Retrieve the names and addresses of all customers who have not placed any orders.

            // Find the employee with the most recent hire date.

            // Get all orders that were shipped on the same date they were ordered.

            // List all products with a unit price that is greater than the median unit price.

            // Retrieve the average freight cost for each shipper.

            // Find suppliers that have their contact title starting with "Sales".

            // Get the names of all customers who have ordered products with a unit price greater than $100.

            // List products that have a reorder level higher than the average reorder level of all products.

            // Retrieve the top 3 cities with the most customers.

            // Find orders that have a freight cost below the average freight cost for the year 1997.

            // Get the details of the orders shipped by "Speedy Express" in 1996.

            // List all products with a quantity per unit that contains the word "Pack".

            // Retrieve the names of employees who have processed orders in more than 2 different regions.

            // Find the supplier with the most products that have been ordered more than 50 times.

            // Get the total sales amount for each customer.

            // List all customers who have their postal code starting with "9" and have ordered products from more than 3 different categories.

            // Retrieve the average unit price of products in the "Beverages" category.

            // Find the product with the highest unit price and list its supplier details.

            // Get all orders that were placed by customers who have the same contact name as the employee who processed them.

            // List the names of customers and the number of orders they have placed in the year 1996.

            // Retrieve all products with a unit price greater than $30 and with quantities in stock less than the average.

            // Find all employees who have processed orders with a total freight cost above $100.

            // Get the total number of products in each category and list them in descending order.

            // List all orders where the total freight cost is above the average freight cost for orders shipped by "United Package".

            // Retrieve the names of suppliers who have provided products in the "Seafood" category.

            // Find all products that have been ordered in the last 6 months.

            // Get the names of customers who have ordered products supplied by more than 5 different suppliers.

            // List the total number of orders placed by each customer and sort by descending order count.

            // Retrieve employees who have shipped orders to cities in more than 3 different countries.

            // Find the products that are in stock but have never been ordered.

            // Get the total freight cost for each shipper and list them in ascending order.

            // List all categories that have at least one product with a unit price above the average for its category.

            // Retrieve the names and addresses of suppliers who have shipped products to "Paris".

            // Find the customers with the highest average order amount.

            // Get all products that have a unit price less than the average unit price and have never been discontinued.

            // List all orders where the shipping address is in a country that has more than 3 suppliers.

            // Retrieve the names of employees who have processed orders for products in the "Snacks" category.

            // Find the suppliers that have their company name containing the word "Deluxe".

            // Get the details of orders that were shipped to "Tokyo" and have a freight cost above the average.

            // List the products with the highest quantity ordered for each category.

            // Retrieve the names of customers who have not ordered any products from the "Seafood" category.

            // Find all employees who have shipped orders with a total freight cost of less than $20.

            // Get the total number of orders placed by each customer and filter for those with more than 10 orders.

            // List all products that are supplied by suppliers with the highest ID.

            // Retrieve the names and addresses of customers who have ordered products from more than 3 different categories.

            // Find the product with the lowest unit price and list its supplier details.

            // Get all orders where the order date is before the ship date.

            // List all suppliers who have provided products with a unit price above $50.

            // Retrieve the total freight cost for each order and list in descending order.

            // Find customers who have placed orders in every month of the year 1996.

            // Get the names of employees who have not shipped orders to "New York".

            // List all products with a quantity per unit containing the word "Bottle" or "Can".

            // Retrieve the names of suppliers who have a contact name containing "James".

            // Find all orders that were shipped with a freight cost above the average for orders shipped by "Federal Shipping".

            // Get the total number of products in stock for each category and sort in ascending order.

            // List all products that have a unit price higher than the average for their respective categories.

            // Retrieve the names of employees who have shipped orders to customers with a postal code starting with "9".

            // Find suppliers that have provided products with a unit price less than $25 and more than $50.

            // Get all orders that were placed in the month of July and shipped by "United Package".

            // List the top 5 cities with the highest number of shipped orders.

            // Retrieve the names and contact details of suppliers who have provided products in the "Confections" category.

            // Find all products that are currently out of stock but have been ordered in the past year.

            // Get the total number of products supplied by each supplier and list in descending order.

            // List all customers with a contact title of "Sales Representative" and who have ordered more than 3 products.

            // Retrieve the names of employees who have processed orders for the highest number of products.

            // Find the suppliers that have the same contact title as the employee with the most orders.

            // Get all orders that were shipped with a discount applied.

            // List the products with the highest quantity per unit and their respective suppliers.

            // Retrieve the names and addresses of customers who live in cities where the average order amount is above $200.

            // Find all products that have been ordered more than the average quantity ordered per product in the "Condiments" category.

            // Get the details of the orders that were shipped to "Berlin" and have a freight cost above $50.

            // List all categories with at least 10 products and sort by the total quantity of products in stock.

            // Retrieve the names of suppliers who have the highest number of products in the "Dairy Products" category.

            // Find all orders where the order date is within the first quarter of 1996 and the freight cost is less than $30.

            // Get the total sales amount for each employee and list them in descending order.

            // List all products with a unit price greater than the average price in their category and with a reorder level above 10.

            // Retrieve the names of customers who have placed orders in every month of 1997.

            // Find the products that have the highest quantity ordered and were supplied by suppliers from "Italy".

            // Get all orders where the ship city is "Seattle" and the order amount is greater than $100.

            // List all employees who have shipped products with a quantity greater than the average quantity ordered.

            // Retrieve the names of suppliers who have provided products with a unit price between $20 and $40.

            // Find the top 10 products with the highest total quantity ordered.

            // Get all orders where the required date is before the order date and the freight cost is below $25.

            // List the names and contact titles of suppliers who have shipped products in the "Seafood" category.

            // Retrieve the names of employees who have processed orders for more than 5 different categories.

            // Find all products that have been ordered by customers with a postal code starting with "1" and are in stock.

            // Get the total number of orders placed by customers from each city and list them in descending order.

            #endregion Medium

            #region Hard
            // Retrieve the top 5 customers who have the highest total order amount and list their order count.

            // Find the average discount applied to orders for each product category.

            // Get the names of employees who have shipped orders with a freight cost above the median freight cost of all orders.

            // List all products that are supplied by the supplier with the most products and have been ordered more than the average quantity.

            // Retrieve the top 3 categories with the highest average product unit price.

            // Find the customers who have ordered products from every category at least once.

            // Get the details of the order with the longest time between order date and required date.

            // List all suppliers who have not supplied products to any orders in the year 1996.

            // Retrieve the total number of products ordered for each product and compare it to the total stock quantity.

            // Find all products that have a reorder level equal to the maximum reorder level for their category.

            // Get the names of all customers who have ordered products from suppliers with more than 5 products.

            // List the employees who have processed orders for customers in more than 4 different countries.

            // Retrieve the names of categories where the average unit price of products is greater than the overall average unit price.

            // Find the suppliers who have provided products with a quantity per unit description that includes both "Box" and "Pack".

            // Get all orders where the total order amount is greater than the average order amount for the year 1997.

            // List products that have been ordered in every month of 1996 and have a unit price above $20.

            // Retrieve the names of customers who have placed orders in every year from 1995 to 1997.

            // Find all orders with a freight cost greater than the average freight cost of orders shipped by "Federal Shipping" and "United Package".

            // Get the total number of orders placed by customers who live in cities with more than 3 suppliers.

            // List all products that have been ordered by customers from more than 5 different regions.

            // Retrieve the names of employees who have shipped orders with the maximum discount applied.

            // Find the top 10 products that have been ordered the most in the last 6 months.

            // Get the details of orders where the ship country is the same as the supplier's country.

            // List all categories with products that have never been discontinued and have been ordered more than 10 times.

            // Retrieve the average quantity ordered for each product and compare it to the average stock quantity.

            // Find the customers who have ordered products from suppliers in at least 3 different countries.

            // Get all products that have a unit price within the range of the top 5 % most expensive products in their category.

            // List employees who have processed orders for products in every category.

            // Retrieve the total number of products ordered for each category and sort by descending total quantity.

            // Find the orders that have a ship city different from the customer’s city.

            // Get the details of the top 5 most recent orders and the names of the employees who processed them.

            // List all products with a unit price higher than the average unit price for their supplier.

            // Retrieve the names of suppliers who have a contact title of "Owner" and have provided products in the "Beverages" category.

            // Find the top 5 customers with the highest average order value and the number of orders they have placed.

            // Get all products that have been ordered in the last year and have a reorder level greater than the average reorder level.

            // List the employees who have processed orders for customers with a postal code starting with "9" and "8".

            // Retrieve the total order amount for each category and list them in descending order.

            // Find the suppliers who have not supplied products to any customers with orders in 1997.

            // Get the names of customers who have placed orders with products that have a unit price higher than the average unit price of products in their category.

            // List all products that have been ordered by customers from cities with the top 3 highest order counts.

            // Retrieve the names and contact titles of suppliers who have shipped products to "Paris" and "London".

            // Find all orders with a freight cost that is above the median freight cost and was shipped by "Speedy Express".

            // Get the top 5 products with the highest average discount applied and list their total quantity ordered.

            // List all employees who have shipped orders with a total freight cost above the average for the year 1996.

            // Retrieve the total number of products in stock for each category where the average unit price is above $30.

            // Find the customers who have placed orders with a discount applied and have ordered products from at least 4 different suppliers.

            // Get all products that have a unit price greater than the average for their supplier and have been ordered more than 10 times.

            // List all categories with products that have a reorder level equal to the average reorder level of products in their category.

            // Retrieve the names of suppliers who have provided products in the "Seafood" category and have a fax number.

            // Find the top 5 cities with the highest total order amount and list the number of customers in each city.

            // Get the details of orders where the ship name contains "Express" and the freight cost is above $40.

            // List the top 3 most expensive products in each category and retrieve their supplier details.

            // Retrieve the total number of orders placed by customers with a postal code starting with "1" and "2".

            // Find the products that have a quantity per unit description containing "Can" or "Pack" and have been ordered more than the median quantity.

            // Get the names of customers who have placed orders with products that have the highest total quantity ordered.

            // List all orders where the ship city is different from the customer’s city and the order amount is above the average.

            // Retrieve the names of employees who have shipped orders with a total quantity of products ordered above the average.

            // Find the top 10 products with the highest unit price that have been ordered in the last year.

            // Get the details of orders where the ship country is the same as the supplier’s country and the freight cost is above the average.

            // List all products that have been ordered by customers in cities with a total order amount greater than $1000.

            // Retrieve the names of suppliers who have provided products with a unit price less than $20 and more than $50.

            // Find the categories with products that have never been discontinued and have been ordered in every month of the last year.

            // Get the total number of orders for each category where the average order amount is greater than $200.

            // List all customers who have placed orders in every month of the last year and have a postal code starting with "1".

            // Retrieve the names of employees who have processed orders for the highest number of products and their total order amount.

            // Find the suppliers who have the highest number of products in categories where the average unit price is above $30.

            // Get all products that have a unit price higher than the median unit price in their category and have been ordered more than 20 times.

            // List all orders where the freight cost is above the average for the year 1997 and the order date is before the ship date.

            // Retrieve the top 5 customers with the highest average discount applied and their total order amount.

            // Find the products that have been ordered more than the average quantity ordered for their category and have a unit price above $25.

            // Get the names of suppliers who have provided products with a quantity per unit description containing "Bottle" and "Can".

            // List all employees who have shipped orders with a freight cost above the average and have processed orders for customers in more than 3 different countries.

            // Retrieve the total number of products in stock for each category where the reorder level is above the average for products in their category.

            // Find the customers who have placed orders for products in categories where the average quantity ordered is above 50.

            // Get all orders where the ship city is the same as the customer’s city and the order amount is above the median order amount.

            // List all categories with products that have a reorder level less than the average reorder level for their category and have been ordered more than 5 times.

            // Retrieve the names of suppliers who have provided products with a unit price within the range of the top 5 % most expensive products.

            // Find the top 10 cities with the most customers and list the total order amount for each city.

            // Get the details of orders where the ship country is "USA" and the order amount is greater than the average order amount for the year 1996.

            // List all products with a unit price greater than the average unit price in their category and have been ordered in the last 6 months.

            // Retrieve the names of employees who have shipped orders to customers with postal codes starting with "9" and "8" and have processed more than 20 orders.

            // Find the top 5 suppliers with the highest total quantity of products supplied and list their contact details.

            // Get all orders where the total order amount is greater than the average for orders shipped by "Speedy Express" and "United Package".

            // List all products that have been ordered in every year from 1995 to 1997 and have a reorder level higher than the average for their category.

            // Retrieve the names of suppliers who have provided products with a quantity per unit description containing "Pack" and "Box" and have a contact title starting with "Sales".

            // Find the customers who have placed orders with a discount applied and have ordered products from more than 5 different categories.

            // Get the total number of orders placed by customers who have ordered products in every month of the year 1997.

            // List all products with a unit price that is within the range of the average unit price plus one standard deviation for their category.

            // Retrieve the names of employees who have processed orders with the maximum number of products ordered and their total freight cost.

            // Find the top 3 categories with the highest total quantity of products ordered and list their average unit price.

            // Get all orders where the order amount is above the average for orders shipped by "Federal Shipping" and "Speedy Express".

            // List all suppliers who have shipped products to "London" and "Paris" and have provided products in the "Beverages" category.

            // Retrieve the names of customers who have ordered products from suppliers in more than 5 different countries.

            // Find the products that have been ordered more than the median quantity ordered and have a unit price above $30.

            // Get the total order amount for each employee and list them in descending order of the total amount.

            // List all categories with products that have a unit price higher than the median unit price for their category and have been ordered more than 10 times.

            // Retrieve the names of suppliers who have provided products with a quantity per unit description containing "Bottle" or "Pack" and have a fax number.

            // Find the top 5 products with the highest quantity ordered in the last year and their total order amount.

            // Get all orders where the ship country is "USA" and the order date is within the first quarter of 1997.

            // List all products that have a unit price within the range of the top 10 % most expensive products and have been ordered in every month of the last year.


            #endregion Hard


        }
    }
}
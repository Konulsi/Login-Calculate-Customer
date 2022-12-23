


using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

ICustomers customer = new Customers();


Customer customer1 = new Customer(1, "Chinare", "Ibadova", 22, "Developer");
Customer customer2 = new Customer(2, "Konul", "Ibrahimova", 27, "Developer");
Customer customer3 = new Customer(3, "Roya", "Meherremova", 27, "Developer");
Customer customer4 = new Customer(4, "Shaig", "Kazimov", 25, "Developer");
Customer customer5 = new Customer(5, "Javid", "Ismayilzadeh", 22, "Developer");
Customer customer6 = new Customer(6, "Alekber", "Hesenov", 36, "Developer");

Customer[] customers = { customer1, customer2, customer3, customer4, customer5, customer6 };


Console.WriteLine(customer.GetCustomersAgeAverage(customers));
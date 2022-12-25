


using DomainLayer.Models;
using ServiceLayer.Service;



Customer costomer = new Customer();

costomer.Name = "Aqsin";
costomer.Surname = "Hummatov";
costomer.Position = "Custumer";
costomer.Age = 25;


Customer costomer1 = new Customer();

costomer1.Name = "Aytac";
costomer1.Surname = "Asadova";
costomer1.Position = "Custumer";
costomer1.Age = 27;


Customer costomer2 = new Customer();

costomer2.Name = "Nazrin";
costomer2.Surname = "Abbasova";
costomer2.Position = "Customer";
costomer2.Age = 26;




Customer[] result = new Customer[] { costomer, costomer1, costomer2 };



Customers costumers = new Customers();

Console.WriteLine(costumers.GetAge(result));
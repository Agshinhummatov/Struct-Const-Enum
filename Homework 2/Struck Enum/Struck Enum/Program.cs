
using Struck_Enum;
using Struck_Enum.Constants;


//Test test = new Test();

//test.Number= 1;

//Console.WriteLine(test.Number);


//Employee employee = new Employee("Aqshin", "Hummatov", 27, "Xirdalan");

////Console.WriteLine(employee);


//Console.WriteLine();

//static Employee GetEmployee(Employee employee)
//{
//    return employee;

//}


using Struck_Enum.Constants;
using Struck_Enum.Enums;
using System.Data;

//string email = "ff@gamil.com";



//if (email != "ff@gamil.com")
//{

//    Console.WriteLine(Errors.NotFound);

//}


//int roleId = 1;

//if (roleId == (int) Roles.SuperAdmin)
//{
//    Console.WriteLine("Super Admin");
//}



//int roleId = 1;

//switch (roleId)
//{
//	case (int)Roles.SuperAdmin:
//		Console.WriteLine("Super admindir");
//		break;
//	case (int)Roles.Admin:
//		Console.WriteLine("Admin");
//		break;
//    case (int)Roles.Member:
//        Console.WriteLine("Memberdir");
//        break;
//	default:
//		Console.WriteLine("Role tapilmadi");
//		break;
		 

//}


string[] names = Enum.GetNames(typeof(Roles));

string inputData = "Admin";

foreach (var item in names)
{
	if (inputData == item)
	{
		Console.WriteLine($"user role is - {item}");
	}
}
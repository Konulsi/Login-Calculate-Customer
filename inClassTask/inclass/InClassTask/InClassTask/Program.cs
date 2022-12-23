


//using InClassTask.Enums;
//using InClassTask.Helpers;

//int a = 4;

//Console.WriteLine(a.GetNum(4,8));



//int[] arr = { 1, 2, 3, }; //6

//Console.WriteLine(arr.GetNumPower(2));



//using InClassTask.Enums;

//int dayId = 1;

//switch (dayId)
//{
//	case (int)WeekDays.Monday:  
//        Console.WriteLine("The day is Monday");
//		break;
//	case (int)WeekDays.Tuesday:
//		Console.WriteLine("The day is Tuesday ");
//		break;
//    case (int)WeekDays.Wednesday:
//        Console.WriteLine("The day is Wednesday ");
//        break;
//    case (int)WeekDays.Thursday:
//        Console.WriteLine("The day is Thursday ");
//        break;
//    case (int)WeekDays.Friday:
//        Console.WriteLine("The day is Friday ");
//        break;
//    case (int)WeekDays.Saturday:
//        Console.WriteLine("The day is Saturday ");
//        break;
//    case (int)WeekDays.Sunday:
//        Console.WriteLine("The day is Sunday ");
//        break;
//    default:
//        Console.WriteLine("The day is not found");
//        break;
//}



//using InClassTask;

//Test test = new Test();

//test.MyProperty = 1;

//Console.WriteLine(test.MyProperty);


//using InClassTask;
//using InClassTask.Helpers.Constants;
//using System.Data;

//Employee employee = new Employee("Mirze" , "Beshirzade" , 26, "Bulbule");

//Console.WriteLine(GetEmployee(employee));


//static Employee GetEmployee(Employee employee)
//{
//    return employee;
//}


//string email = "ff@gmail.com";
//if (email != "tt@gmail.com")
//{
//    Console.WriteLine(Errors.LoginMessage);


//}


//using InClassTask.Enums;

//int roleId = 2;

//switch (roleId)
//{
//	case (int)Roles.SuperAdmin:
//		Console.WriteLine("Super Admindir");
//		break;
//    case (int)Roles.Admin:
//        Console.WriteLine("Admindir");
//        break;
//    case (int)Roles.Member:
//        Console.WriteLine("Member");
//        break;
//    default:
//        Console.WriteLine("Role tapilmadi");
//		break;
//}


//using InClassTask.Enums;

//using InClassTask.Enums;

//string[] names = Enum.GetNames(typeof(Roles));

//string InputData = "Admin";

//foreach (var item in names)
//{
//	if (InputData == item)
//	{

//		Console.WriteLine($"User role is - {item}");
//		break;
//	}
//}


//int[] result = (int[])Enum.GetValues(typeof(Roles));

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
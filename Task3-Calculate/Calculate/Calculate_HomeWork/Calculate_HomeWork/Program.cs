


using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

int[] arr = { 1, 3, 4, 5, 6, 20, 23 };


ICalculateService calculateService = new CalculateService();

var result = calculateService.GetArrNumsMultiple(arr);
Console.WriteLine(result);


var result1 = calculateService.GetArrNumsSumPow(arr,2);
Console.WriteLine(result1);

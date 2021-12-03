// See https://aka.ms/new-console-template for more information

// 1 евро = 1.94лв

const double course = 1.94;
//input
double vegePrice = double.Parse(Console.ReadLine());
double fruitPrice = double.Parse(Console.ReadLine());
int vegeKg = int.Parse(Console.ReadLine());
int fruitKg = int.Parse(Console.ReadLine());



//calc profit
double totalPrice = vegeKg * vegePrice + fruitPrice * fruitKg;
totalPrice /= course; //profit in euro



//output
Console.WriteLine($"{totalPrice:F2}");

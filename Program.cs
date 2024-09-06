const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip= 0;

System.Console.WriteLine("How many sandwiches would you like?");
numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings would you like?");
numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("Please enter tip amount (write as a decimal)");
tip = double.Parse(Console.ReadLine());

double totalSandwichCost = 0;
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;

double totalToppingCost = 0;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;

double baseCost = 0;
baseCost = totalSandwichCost + totalToppingCost;

double orderCost = 0;
orderCost = tip + baseCost*(1 - DISCOUNT_AMOUNT);

System.Console.WriteLine("Your total cost is " + orderCost);

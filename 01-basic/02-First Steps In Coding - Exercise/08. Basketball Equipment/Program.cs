int annualTax = int.Parse(Console.ReadLine());

double snickers = annualTax * .6;
double outfit = snickers * .8;
double ball = outfit / 4;
double accessories = ball / 5;

double total = annualTax + snickers + outfit + ball + accessories;

Console.WriteLine(total);
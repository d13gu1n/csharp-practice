// Activity 1

Console.WriteLine("Hello, World!");
// Console.Write("Congratulations!");
// Console.Write(" ");
// Console.Write("You wrote your first lines of code.");
Console.WriteLine("Congratulations");
Console.Write("Your wrote your first lines of code.");
Console.WriteLine("");
Console.WriteLine("bello na");
Console.WriteLine('b');
Console.WriteLine(123);
Console.WriteLine(0.25f);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

Console.WriteLine("This is the first line.");
Console.Write("This is the second line.");

// End of Activity 1

Console.WriteLine("");
Console.WriteLine("");

// Activity 2

string firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

var message = "Hello World!";

string name = "Bob";
int chalNumber = 3;
float chalDecimal = 34.4f;
Console.Write("Hello, " + name + "!");
Console.Write(" ");
Console.Write("You have " + chalNumber + " messages in your inbox.");
Console.Write(" ");
Console.Write("The temperature is " + chalDecimal + " celsius.");

// Activity 3

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\"... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");

Console.WriteLine(@"c:\invoices");
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World");

Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

string firstNameAct3 = "Bob";
string messageAct3 = "Hello " + firstNameAct3;
Console.WriteLine(messageAct3);
string greetingAct3 = "Hello";
string messageAct3_2 = greetingAct3 + " " + firstNameAct3 + "!";
Console.WriteLine(messageAct3_2);
Console.WriteLine(greetingAct3 + " " + firstNameAct3 + "!");

int version = 11;
string updateText = "Update to Windows";
string messageAct3_3 = $"{updateText} {version}";
Console.WriteLine(messageAct3_3);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectNameAct3_4 = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string firstMessage = "View English output: ";
Console.WriteLine($"{firstMessage}\n  c:\\Exercise\\{projectNameAct3_4}\\data.txt\n");
Console.WriteLine($"{russianMessage}: \n  c:\\Exercise\\{projectNameAct3_4}\\ru-RU\\data.txt");

// Activity 4

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName_Act4 = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName_Act4 + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName_Act4 + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName_Act4 + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotientEx1 = 7.0m / 5;
Console.WriteLine($"Decimal quotient 1: {decimalQuotientEx1}");
decimal decimalQuotientEx2 = 7 / 5.0m;
Console.WriteLine($"Decimal quotient 2: {decimalQuotientEx2}");
decimal decimalQuotientEx3 = 7.0m / 5.0m;
Console.WriteLine($"Decimal quotient 3: {decimalQuotientEx3}");

int first = 7;
int second = 5;
decimal quotient_Act4 = (decimal)first / (decimal)second;
Console.WriteLine(quotient_Act4);

Console.WriteLine($"Modulus of 200 / 5: {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5: {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int value3 = 0;
value3 = value3 + 5;
Console.WriteLine($"Value: {value3}");
value3 += 5;
Console.WriteLine($"Value: {value3}");

int value4 = 0;
value4 = value4 + 1;
Console.WriteLine($"Value: {value4}");
value4++;
Console.WriteLine($"Value: {value4}");

int value5 = 1;
value5 = value5 + 1;
Console.WriteLine("First increment: " + value5);
value5 += 1;
Console.WriteLine("Second increment: " + value5);
value5++;
Console.WriteLine("Third increment: " + value5);
value5 = value5 - 1;
Console.WriteLine("First decrement: " + value5);
value5 -= 1;
Console.WriteLine("Second decrement: " + value5);
value5--;
Console.WriteLine("Third decrement: " + value5);

int value6 = 1;
value6++;
Console.WriteLine("First: " + value6);
Console.WriteLine($"Second: {value6++}");
Console.WriteLine("Third: " + value6);
Console.WriteLine("Fourth: " + (++value6));

int fahrenheit = 94;
Console.WriteLine($"The temperature is {(fahrenheit - 32m)* (5m / 9m)} Celsius");
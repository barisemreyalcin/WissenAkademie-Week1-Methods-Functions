// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region METHODS
// Program akışı içerisinde bir kod parçasını defalarca kullanacaksak method oluşturarak kod tekrarını önleriz. Az ve clean code

// Methodlar 2'ye ayrılır:

// 1. Değer döndürmeyen methodlar (void)
// 1.1 Parametreli methodlar
// 1.2 Parametresiz methodlar

// 2. Değer döndüren methodlar/functionlar (int, bool, string, double, ... etc)
// 2.1 Parametreli methodlar
// 2.2 Parametresiz methodlar

#region METHODS (VOID) (NO PARAMETERS)
// 1.1 Değer döndürmeyen methodlar (void) (parametresiz)
//SumTwoNumbers();

//void SumTwoNumbers()
//{
//    int num1, num2;
//    Random randomNum = new Random();
//    num1 = randomNum.Next(0, 10);
//    num2 = randomNum.Next(0, 10);
//    int sum = num1 + num2;
//    Console.WriteLine($"Sum: {sum}");
//}
#endregion

#region METHODS (FUNCTIONS) (NO PARAMETERS)
// 2. Değer döndüren methodlar/functionlar (parametresiz)
// Dönüş tipini başa eklersin

//int sum = sumTwoNumbers();
//Console.WriteLine($"Sum: {sum}");

//int sumTwoNumbers()
//{
//    int num1, num2;
//    int sum = 0;
//    Random randomNum = new Random();
//    num1 = randomNum.Next(1, 20);
//    num2 = randomNum.Next(1, 15);
//    sum = num1 + num2;
//    return sum;
//}
#endregion

#region METHODS (VOID) (WITH PARAMETERS)

//Console.Write("Enter 1st number: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("Enter 2nd number: ");
//int num2 = int.Parse(Console.ReadLine());

//Console.Write("Enter 3rd number: ");
//int num3 = int.Parse(Console.ReadLine());

//sumThreeNumbers(num1, num2, num3);

//void sumThreeNumbers(int num1, int num2, int num3)
//{
//    int sum = num1 + num2 + num3;
//    Console.WriteLine($"Sum: {sum}");
//}
#endregion

#region METHODS (FUNCTIONS) (WITH PARAMETERS)

//Console.Write("Enter 1st number: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Enter 2st number: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Enter 3st number: ");
//int num3 = int.Parse(Console.ReadLine());

//int sum = sumThreeNumbers(num1, num2, num3);
//Console.WriteLine($"Sum: {sum}");

//int sumThreeNumbers(int num1, int num2, int num3)
//{
//    int sum = num1 + num2 + num3;
//    return sum;
//}
#endregion

#region METHODS (FUNCTIONS) (WITH PARAMETERS) (RETURNS DIFFERENT TYPE FROM INPUT TYPE)

//string strSum = sumTwoFloatNums(15.6F, 14.2F);
//Console.WriteLine(strSum);

//string sumTwoFloatNums(float num1, float num2)
//{
//    string strSum = String.Empty;
//    float sum = num1 + num2;
//    strSum = $"Sum: {sum.ToString()}";
//    return strSum;
//}
#endregion

#region METHODS WITH DEFAULT (OPTIONAL) PARAMETERS

//Console.Write("Enter your name: ");
//string userName = Console.ReadLine();
//Console.Write("Enter your age: ");
//int age = int.Parse(Console.ReadLine());
//Console.Write("Enter your number of friends: ");
//int friendsNum = int.Parse(Console.ReadLine());

//welcomeUser(age, userName, friendsNum);
//welcomeUser(age);

//void welcomeUser(int age, string? userName = "user", int? friendsNum = 0)
//{
//    string welcomeMsg = $"Welcome, {userName}({age})! You have {friendsNum} friends.";
//    Console.WriteLine(welcomeMsg);
//}

//*************** CHATGPT EXAMPLE

//Console.Write("Enter your name: ");
//string userName = Console.ReadLine();

//Console.Write("Enter your age: ");
//bool ageParsed = int.TryParse(Console.ReadLine(), out int age);
//if (!ageParsed)
//{
//    Console.WriteLine("Invalid input for age. Setting age to default value 0.");
//    age = 0; // Veya uygun bir varsayılan değer
//}

//Console.Write("Enter your number of friends: ");
//bool friendsNumParsed = int.TryParse(Console.ReadLine(), out int friendsNum);
//if (!friendsNumParsed)
//{
//    Console.WriteLine("Invalid input for number of friends. Setting number of friends to default value 0.");
//    friendsNum = 0; // Veya uygun bir varsayılan değer
//}

//void welcomeUser(int age, string? userName = "user", int friendsNum = 0)
//{
//    string welcomeMsg = $"Welcome, {userName}({age})! You have {friendsNum} friends.";
//    Console.WriteLine(welcomeMsg);
//}

//// Kullanım örnekleri
//welcomeUser(age, userName, friendsNum); // "Welcome, {userName}({age})! You have {friendsNum} friends."
//welcomeUser(age); // "Welcome, user({age})! You have 0 friends."

//*************** CHATGPT EXAMPLE

// PERIMETER OF A CIRCLE

//Console.Write("Enter a radius: ");
//int radius = int.Parse(Console.ReadLine());
//double perimeter = calcPerimeter(radius);
//Console.WriteLine("Perimeter: " + perimeter);
//Console.WriteLine("Perimeter: " + calcPerimeter(radius, Math.PI));

//double calcPerimeter(int radius, double pi = 3)
//{
//    double perimeter =  2 * pi * radius;
//    return perimeter;
//}

#endregion

#region METHODS WITH PARAMS KEYWORD
// Belirsiz sayıda parametre alan methodlar
// Parametrelerin veri tipleri aynı olmalıdır
// Diğer parametrelerden sonra kullanılmalı
// Birden fazla params kullanamazsın

//int totalPrice1 = calcTotalPrice(100, 200, 250, 450, 820, 525);
//int totalPrice2 = calcTotalPrice(100, 200, 250, 450);
//Console.WriteLine($"Total price: ${totalPrice1}");
//Console.WriteLine($"Total price: ${totalPrice2}");
//int calcTotalPrice(params int[] prices)
//{
//    int totalPrice = 0;
//    foreach (int price in prices)
//    {
//        totalPrice += price;
//    }
//    return totalPrice;
//}

#endregion

#region EXAMPLES

#region ODD-EVEN
// Kullanıcıdan alınan sayının tek veya çift olma durumunu kontrol eden function:

//Console.Write("Enter a number: ");
//int num = int.Parse(Console.ReadLine());

//bool isEven = IsEven(num);
//Console.WriteLine($"{num} is an {(isEven ? "even" : "odd")} number");

//bool IsEven(int num)
//{
//    bool isEven = false;
//    if (num % 2 == 0) isEven = true;
//    return isEven;
//}

#endregion

#region PRIME NUMBER
// Bir sayının asal mı olduğunu kontrol eden method
//Console.Write("Enter a number: ");
//int num = int.Parse(Console.ReadLine());
//bool isPrimeNum = CheckIsPrimeNum(num);
//Console.WriteLine($"{num} is{(isPrimeNum ? "" : " not")} a prime number");

//bool CheckIsPrimeNum(int num)
//{
//    if (num <= 1) return false;

//    if (num <= 3) return true;

//    if (num % 2 == 0 || num % 3 == 0) return false;

//    for (int i = 5; i * i <= num; i+=6)
//    {
//        if (num % i == 0 || num % (i + 2) == 0) return false;
//    }

//    return true;
//}
#endregion

#endregion

#region METHODS WITH MULTIPLE RETURNS (ref - out KEYWORDS)

#region OUT
// Eğer bir method void ise değer döndürmesi için ya da bir methodun birden fazla değer döndürmesi için kullanılır

// *****************************************************************************

//int quotient, remainder;
//Division(17, 5 , out quotient, out remainder);
//Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");

//void Division(int dividend, int divisor, out int quotient, out int remainder)
//{
//    quotient = dividend / divisor;
//    remainder = dividend % divisor;
//}

// *****************************************************************************

//int quotient, remainder;
//quotient = Divison(17, 5, out remainder);
//Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");

//int Divison(int dividend, int divisor, out int remainder)
//{
//    remainder = dividend % divisor;
//    return dividend / divisor;
//}
// *****************************************************************************

#endregion

#region REF
// Bir methodun birden fazla değer döndürmesine olanak tanır.
// Out keyword'ünde out ile pass edilen değişkende mutlaka bir değişiklik yapmamı şart koşar. Yani kullanmamız gerekir. Ama ref'te böyle bir zorunluluk yok.
// Bir diğer farklılık: ref'te initial değer vermem gerekir. (num1, num2) Ama yukarda out için bunu yapmamız şart değildi, incele. (quotient, remainder)

//int num1 = 8, num2 = 24;
//Console.WriteLine($"Before calling method with ref: {num1} and {num2}");
//changeValues(ref num1, ref num2);
//Console.WriteLine($"After calling method with ref: {num1} and {num2}");

//void changeValues(ref int num1, ref int num2)
//{
//    int temp = num1;
//    num1 = num2;
//    num2 = temp;
//}
#endregion

#endregion

#endregion
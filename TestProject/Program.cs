// int num = new Random().Next(1, 101);
// Console.WriteLine($"Generated number: {num}");



// string result = (num % 2 == 0) ? "Head" : "Tail";
// Console.WriteLine($"The result is: {result}");

// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");


// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// bool flag = true;
// int value = 0;

// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// int value;
// value = 10;
// Console.WriteLine($"Inside the code block: {value}");
// Console.WriteLine($"Outside the code block: {value}");

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");





// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }

// if (found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {   
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }       



// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// for(int i = 1; i <= 100; i++)
//     if (i%3 == 0 && i%5 == 0) Console.WriteLine(i + " - FizzBuzz");
//     else if (i%3 == 0) Console.WriteLine(i +" - Fizz");
//     else if (i%5 == 0) Console.WriteLine(i +" - Buzz");
//     else Console.WriteLine(i);

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);



// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) * int.Parse(second);
// Console.WriteLine(sum);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);


// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal total = 0m;
// string message = "";

// foreach (string value in values)
// {
//     decimal result;
//     // Console.WriteLine($"Processing \"{value}\"...");

//    if (decimal.TryParse(value, out result))
//    {
//     total += result;
//    }
//    else
//    {
//     message += value;
//    }

// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");


// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// string[] pallets =  ["B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] items = pangram.Split(' ');
// string[] newMessage = new string[items.Length];

// int i = 0;
// foreach (string item in items)
// {
//     char[] valueArray = item.ToCharArray();
//     Array.Reverse(valueArray);
//     newMessage[i] = new string(valueArray);
//     i++;
// }
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] items = orderStream.Split(',');
// Array.Sort(items);

// foreach (var item in items)
// {
//     if (item.Length == 4)
//     {
//         Console.WriteLine(item);
//     }
//     else
//     {
//         Console.WriteLine(item + "\t- Error");
//     }
// }



// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);

//  Console.WriteLine("1234567890123456789012345678901234567890");
//  Console.WriteLine(formattedLine);

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);







// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }


// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     } 
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }



// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// TellFortune();

// void TellFortune() 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }





// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }


// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
// {
//     if (inviteOnly)
// {
//     bool found = false;
//     foreach (string guest in guestList)
//     {
//         if (guest.Equals(name)) {
//             found = true;
//             break;
//         }
//     }
//     if (!found)
//     {
//         Console.WriteLine($"Sorry, {name} is not on the guest list");
//         return;
//     }
// }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }



// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();



	// string[,] corporate = 
	// {
	// 	{"Robert", "Bavin"}, {"Simon", "Bright"},
	// 	{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
	// 	{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	// string[,] external = 
	// {
	// 	{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
	// 	{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	// };

	// string externalDomain = "hayworth.com";

	// for (int i = 0; i < corporate.GetLength(0); i++) 
	// {
	// 	DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	// }

	// for (int i = 0; i < external.GetLength(0); i++) 
	// {
	// 	DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	// }

    // void DisplayEmail(string first, string last, string domain = "contoso.com") 
	// {
	// 	string email = first.Substring(0, 2) + last;
	// 	email = email.ToLower();
	// 	Console.WriteLine($"{email}@{domain}");
	// }




// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }



// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }

// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word) 
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end) 
//     {
//         if (word[start] != word[end]) 
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }


// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {    
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }


// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// bool ShouldPlay() 
// {
//     string response = Console.ReadLine();
//     return response.ToLower().Equals("y");
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) {
//         var target = GetTarget();
//         var roll = RollDice();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int GetTarget() 
// {
//     return random.Next(1, 6);
// }

// int RollDice() 
// {
//     return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target) 
// {
//     if (roll > target) 
//     {
//         return "You win!";
//     }
//     return "You lose!";
// }


// using System;

// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6) 
// {
//     RandomizeAnimals(); 
//     string[,] group = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group);
// }

// void RandomizeAnimals() 
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++) 
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }

// string[,] AssignGroup(int groups = 6) 
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] groups) 
// {
//     for (int i = 0; i < groups.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < groups.GetLength(1); j++) 
//         {
//             Console.Write($"{groups[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }




// using System;

// Random random = new Random();
// Console.CursorVisible = false;
// int height = Console.WindowHeight - 1;
// int width = Console.WindowWidth - 5;
// bool shouldExit = false;

// // Console position of the player
// int playerX = 0;
// int playerY = 0;

// // Console position of the food
// int foodX = 0;
// int foodY = 0;

// // Available player and food strings
// string[] states = {"('-')", "(^-^)", "(X_X)"};
// string[] foods = {"@@@@@", "$$$$$", "#####"};

// // Current player string displayed in the Console
// string player = states[0];

// // Index of the current food
// int food = 0;

// InitializeGame();
// while (!shouldExit) 
// {
//     if (TerminalResized()) 
//     {
//         Console.Clear();
//         Console.Write("Console was resized. Program exiting.");
//         shouldExit = true;
//     } 
//     else 
//     {
//         if (PlayerIsFaster()) 
//         {
//             Move(1, false);
//         } 
//         else if (PlayerIsSick()) 
//         {
//             FreezePlayer();
//         } else 
//         {
//             Move(otherKeysExit: false);
//         }
//         if (GotFood())
//         {
//             ChangePlayer();
//             ShowFood();
//         }
//     }
// }

// // Returns true if the Terminal was resized 
// bool TerminalResized() 
// {
//     return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
// }

// // Displays random food at a random location
// void ShowFood() 
// {
//     // Update food to a random index
//     food = random.Next(0, foods.Length);

//     // Update food position to a random location
//     foodX = random.Next(0, width - player.Length);
//     foodY = random.Next(0, height - 1);

//     // Display the food at the location
//     Console.SetCursorPosition(foodX, foodY);
//     Console.Write(foods[food]);
// }

// // Returns true if the player location matches the food location
// bool GotFood() 
// {
//     return playerY == foodY && playerX == foodX;
// }

// // Returns true if the player appearance represents a sick state
// bool PlayerIsSick() 
// {
//     return player.Equals(states[2]);
// }

// // Returns true if the player appearance represents a fast state
// bool PlayerIsFaster() 
// {
//     return player.Equals(states[1]);
// }

// // Changes the player to match the food consumed
// void ChangePlayer() 
// {
//     player = states[food];
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Temporarily stops the player from moving
// void FreezePlayer() 
// {
//     System.Threading.Thread.Sleep(1000);
//     player = states[0];
// }

// // Reads directional input from the Console and moves the player
// void Move(int speed = 1, bool otherKeysExit = false) 
// {
//     int lastX = playerX;
//     int lastY = playerY;
    
//     switch (Console.ReadKey(true).Key) {
//         case ConsoleKey.UpArrow:
//             playerY--; 
//             break;
// 		case ConsoleKey.DownArrow: 
//             playerY++; 
//             break;
// 		case ConsoleKey.LeftArrow:  
//             playerX -= speed; 
//             break;
// 		case ConsoleKey.RightArrow: 
//             playerX += speed; 
//             break;
// 		case ConsoleKey.Escape:     
//             shouldExit = true; 
//             break;
//         default:
//             // Exit if any other keys are pressed
//             shouldExit = otherKeysExit;
//             break;
//     }

//     // Clear the characters at the previous position
//     Console.SetCursorPosition(lastX, lastY);
//     for (int i = 0; i < player.Length; i++) 
//     {
//         Console.Write(" ");
//     }

//     // Keep player position within the bounds of the Terminal window
//     playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//     playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//     // Draw the player at the new location
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Clears the console, displays the food and player
// void InitializeGame() 
// {
//     Console.Clear();
//     ShowFood();
//     Console.SetCursorPosition(0, 0);
//     Console.Write(player);
// }


// string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

// int studentCount = students.Length;

// Console.WriteLine("The final name is: " + students[studentCount-1]);



/* 
This code uses a names array and corresponding methods to display
greeting messages
*/



// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     WriteMessage();
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }


// checked
// {
//     try
//     {
//         int num1 = int.MaxValue;
//         int num2 = int.MaxValue;
//         int result = num1 + num2;
//         Console.WriteLine("Result: " + result);
//     }
//     catch (OverflowException ex)
//     {
//         Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
//     }
// }

// try
// {
//     string? str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null. " + ex.Message);
// }

// try
// {
//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range. " + ex.Message);
// }

// try
// {
//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
// }

// Console.WriteLine("Exiting program.");


// try
// {
//     OperatingProcedure1();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine("Exiting application.");
// }

// static void OperatingProcedure1()
// {
//     string[][] userEnteredValues = new string[][]
//     {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
//     };

//     foreach(string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             BusinessProcess1(userEntries);
//         }
//         catch (Exception ex)
//         {
//             if (ex.StackTrace.Contains("BusinessProcess1"))
//             {
//                 if (ex is FormatException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
//                 }
//                 else if (ex is DivideByZeroException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

//                     // re-throw the original exception
//                     throw;
//                 }
//                 else
//                 {
//                     // create a new exception object that wraps the original exception
//                     throw new ApplicationException("An error occurred - ", ex);
//                 }
//             }
//         }

//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             checked
//             {
//                 int calculatedValue = 4 / valueEntered;
//             }
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//         catch (DivideByZeroException)
//         {
//             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
//             throw unexpectedDivideByZeroException;

//         }
//     }
// }


// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// try
// {
//     Workflow1(userEnteredValues);
//     Console.WriteLine("'Workflow1' completed successfully.");

// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(ex.Message);
// }

// static void Workflow1(string[][] userEnteredValues)
// {
//     foreach (string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             Process1(userEntries);
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine("'Process1' encountered an issue, process aborted.");
//             Console.WriteLine(ex.Message);
//             Console.WriteLine();
//         }
//     }
// }

// static void Process1(String[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
//             }
//         }
//         else
//         {
//             throw new FormatException("Invalid data. User input values must be valid integers.");
//         }
//     }
// }



/*
This application manages transactions at a store check-out line. The
check-out line has a cash register, and the register has a cash till
that is prepared with a number of bills each morning. The till includes
bills of four denominations: $1, $5, $10, and $20. The till is used
to provide the customer with change during the transaction. The item 
cost is a randomly generated number between 2 and 49. The customer 
offers payment based on an algorithm that determines a number of bills
in each denomination. 

Each day, the cash till is loaded at the start of the day. As transactions
occur, the cash till is managed in a method named MakeChange (customer 
payments go in and the change returned to the customer comes out). A 
separate "safety check" calculation that's used to verify the amount of
money in the till is performed in the "main program". This safety check
is used to ensure that logic in the MakeChange method is working as 
expected.
*/

// string? readResult = null;
// bool useTestData = false;

// Console.Clear();

// int[] cashTill = new int[] { 0, 0, 0, 0 };
// int registerCheckTillTotal = 0;

// // registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
// int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

// int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
// int testCounter = 0;

// LoadTillEachMorning(registerDailyStartingCash, cashTill);

// registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// // display the number of bills of each denomination currently in the till
// LogTillStatus(cashTill);

// // display a message showing the amount of cash in the till
// Console.WriteLine(TillAmountSummary(cashTill));

// // display the expected registerDailyStartingCash total
// Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
// Console.WriteLine();

// var valueGenerator = new Random((int)DateTime.Now.Ticks);

// int transactions = 100;

// if (useTestData)
// {
//     transactions = testData.Length;
// }

// while (transactions > 0)
// {
//     transactions -= 1;
//     int itemCost = valueGenerator.Next(2, 50);

//     if (useTestData)
//     {
//         itemCost = testData[testCounter];
//         testCounter += 1;
//     }

//     int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
//     int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
//     int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
//     int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

//     // display messages describing the current transaction
//     Console.WriteLine($"Customer is making a ${itemCost} purchase");
//     Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
//     Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
//     Console.WriteLine($"\t Using {paymentFives} five dollar bills");
//     Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

//     try
//     {
//         // MakeChange manages the transaction and updates the till 
//         MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

//         // Backup Calculation - each transaction adds current "itemCost" to the till
//         registerCheckTillTotal += itemCost;
//     }
//     catch (InvalidOperationException e)
//     {
//         Console.WriteLine($"Could not complete transaction: {e.Message}");
//     }

//     Console.WriteLine(TillAmountSummary(cashTill));
//     Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
//     Console.WriteLine();
// }

// Console.WriteLine("Press the Enter key to exit");
// do
// {
//     readResult = Console.ReadLine();

// } while (readResult == null);


// static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
// {
//     cashTill[0] = registerDailyStartingCash[0, 1];
//     cashTill[1] = registerDailyStartingCash[1, 1];
//     cashTill[2] = registerDailyStartingCash[2, 1];
//     cashTill[3] = registerDailyStartingCash[3, 1];
// }


// static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
// {
//     int availableTwenties = cashTill[3] + twenties;
//     int availableTens = cashTill[2] + tens;
//     int availableFives = cashTill[1] + fives;
//     int availableOnes = cashTill[0] + ones;

//     int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
//     int changeNeeded = amountPaid - cost;

//     if (changeNeeded < 0)
//         throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");

//     Console.WriteLine("Cashier prepares the following change:");

//     while ((changeNeeded > 19) && (availableTwenties > 0))
//     {
//         availableTwenties--;
//         changeNeeded -= 20;
//         Console.WriteLine("\t A twenty");
//     }

//     while ((changeNeeded > 9) && (availableTens > 0))
//     {
//         availableTens--;
//         changeNeeded -= 10;
//         Console.WriteLine("\t A ten");
//     }

//     while ((changeNeeded > 4) && (availableFives > 0))
//     {
//         availableFives--;
//         changeNeeded -= 5;
//         Console.WriteLine("\t A five");
//     }

//     while ((changeNeeded > 0) && (availableOnes > 0))
//     {
//         availableOnes--;
//         changeNeeded -= 1;
//         Console.WriteLine("\t A one");
//     }

//     if (changeNeeded > 0)
//         throw new InvalidOperationException("InvalidOperationException: The till is unable to make change for the cash provided.");

//     cashTill[0] = availableOnes;
//     cashTill[1] = availableFives;
//     cashTill[2] = availableTens;
//     cashTill[3] = availableTwenties;

// }

// static void LogTillStatus(int[] cashTill)
// {
//     Console.WriteLine("The till currently has:");
//     Console.WriteLine($"{cashTill[3] * 20} in twenties");
//     Console.WriteLine($"{cashTill[2] * 10} in tens");
//     Console.WriteLine($"{cashTill[1] * 5} in fives");
//     Console.WriteLine($"{cashTill[0]} in ones");
//     Console.WriteLine();
// }

// static string TillAmountSummary(int[] cashTill)
// {
//     return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

// }



Console.WriteLine("done");
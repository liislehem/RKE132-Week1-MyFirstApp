// This is a comment to my code

//rakendus küsib kasutajalt tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //output, käsk mida teha on alati sulgudes
//string- sõne
string userName= Console.ReadLine(); //Input

Console.WriteLine("Hello"+ "," + userName + "!"); //output
//string interpolation

Console.WriteLine($"Hello {userName}  !"); //Output
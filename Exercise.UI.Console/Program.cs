using Beam.Logic;




Console.WriteLine("Enter your beam to calculate: \n");

String? n = Console.ReadLine();

var beam = new Logic($"{n}");

Console.WriteLine(beam.Validator());



//var logic = new Logic[]
//{
//new Logic ("&=*===*==*6"),
//new Logic ("#==5====*"),
//new Logic ("%===5=====*"),
//new Logic("%======*=*=**"),

//};

//foreach (var logics in logic)
//{
//	Console.WriteLine(logics.Validator());

//}


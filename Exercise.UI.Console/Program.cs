using Beam.Logic;

try
{
	var logic = new Logic[]
{
	new Logic ("&=*===*==*"),
	new Logic ("#=======*"),
	new Logic ("%========*")


};

	foreach (var logics in logic)
	{
		Console.WriteLine(logics.Validator());
	}
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

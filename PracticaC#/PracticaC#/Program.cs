// See https://aka.ms/new-console-template for more information


using PracticaC_;

Console.WriteLine("Hello, World!");

try
{
	Console.WriteLine(new Date(2022, 11, 2));
	Console.WriteLine(new Date(2022, 6, 30));
	Console.WriteLine(new Date(2022, 11, 2));

}
catch (Exception error)
{
	Console.WriteLine(error.Message);
	throw;
}
Console.WriteLine("Prasau iveskite slaptazodi: ");
string enterPassword = Console.ReadLine();
string password = "Laura";
if (enterPassword == password)
{
    Console.WriteLine("Teisingai prisijungete");
}
else if (enterPassword == "Mellon")
{
    Console.WriteLine("Teisingai prisijungete");
}
else if (enterPassword == "01101001 01101110")
{
    Console.WriteLine("Nulauzta");
}
else
{
    Console.WriteLine("Slaptažodis neteisingas, prašome bandyti dar kartą");
}
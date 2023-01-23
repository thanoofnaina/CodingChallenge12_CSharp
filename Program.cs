Console.Write("Enter the number of entries: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] passengerName = new string[n];
string[] passengerDestination = new string[n];
string[] travelDetails = new string[2 * n];

for (int i = 0; i < n; i++)
{
    Console.Write("Enter the passenger name: ");
    passengerName[i] = Console.ReadLine();

    Console.Write($"Enter the destination for {passengerName[i]}: ");
    passengerDestination[i] = Console.ReadLine();
}

travelDetails = passengerName.Concat(passengerDestination).ToArray();

Console.WriteLine(string.Join(" , ", travelDetails));
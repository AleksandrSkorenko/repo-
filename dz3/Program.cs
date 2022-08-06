Console.Clear ();
Console.WriteLine (" Введите ваше число:");
int A = Convert.ToInt32(Console.ReadLine());
if (A%2==1) 
{
Console.Clear ();  
Console.Write (A);
Console.Write (" - число нечётное");
}
else 
{
Console.Clear ();    
Console.Write (A);
Console.Write (" - число чётное");
}

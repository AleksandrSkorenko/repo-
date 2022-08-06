
Console.Clear ();
Console.WriteLine (" Введите ваши два числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int MAX;
int MIN;
if (A>B)
{
MAX=A;
MIN=B;
}
else
MAX=B;
MIN=A;

Console.Write (MAX);
Console.Write (" -наибольшее число");

Console.WriteLine ("    ");

Console.Write (MIN);
Console.Write (" -наименьшее число");
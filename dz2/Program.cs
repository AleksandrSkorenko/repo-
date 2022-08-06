Console.Clear ();
Console.WriteLine (" Введите ваши три числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
int MAX;

if (A>B&A>C) 
{ 
MAX = A;
Console.Clear ();
Console.Write (MAX);

}

if (B>A&B>C) 
{ 
MAX= B;
Console.Clear ();
Console.Write (MAX);

}

if (C>B&C>A) 
{ 
MAX= C;
Console.Clear ();
Console.Write (MAX);
}

Console.Write (" -максимальное число");

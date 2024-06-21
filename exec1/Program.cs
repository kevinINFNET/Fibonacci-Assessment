class Program
{ static void Main()
    {
  Console.WriteLine("Digite a quantidade de números da sequência de Fibonacci que deseja mostrar:");
   int n = int.Parse(Console.ReadLine());
   if (n <= 0)
 {
   Console.WriteLine("Por favor, digite um número maior que zero.");
   return;
}
PrintFibonacciSequence(n);
} static void PrintFibonacciSequence(int n)
{
  int a = 0, b = 1;
   for (int i = 0; i < n; i++)
 {
Console.Write(a + " ");
  int next = a + b;
  a = b;
  b = next;
}
Console.WriteLine(); 
 }
}

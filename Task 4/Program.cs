// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число от 1 и больше: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
if (n < 1) {
  Console.WriteLine("Упс, число меньше 1");
} 
if (n == 1) {
  Console.WriteLine("У единицы нет чётных чисел");
} 
if (n > 1) {
  Console.WriteLine("Чётные числа запрашиваемого числа " + n + ": ");
  while (count <= n) {
    if (count % 2==0) {
      Console.Write(count + " / ");
      }
    count++;
  }
}
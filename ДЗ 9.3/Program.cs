// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack(int m, int n)
{
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return Ack(m - 1, 1);
    } else {
        return Ack(m - 1, Ack(m, n - 1));
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0) {
    Console.WriteLine("Число M должно быть >= 0");
    return;
}

if (n < 0) {
    Console.WriteLine("Число N должно быть >= 0");
    return;
}

int ack = Ack(m, n);
Console.WriteLine("A(" + m + "," + n + ") = " + ack);
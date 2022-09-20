Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int n = int.Parse(number);

if ((n >= 100) && (n < 1000)) {
int ost = n % 10;
Console.WriteLine(ost);
}
else {
Console.WriteLine("Число не трехзначное!");
}
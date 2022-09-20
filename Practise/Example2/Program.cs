Console.Write("Введите день недели ");
string input = Console.ReadLine();
int number = int.Parse(input);

if(number == 1)
{
    Console.WriteLine("понедельник");
    }
    else if (number == 2)
    {
        Console.WriteLine("вторник");
        }
        else if (number == 3)
        {
            Console.WriteLine("Среда");
            }
            else if (number == 4)
            {
                Console.WriteLine("Четверг");
                }
                else if (number == 5)
                {
                    Console.WriteLine("Пятница");
                    }
                    else if (number == 6)
                    {
                        Console.WriteLine("Суббота");
                        }
                        else if (number == 7)
                        {
                            Console.WriteLine("Воскресенье");
                            }
else
{
Console.WriteLine("нет такого дня");
}

using System;

namespace _1Занятие._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // Счётчик ходов
            bool gameOver = false; // Флаг завершения игры
            int choseNum = 0; // Переменная для выбора игрока

            Console.WriteLine("Добро пожаловать в приключение! Ваша цель — пройти все 5 ходов, но будьте осторожны: каждое решение определяет вашу судьбу.");

            // Цикл игры, продолжается, пока игрок не завершит игру или не сделает 5 ходов
            while (!gameOver && count < 5)
            {
                count++;
                Console.WriteLine($"\r\nХод {count}:");

                switch (count)
                {
                    case 1:
                        Console.WriteLine("Вы оказались в тёмном лесу на развилке. Куда пойдёте?\r\n1. Направо: Вы находите тропинку, ведущую к странному свету.\r\n2. Налево: Вы слышите грохот воды и решаете идти туда.");
                        break;

                    case 2:
                        Console.WriteLine("Вы подошли к реке. Вы видите два пути:\r\n1. Направо: Мост через реку.\r\n2. Налево: Дорога, ведущая к пещере.");
                        break;

                    case 3:
                        Console.WriteLine("Вы продолжаете свой путь и видите два новых пути:\r\n1. Направо: Каменная лестница на холм.\r\n2. Налево: Узкая тропинка в лес.");
                        break;

                    case 4:
                        Console.WriteLine("Вы находите секретное место. Что делать?\r\n1. Направо: За камнями скрывается старый сундук.\r\n2. Налево: Небольшая пещера, куда можно зайти.");
                        break;

                    case 5:
                        Console.WriteLine("Это последний выбор. Вам предстоит решить судьбу:\r\n1. Направо: Вы видите выход, но он закрыт огромной дверью.\r\n2. Налево: Лестница, ведущая вниз.");
                        break;

                    default:
                        Console.WriteLine("Что-то пошло не так...");
                        break;
                }

       
                choseNum = Convert.ToInt32(Console.ReadLine());

                // Логика для каждого хода
                switch (count)
                {
                    case 1:
                        if (choseNum == 1)
                            Console.WriteLine("Вы слышите грохот воды и решаете идти к реке.");
                        else if (choseNum == 2)
                            Console.WriteLine("Вы следуете по тропинке к странному свету.");
                        break;

                    case 2:
                        if (choseNum == 1)
                        {
                            Console.WriteLine("Мост ломается, но вы успеваете прыгнуть на берег.");
                        }
                        else if (choseNum == 2)
                        {
                            Console.WriteLine("Вы заходите в пещеру, и она оказывается пустой. Никаких опасностей.");
                        }
                        break;

                    case 3:
                        if (choseNum == 1)
                        {
                            Console.WriteLine("Вы поднимаетесь на холм и наслаждаетесь видом.");
                        }
                        else if (choseNum == 2)
                        {
                            Console.WriteLine("Вы идете по узкой тропинке и наслаждаетесь тишиной леса.");
                        }
                        break;

                    case 4:
                        if (choseNum == 1)
                        {
                            Console.WriteLine("Вы открываете сундук и находите древний артефакт.");
                        }
                        else if (choseNum == 2)
                        {
                            Console.WriteLine("Вы заходите в пещеру, и там находится уютное место для отдыха.");
                        }
                        break;

                    case 5:
                        if (choseNum == 1)
                        {
                            Console.WriteLine("Вы не смогли открыть дверь, но нашли ключ в другом месте.");
                        }
                        else if (choseNum == 2)
                        {
                            Console.WriteLine("Вы спустились по лестнице и нашли выход. Победа!");
                            gameOver = true;
                        }
                        break;

                    default:
                        break;
                }
            }

            // Итоговый результат игры
            if (count < 5)
                Console.WriteLine($"Вы не прошли игру, количество ходов: {count}");
            else
                Console.WriteLine($"Поздравляю, вы прошли игру!");
        }
    }
}


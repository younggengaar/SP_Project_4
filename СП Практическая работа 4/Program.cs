using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СП_Практическая_работа_4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        c:
            Console.Write("Введите номер задания:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Из двух бревен длиной L1 и L2 метров нужно изготовить три одинаковых столбика. Какой максимальный размер L(max) могут иметь эти столбики?");
                        Console.Write("Введите длину первого бревна (l1): ");
                        double l1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину второго бревна (l2): ");
                        double l2 = double.Parse(Console.ReadLine());
                        double max;
                        if (l1 > l2)
                        {
                            max = l1 / 2;
                            if (max < l2)
                            {
                                Console.WriteLine($"Максимальный размер столбиков:{max:f1}");
                            }
                            else if(max==l2)
                            {
                                Console.WriteLine($"Максимальный размер столбиков: {l2:f1}");
                            }
                            else if (max>l2)
                            {
                                if(l2*2>l1)
                                {
                                    max = l2 / 3;
                                    Console.WriteLine($" Максимальный размер столбиков:{max:f1}");
                                }
                                else
                                {
                                    Console.WriteLine($"Максимальный размер столбиков:{l2:f1}");
                                }
                            }
                        }
                        else if(l1<l2)
                        {
                            max=l2 / 2;
                            if (max == l1)
                            {
                                Console.WriteLine($"Максимальный размер столбиков:{l1:f1}");
                            }
                            if (max<l1)
                            {
                                Console.WriteLine($"Максимальный размер столбиков: {max:f1}");
                            }
                            else if(max>l1)
                            {
                                if(l1*2>l2)
                                {
                                    max= l2 / 3;
                                    Console.WriteLine($"Максимальный размер столбиков:{max:f1}");
                                }
                                else
                                {
                                    Console.WriteLine($"Максимальный размер столбиков:{l1:f1}");
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    goto c;
                case 2:
                    {
                        Console.WriteLine("У Андрея все монеты трехрублевые, а у его друга Сергея все монеты пятирублевые. За покупки они решили рассчитываться вместе, деньги давать без сдачи и минимальным числом монет. Известно, что они сделали покупку стоимостью N рублей, при этом они рассчитались без сдачи.Следует написать программу, которая определяет: сколько монет внес Андрей и сколько монет внес Сергей.");
                        Console.Write("Введите стоимость покупки: ");
                        int суммаПокупки = int.Parse(Console.ReadLine());
                        int монетыАндрея = 3;
                        int монетыСергея = 5;
                        int колАндрея = 0;
                        int колСергея = 0;
                        for (int i=0;i<=суммаПокупки/монетыАндрея;i++)
                        {
                            if ((суммаПокупки-монетыАндрея*i)%монетыСергея==0)
                            {
                                колАндрея = i;
                                колСергея = (суммаПокупки - монетыАндрея * i) / монетыСергея;
                                break;
                            }
                        }
                        Console.WriteLine($"{колАндрея} {колСергея}");
                        Console.ReadKey();
                    }
                    goto c;
                case 3:
                    {
                        Console.WriteLine("Рассмотрим последовательность 110100100010000…, в которой выписаны подряд степени числа 10. Цифры в этой последовательности нумеруются слева направо, начиная с единицы. По заданному k определить k-ю цифру в этой последовательности.");
                        string посл = "1101001000100001000001000000100000001000000001000000000100000000001000000000001000000000000";
                        char[] omas = new char[посл.Length];
                        for (int i = 0; i < посл.Length; i++) 
                        {
                            omas[i] = посл[i];
                        }
                    j:
                        Console.Write("Введите k-ую цифру в последовательности: ");
                        int k = int.Parse(Console.ReadLine());
                        if (k >= 0 && k < omas.Length)
                        {
                            Console.WriteLine(omas[k-1]);
                        }
                        else
                        {
                            goto j;
                        }
                        Console.ReadKey();
                    }
                    goto c;
            }
            Console.ReadKey();
        }
    }
}

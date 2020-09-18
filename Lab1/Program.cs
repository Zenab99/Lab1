using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv en random sträng för att dela in den i substring och sedan få summan av dem.");
            string solut = Console.ReadLine();
            double result = 0;
            string[] arraylist = { solut };
            
            int number;
            

            for (int u = 0; u < solut.Length; u++)
            {
               
                if (char.IsDigit(solut, u))
                {

                    for (int y = u + 1; y < solut.Length; y++)
                    {
                        if (char.IsNumber(solut[y]))
                        {

                            char sub = solut[u];
                            char strng = solut[y];


                            if (sub == strng)
                            {
                                for (int k = 0; k < u; k++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(solut[k]);
                                }
                                for (int k = u; k < y + 1; k++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(solut[k]);
                                }
                                for (int k = y + 1; k < solut.Length; k++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(solut[k]);
                                }
                                string start = solut.Substring(0, u);
                                string delstring = solut.Substring(u, y - u + 1);
                                string slut = solut.Substring(y + 1, solut.Length - y - 1);
                                result = result + double.Parse(delstring);
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                
                            }

                        }
                        else
                        {

                            break;
                        }



                    }



                }

               

            }
            Console.WriteLine("\n" + "Resultatet på alla delsträngar är: " + result);
            Console.ReadKey();

        }
    }
}
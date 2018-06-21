using System;

public class Program
{
    public static void Main()
    {
        Random tNumRND = new Random();
        int rnd1 = tNumRND.Next(1, 5);

        Console.WriteLine("Are you ready to transmit data: Y/N");
        string inputData = Console.ReadLine();
        if (inputData.Length == 1)
        {
            char yOrN = Convert.ToChar(inputData);
//	        Optional: Roll Array.
            int[] attempts = new int[10];
            try
            {
                if (yOrN == 'y' || yOrN == 'Y')
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int rnd2 = tNumRND.Next(1, 5);
                        attempts[i - 1] = rnd2;
                        if (rnd1 == rnd2)
                        {
                            Console.WriteLine("Data has been received by the space craft after {0} attempts.", i);
//	                        Optional: Allows user to see random rolls after system completes. 
                            Array.Resize(ref attempts, i);
                            Console.Write("{0}: [", rnd1);
                            foreach (int a in attempts)
                            {
                                Console.Write(" {0} ", a);
                            }
                            Console.Write("]");
//	                        Roll Viewer End.
                            break;
                        }
                        if (i == 10 && rnd1 != rnd2)
                        {
                            Console.WriteLine("Data was unable to reach the space craft before losing contact.");
                        }
                    }
                }
                else if (yOrN == 'n' || yOrN == 'N')
                {
                    Program.Main();
                }
                else
                {
                    Console.WriteLine("This is an invalid character; Try again.");
                    Program.Main();
                }
            }
            catch (Exception e)
            {
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid input.");
            Program.Main();
        }
    }
}
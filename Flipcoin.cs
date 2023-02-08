using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Helloworld
{
    public class Flipcoin
    {
        public static void calculatepercentage() 
        {
            Console.WriteLine("Please enter the value for number of flips");

            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double headpercentage;
            double tailpercentage;

            int flipcoin =Convert.ToInt32(Console.ReadLine());  

            if(flipcoin>0)
            {
                for(int i=0; i<flipcoin; i++)
                {
                    Random random= new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The random number generated is " + number);

                    //if (number == 0)
                    //{
                    //    //Console.WriteLine("Tail");
                    //    tailcount++;
                    //}
                    //else
                    //{
                    //    //Console.WriteLine("Head");
                    //    headcount++;
                    //}
                    switch (number)
                    {
                        case 0:
                            tailcount++; 
                            break;
                        case 1:
                            headcount++; 
                            break;

                    }
                }

                Console.WriteLine("The number of head we got is " + headcount);
                Console.WriteLine("The number of tail we got is " + tailcount);

                headpercentage = headcount * 100 / flipcoin;
                tailpercentage = tailcount * 100 / flipcoin;

                Console.WriteLine("head percentage=" + headpercentage +"%");
                Console.WriteLine("Tail percentage=" + tailpercentage +"%");
            }
            else
            {
                Console.WriteLine("please enter a valid n");
            }
        }
    }
}

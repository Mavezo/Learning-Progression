using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SP_7;

namespace SP_7
{
    public class Philosopher
    {
        public Fork leftFork;
        public Fork rightFork;
        
        public void Think(int i)
        {
            while (true)
            {
                Console.WriteLine($"Философ {i} думает");
                Thread.Sleep(100);
                forksCheck(i);
            }
        }

        
        public void forksCheck(int i)
        {
            try
            {
                //if (Monitor.TryEnter(leftFork))
                //{
                    if (leftFork.IsForkAwailable == true)
                    {
                        lock (leftFork)
                        {
                            leftFork.IsForkAwailable = false;
                            Console.WriteLine($"Философ {i} взял левую вилку");
                            //if (Monitor.TryEnter(rightFork))
                            //{
                                if (rightFork.IsForkAwailable == true)
                                {
                                    //lock (rightFork)
                                    //{
                                        Console.WriteLine($"Философ {i} взял правую вилку");
                                        rightFork.IsForkAwailable = false;
                                        Eat(i);
                                    //} 
                                }
                                else
                                {
                                    Console.WriteLine($"Философ {i} положил левую вилку (правая не свободная)");
                                    leftFork.IsForkAwailable = true;
                                }
                            }
                        }
                //    }
                //}
            }
            catch { }
        }

        public void Eat(int i)
        {
            Console.WriteLine($"Философ {i} ест");
            Thread.Sleep(300);
            leftFork.IsForkAwailable = true;
            //Monitor.Exit(leftFork);
            Console.WriteLine($"Философ {i} поел и положил левую вилку");
            rightFork.IsForkAwailable = true;
            //Monitor.Exit(rightFork);
            Console.WriteLine($"Философ {i} поел и положил правую вилку");
        }
    }
}

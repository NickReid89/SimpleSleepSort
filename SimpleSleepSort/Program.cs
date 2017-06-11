/*
 * Author: Nickolas Reid
 */ 


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleSleepSort
{
    public class Test 
    {
        //Sleeps the thread for as long as the index is in seconds
        static void ThreadStart(int index)
        {
            Thread.Sleep(1000 * index);
            //Displays the result.
            Console.WriteLine(index);
        }

        //Method that creates a new thread for the new index to run.
        static void SleepThread(int[] index)
        {

            foreach(int x in index)
            {
                 new Thread(() => ThreadStart(x)).Start();
              
            }
        }

        static void Main(string[] arguments)
        {
            //Make an array as long as the arguments list is.
            int[] index = new int[arguments.Length];
            //Grab the arguments.
            for(int i = 0; i < index.Length; i++)
            {
                index[i] = int.Parse(arguments[i]);
            }
            //Call method to make the threads
            SleepThread(index);
            //This is so the user can see the results
            Console.ReadLine();
        }


    }

        
    }


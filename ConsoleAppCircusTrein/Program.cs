using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCircusTreinLibrary;

namespace ConsoleAppCircusTrein
{
    internal class Program
    {
        static Train train = new Train();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circus Train!");
            Console.WriteLine("First we need the amount of animals to be stored in the train.");
            Console.WriteLine("Please enter a above 0 number.");
            string amountString = Console.ReadLine();

            Stopwatch stopWatchTotalTime = new Stopwatch();
            stopWatchTotalTime.Start();

            if (!Int32.TryParse(amountString, out int amountInt))
            {
                Console.WriteLine("Please enter a valid value! Press a key to try again.");
                Console.ReadKey();
                // Starts a new instance of the program itself
                string fileName = Assembly.GetExecutingAssembly().Location;
                System.Diagnostics.Process.Start(fileName);

                // Closes the current process
                Environment.Exit(0);
            }
            else
            {
                Stopwatch stopwatchCalculations = new Stopwatch();
                if (amountInt == 1)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioOne();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else if (amountInt == 2)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioTwo();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else if (amountInt == 3)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioThree();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else if (amountInt == 4)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioFour();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else if (amountInt == 5)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioFive();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else if (amountInt == 6)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioSix();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else if (amountInt == 7)
                {
                    stopwatchCalculations.Start();
                    train.CreateAnimalScenarioSeven();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }
                else 
                {
                    stopwatchCalculations.Start();

                    train.AddAmountOfAnimals(amountInt);
                    train.CreateRandomAnimals();
                    train.AddAnimalsToWagons();
                    stopwatchCalculations.Stop();
                }

                Stopwatch stopwatchDisplay = new Stopwatch();
                stopwatchDisplay.Start();

                int wagonNumber = 1;

                foreach (Wagon wagon in train.Wagons)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wagon " + wagonNumber + ":");
                    Console.WriteLine();
                    foreach (Animal animal in wagon.Animals)
                    {
                        Console.WriteLine(animal.Type.ToString() + ", " + animal.Size.ToString());
                    }
                    wagonNumber++;
                }

                stopwatchDisplay.Stop();
                stopWatchTotalTime.Stop();

                Console.WriteLine();

                TimeSpan timestampCalculations = stopwatchCalculations.Elapsed;
                string elapsedTimeCalculations = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timestampCalculations.Hours, timestampCalculations.Minutes, timestampCalculations.Seconds, timestampCalculations.Milliseconds / 10);
                Console.WriteLine("RunTime Calculations only " + elapsedTimeCalculations);

                TimeSpan timestampDisplay = stopwatchDisplay.Elapsed;
                string elapsedTimeDisplay = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timestampDisplay.Hours, timestampDisplay.Minutes, timestampDisplay.Seconds, timestampDisplay.Milliseconds / 10);
                Console.WriteLine("RunTime Display only " + elapsedTimeDisplay);

                TimeSpan timestampTotalTime = stopWatchTotalTime.Elapsed;
                string elapsedTimeTotalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timestampTotalTime.Hours, timestampTotalTime.Minutes, timestampTotalTime.Seconds, timestampTotalTime.Milliseconds / 10);
                Console.WriteLine("Total RunTime " + elapsedTimeTotalTime);
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_9
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainerList trainerList = new TrainerList();

            while(true)
            { 

                var check = Console.ReadKey();

                switch (check.Key)
                {
                    case ConsoleKey.Spacebar:
                        
                        Console.Write("Enter name:");
                        string Name = Console.ReadLine();
                        Console.Write("Enter Excercise number:");
                        int Exercise = int.Parse(Console.ReadLine());
                        Trainer trainer = new Trainer(Name, Exercise);
                        trainerList.Add(trainer);
                        break;

                    case ConsoleKey.UpArrow:
                        trainerList.DoExercise();
                        trainerList.Print();
                        break;

                }
            }

        }
    }
}

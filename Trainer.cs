using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_9
{
    class TrainerList
    {
        public List<Trainer> Gym_1 = new List<Trainer>();
        private List<Trainer> Gym_2 = new List<Trainer>();
        private List<Trainer> Gym_3 = new List<Trainer>();


        public void Add(Trainer NewHuman)
        {
            Gym_1.Add(NewHuman);
        }

        public void DoExercise()
        {
            EnotherGym(Gym_1, Gym_2);
            Exercise_Underground(Gym_1);
            EnotherGym(Gym_2, Gym_3);
            Exercise_Underground(Gym_2);
            Delete(Gym_3);
            Exercise_Underground(Gym_3);
        }

        public void Print()
        {
            Print_Underground(Gym_1);
            Print_Underground(Gym_2);
            Print_Underground(Gym_3);
            Console.WriteLine("============================");
        }

        private void EnotherGym(List<Trainer> FromGym, List<Trainer> ToGym)
        {
            foreach (var x in FromGym)
            {
                if (x.Exercise_Left == 0)
                {
                    x.CurentGymNumber++;
                    x.Exercise_Left = x.Exercise;
                    ToGym.Add(x);
                    FromGym.Remove(x);
                    EnotherGym(FromGym, ToGym);
                    break;
                }

            }
        }

        private void Delete(List<Trainer> FromGym)
        {
            foreach (var x in FromGym)
            {
                if (x.Exercise_Left == 0)
                {
                    FromGym.Remove(x);
                    Delete(FromGym);
                    break;
                }

            }
        }

        private void Exercise_Underground(List<Trainer> trainers)
        {
            foreach (var x in trainers)
            {
                x.Exercise_Left--;
            }
        }

        private void Print_Underground(List<Trainer> trainers)
        {
            foreach (var x in trainers)
            {
                Console.WriteLine($"Gym Number: {x.CurentGymNumber}, Name: {x.Name}, Approach: {x.Exercise_Left}");
            }
        }

    }

    class Trainer
    {
        public Trainer(string name, int exercise)
        {
            CurentGymNumber = 1;
            Name = name;
            Exercise = exercise;
            Exercise_Left = exercise;
        }
        public int CurentGymNumber { get; set; }
        public string Name { get; private set; }
        public int Exercise { get; private set; }
        public int Exercise_Left { get; set; }
    }
}

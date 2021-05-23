using BeesConsoleApp.Models;
using System;

namespace BeesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for worker, 2 for Queen and 3 for Drone");
            var inputVal = Convert.ToInt32(Console.ReadLine());
            switch (inputVal)
            {
                case 1:
                    Program worker = new Program();
                    worker.checkWorkerStatus();
                    break;
                case 2:
                    Program queen = new Program();
                    queen.checkQueenStatus();
                    break;
                default:
                    Program drone = new Program();
                    drone.checkDroneStatus();
                    break;
            }
        }

        #region Worker
        private void checkWorkerStatus()
        {
            Console.WriteLine("Do you want to continue with latest worker value. press 1 for yes and 2 for no");
            var checkStatus = Convert.ToInt32(Console.ReadLine());
            switch (checkStatus)
            {
                case 1:
                    calculateWorkerStatus();
                    break;
                case 2:
                    break;
                default:
                    break;

            }
        }
        private void calculateWorkerStatus()
        {
            Console.WriteLine("Enter any number between 0 and 100 for Worker");
            var workerValue = Console.ReadLine();
            Worker worker = new Worker();
            float workerStatus = worker.Damage(Convert.ToInt32(workerValue));
            var status = worker.dead ? "Dead" : "Alive";
            Console.WriteLine("Health status of Worker is : " + workerStatus + "% and worker is " + status);
            if (status == "Alive")
            {
                Program pro = new Program();
                pro.checkWorkerStatus();
            }
        }
        #endregion

        #region Queen
        private void checkQueenStatus()
        {
            Console.WriteLine("Do you want to continue with latest queen value. press 1 for yes and 2 for no");
            var checkStatus = Convert.ToInt32(Console.ReadLine());
            switch (checkStatus)
            {
                case 1:
                    calculateQueenStatus();
                    break;
                case 2:
                    break;
                default:
                    break;

            }
        }
        private void calculateQueenStatus()
        {
            Console.WriteLine("Enter any number between 0 and 100 for Worker");
            var workerValue = Console.ReadLine();
            Queen worker = new Queen();
            float workerStatus = worker.Damage(Convert.ToInt32(workerValue));
            var status = worker.dead ? "Dead" : "Alive";
            Console.WriteLine("Health status of Queen is : " + workerStatus + "% and queen is " + status);
            if (status == "Alive")
            {
                Program pro = new Program();
                pro.checkQueenStatus();
            }
        }
        #endregion

        #region Drone
        private void checkDroneStatus()
        {
            Console.WriteLine("Do you want to continue with latest drone value. press 1 for yes and 2 for no");
            var checkStatus = Convert.ToInt32(Console.ReadLine());
            switch (checkStatus)
            {
                case 1:
                    calculateDroneStatus();
                    break;
                case 2:
                    break;
                default:
                    break;

            }
        }
        private void calculateDroneStatus()
        {
            Console.WriteLine("Enter any number between 0 and 100 for Worker");
            var workerValue = Console.ReadLine();
            Drone drone = new Drone();
            float workerStatus = drone.Damage(Convert.ToInt32(workerValue));
            var status = drone.dead ? "Dead" : "Alive";
            Console.WriteLine("Health status of Drone is : " + workerStatus + "% and drone is " + status);
            if (status == "Alive")
            {
                Program pro = new Program();
                pro.checkDroneStatus();
            }
        }
        #endregion
    }
}
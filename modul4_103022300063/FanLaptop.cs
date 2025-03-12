using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static modul4_103022300063.FanLaptop;

namespace modul4_103022300063
{
    class FanLaptop
    {
        public enum FanState
        {
            Quiet,
            Balanced,
            Turbo,
            Performance,
            Exit
        }

        public static void FanMachine()
        {
            FanState state = FanState.Quiet;
            Console.WriteLine("Fan dalam kondisi Quiet");
            while (state != FanState.Exit)
            {
                Console.Write("Masukkan Command : ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case FanState.Quiet:
                        if (command == "Mode Up")
                        {
                            state = FanState.Balanced;
                            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                        }
                        else if (command == "Turbo Shortcut")
                        {
                            state = FanState.Turbo;
                            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                        }
                        else if (command == "Exit")
                        {
                            state = FanState.Exit;
                        }
                        else
                        {
                            Console.WriteLine("Command Tidak Tersedia");
                        }
                        break;
                    case FanState.Balanced:
                        if (command == "Mode Up")
                        {
                            state = FanState.Performance;
                            Console.WriteLine("Fan Balanced berubah menjadi Performance");
                        }
                        else if (command == "Mode Down")
                        {
                            state = FanState.Quiet;
                            Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                        }
                        else if (command == "Exit")
                        {
                            state = FanState.Exit;
                        }
                        else
                        {
                            Console.WriteLine("Command Tidak Tersedia");
                        }
                        break;
                    case FanState.Performance:
                        if (command == "Mode Down")
                        {
                            state = FanState.Balanced;
                            Console.WriteLine("Fan Performance berubah menjadi Balanced");
                        }
                        else if (command == "Mode Up")
                        {
                            state = FanState.Turbo;
                            Console.WriteLine("Fan Performance berubah menjadi Turbo");
                        }
                        else if (command == "Exit")
                        {
                            state = FanState.Exit;
                        }
                        else
                        {
                            Console.WriteLine("Command Tidak Tersedia");
                        }
                        break;
                    case FanState.Turbo:
                        if (command == "Turbo Shortcut")
                        {
                            state = FanState.Quiet;
                            Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                        }
                        else if (command == "Mode Down")
                        { 
                            state = FanState.Performance;
                            Console.WriteLine("Fan Turbo berubah menjadi Performance");
                        }
                        else if (command == "Exit")
                        {
                            state = FanState.Exit;
                        }
                        else
                        {
                            Console.WriteLine("Command Tidak Tersedia");
                        }
                        break;
                }
            }
            Console.WriteLine("EXIT SCREEN");
      }
    }
}

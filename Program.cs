using System;


namespace Events
{

    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;
        public event PressKeyEventHandler PressKeyC = null;

        public void PressKeyAEvent()
        {
            if (PressKeyA != null)
            {
                PressKeyA.Invoke();
            }

        }

        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }

        }

        public void PressKeyCEvent()
        {
            if (PressKeyC != null)
            {
                PressKeyC.Invoke();
            }

        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "c":
                    case "C":
                        PressKeyCEvent();
                        break;
                    case "e":
                    case "E":
                    case "exit":
                    case "Exit":
                    case "EXIT":
                        goto Exit;


                    default:
                        Console.WriteLine("Нет обработчика на клавишу {0}", s);
                        Console.WriteLine("Для выхода нажмите \"E\"");
                        break;


                }

            }
            Exit:
            Console.WriteLine("Exit!");
        }

    }





        class Program
    {

        static private void PressKeyA_Hendler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyB_Hendler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("XXXXX    ");
            Console.WriteLine("X    X   ");
            Console.WriteLine("XXXXXXX  ");
            Console.WriteLine("X      X ");
            Console.WriteLine("XXXXXXX  ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyC_Hendler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("   XXXX  ");
            Console.WriteLine(" X      x");
            Console.WriteLine("X        ");
            Console.WriteLine(" X      x");
            Console.WriteLine("   XXXX  ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }



        static void Main(string[] args)
        {

            Keyboard keyboard = new Keyboard();
            keyboard.PressKeyA += PressKeyA_Hendler;
            keyboard.PressKeyB += PressKeyB_Hendler;
            keyboard.PressKeyC += PressKeyC_Hendler;

            keyboard.Start();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    class Event
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received");
        }

        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
         
        }
    }
}

using System;

namespace VeeamCourse.Lab_1_1.Task_2
{
    class Structs
    {
        public struct Base
        {
            public void SayHi()
            {
                Console.WriteLine("Hi from the Base struct!");
            }

            public void SayBye()
            {
                Console.WriteLine("Bye from the Base struct!");
            }
        }

        public struct Derived
        {
            private Base baseStruct;

            public Derived(Base baseStruct)
            {
                this.baseStruct = baseStruct;
            }

            // Inheritance simulation
            public void SayHi()
            {
                baseStruct.SayHi();
            }

            // Ovverriding simulation
            public void SayBye()
            {
                Console.WriteLine("Bye from the Derived struct!");
            }
            
        }
    }
}

﻿namespace _19_OOP_Abstraction.NestedAbstraction
{
    internal class ElectricGuitar : Guitar
    {
        public override int StringCount => 6;

        public override string PlaySound()
        {
            return "I am a Electric Guitar!";
        }
    }
}

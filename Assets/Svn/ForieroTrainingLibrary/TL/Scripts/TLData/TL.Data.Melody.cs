/* Marek Ledvina © Foriero s.r.o. 2022, The Commercial License */
using System;
using System.Collections;

namespace ForieroEngine.Music.Training
{
    public static partial class TL
    {
        public static partial class Exercises
        {
            public static partial class Melody
            {
                public class Data : Exercises.Data
                {
                    public double lastTime;
                }

                public static Data data = new Data();
            }
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapExample1
{
    class SwapExample<T>
    {
        public void Swap(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

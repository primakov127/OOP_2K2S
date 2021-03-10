using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02.Adapter
{
    interface IGo
    {
        void GoUp(int stepsCount);
        void GoDown(int stepsCount);
        void GoLeft(int stepsCount);
        void GoRight(int stepsCount);
    }
}

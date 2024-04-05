using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace.Models
{
    internal interface ISwim
    {
        int MaxSwimTime { get; set; }
        void swim();
    }
}

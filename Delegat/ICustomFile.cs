﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public interface ICustomFile
    {
        void Create(string name);
        double GetSize();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Adapter1
{
    public interface IJSON
    {
        public void Read1();
        public string FileName { get; set; }
    }
}

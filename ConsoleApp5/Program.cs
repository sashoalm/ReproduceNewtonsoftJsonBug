﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

using Newtonsoft.Json;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = JsonConvert.SerializeObject("foo");
            Console.WriteLine(json);

            // Now call the DLL.
            Class1.Foo();
        }
    }
}

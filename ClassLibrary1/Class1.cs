﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Foo()
        {
            var json = JsonConvert.SerializeObject("foo");
            Console.WriteLine(json);
        }
    }
}

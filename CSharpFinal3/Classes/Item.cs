﻿using CSharpFinal3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal3.Classes
{
    class Item : IMarketableItem
    {
        public string Product { get; set; }

        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;

        public Item()
        {
            _id++;
            Id = _id;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsApp
{
    public class Indexer
    {
        private int[] array = new int[5];

        public int this[int index] {
            get{return array[index];}
            set{array[index]=value;}
        }
    }
}
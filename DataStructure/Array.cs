using System;
using System.Collections;

namespace DataStructureAndAlgorithm
{
    class Array
    {
        public int length;
        public Object[] data;

        public Array()
        {
              this.length=0;
              this.data = new Object[]{};
        }

        public Object get(int index)
        {
            return this.data[index]; 
        }

        public int push(Object item)
        {
           this.data[this.length] = item;
           this.length++;
           return this.length;
        }

    
    }

}
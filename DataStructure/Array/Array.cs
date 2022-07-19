using System;
using System.Collections;

namespace DataStructureAndAlgorithm
{
    class Array
    {
        public int length;
        private Object[] data;

        public Array()
        {
              this.length=0;
              this.data = new object[] { };
        }

        public Object get(int index)
        {
            return this.data[index]; 
        }

        public int push(Object item)
        {
                Object[] dataTemp = new object[this.length + 1];
                
                for (int i = 0; i < this.data.Length; i++)
                             dataTemp[i] = this.data[i];
                
                this.data = dataTemp;
                this.data[this.length++] = item;
                return this.length;            
        }

        public Object pop()
        {
            if (this.length <= 0)
            {
                return "Array is already empty";
            }
            Object[] dataTemp = new object[this.length--];

            for (int i = 0; i < this.length; i++)
                dataTemp[i] = this.data[i];

            Object returnItem = this.data[this.length]; 
            this.data = dataTemp;
            return returnItem;
        }

    
    }

}
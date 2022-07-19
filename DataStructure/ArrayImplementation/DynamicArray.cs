using System;
using System.Collections;

namespace DataStructure.ArrayImplementation
{
    class DynamicArray
    {
        public int length;
        private Object[] data;

        public DynamicArray()
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

        public Object delete(int index)
        {
            if (this.length <= 0)
            {
                return "Array is already empty";
            }
            else if (index > this.length - 1 || index < 0)
            {
                return "Index is not valid";
            }
            else
            { 
                    Object[] dataTemp = new object[this.length--];
                    int j = 0;
                    for (int i = 0; i < this.data.Length; i++)
                        if(i != index)
                            dataTemp[j++] = this.data[i];

                    Object returnItem = this.data[index];
                    this.data = dataTemp;
                    return returnItem;
            }
        }

        public string toString()
        {
            string returnItem = "";
            for (int i = 0; i < this.length; i++)
                returnItem += this.data[i] + ",";

            return returnItem.Trim().Length > 0 ? returnItem.Remove(returnItem.LastIndexOf(",")) : "";
        }

    }

}
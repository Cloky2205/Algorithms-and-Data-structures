using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LR_4
{
    internal class ChainHashTable
    {
        public int arraySize;
        public LinkedList[] hashArray;
        public int usedSlots;
        public ChainHashTable(int size)
        {
            this.arraySize = size;
            this.hashArray = new LinkedList[arraySize];
            for (int j = 0; j < arraySize; j++)
            {
                hashArray[j] = new LinkedList();
            }
        }
        public Link find(int key)
        {
            int hashVal = hashFunc(key);
            return hashArray[hashVal].find(key);
        }
        public void insert(Link theLink)
        {
            int key = theLink.getKey();
            if (usedSlots == arraySize) { upscale(); }
            int hashVal = hashFunc(key);
            hashArray[hashVal].insert(theLink);
            usedSlots++;
        }
        public void delete(int key)
        {
            int hashVal = hashFunc(key);
            hashArray[hashVal].delete(key);
        }
        public int hashFunc(int key)
        {
            int hashVal1 = key % arraySize;
            return hashVal1;
        }
        private int getPrime(int min)
        {
            for (int j = min + 1; true; j++)
            {
                if (isPrime(j))
                {
                    return j;
                }
            }
        }

        private bool isPrime(int n)
        {
            for (int j = 2; (j * j <= n); j++)
            {
                if (n % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void upscale()
        {
            int newArraySize = arraySize * 2;

            LinkedList[] newHashArray = new LinkedList[newArraySize];
            for (int i = 0; i < arraySize; i++)
            {
                newHashArray[i] = hashArray[i];
            }
            hashArray = newHashArray;
            
        }
    
    }
}

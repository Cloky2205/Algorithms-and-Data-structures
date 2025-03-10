using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Queues
{
    public class QueueImpl
    {
        private int maxSize;
        private long[] queArray;
        private int front;
        private int rear;
        private int nItems;

        public QueueImpl(int s)
        {
            maxSize = s;
            queArray = new long[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void insert(long j)
        {
            try
            {
                if (nItems == maxSize)
                {
                    throw new Exception("Очередь полная");
                }
                else
                {
                    if (rear == maxSize - 1)
                    {
                        rear = -1;
                    }
                    queArray[++rear] = j;
                    nItems++;
                }
                
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }

            }


            

        }

        public long remove()
        {
            try
            {
                if (nItems == 0)
                {
                    throw new Exception("Очередь пустая");
                }
                else
                {
                    long temp = queArray[front++];
                    if (front == maxSize)
                    {
                        front = 0;
                    }
                    nItems--;
                    return temp;
                }
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    return '\0';
                }

            }
        }

        public long peekFront()
        {
            try
            {
                if (nItems == 0)
                {
                    throw new Exception("Очередь пустая");
                }
                else
                {
                    return queArray[front];
                }
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    return '\0';
                }

            }
            
        }

        public bool isEmpty()
        {
            return (nItems == 0);
        }

        public bool isFull()
        {
            return (nItems == maxSize);
        }

        public int size()
        {
            return nItems;
        }
    }
    
    
    public class PriorityQueueImpl
    {
        
        private int maxSize;
        private long[] queArray;
        private int nItems;

        public PriorityQueueImpl(int s)
        {
            maxSize = s;
            queArray = new long[maxSize];
            nItems = 0;
        }

        public void insert(long item)
        {
            try
            {
                if (nItems == maxSize)
                {
                    throw new Exception("Очередь полная");
                }
                else
                {
                    int j;
                    if (nItems == 0)
                    {
                        queArray[nItems++] = item;
                    }
                    else
                    {
                        for (j = nItems - 1; j >= 0; j--)
                        {
                            if (item > queArray[j])
                            {
                                queArray[j + 1] = queArray[j];
                            }
                            else
                            {
                                break;
                            }
                        }
                        queArray[j + 1] = item;
                        nItems++;
                    }
                }
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }

            }
            
        }

    

        public long remove()
        {
            try
            {
                if (nItems == 0)
                {
                    throw new Exception("Очередь пустая");
                }
                else
                {
                    return queArray[--nItems];
                }
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    return '\0';
                }

            }
            
        }

        public long peekMin()
        {
            try
            {
                if (nItems == 0)
                {
                    throw new Exception("Очередь пустая");
                }
                else
                {
                    return queArray[nItems - 1];
                }
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    return '\0';
                }

            }
        }

        public bool isEmpty()
        {
            return (nItems == 0);
        }

        public bool isFull()
        {
            return (nItems == maxSize);
        }
    }
}

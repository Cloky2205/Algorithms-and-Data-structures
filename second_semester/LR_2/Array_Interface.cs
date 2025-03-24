using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    public interface ClassArrayInterface
    {
        bool find(long searchValue);
        void swap(int index1, int index2);
        int partition(int leftIndex, int rightIndex, long pivot);
        void qsort();
        void msort();
        void shsort();
        void quickSort(int left, int right);
        void insertionSort(int leftIndex, int rightIndex);
        long medianOfThreePoints(int leftIndex, int rightIndex);
        bool contains(long searchValue);
        long findmax();
        long findmin();
        void insert(long value);
        bool delete(long value);
        void display();
        int getSize();
    }
}

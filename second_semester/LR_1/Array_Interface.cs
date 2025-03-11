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
        bool sortShella();
        bool sortKnutha();
        bool contains(long searchValue);
        long findmax();
        long findmin();
        void insert(long value);
        bool delete(long value);
        void display();
        int getSize();
    }
}

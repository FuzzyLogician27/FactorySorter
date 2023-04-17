using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySorterApp
{
    public class Bubble : ISorter
    {
        private ArrayGenerator _arrayGenerator;
        public Bubble(ArrayGenerator array)
        {
            _arrayGenerator = array;
        }
        public ArrayGenerator Sort()
        {
            throw new NotImplementedException();
        }
    }
}

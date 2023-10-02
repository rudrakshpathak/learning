using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.ASP.NET.Concepts.OOPs
{
    internal class Indexer<ListType>
    {
        int index = 0;

        private ListType[] array = new ListType[100];

        public void Add(ListType data)
        {
            array[index++] = data;
        }

        public ListType this[int i] => array[i];
    }
}

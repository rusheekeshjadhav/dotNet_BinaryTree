using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public delegate void Insert(int value);
    public delegate void Traverse();
    public class TreeEvent
    {
        public event Insert insert;
        public event Traverse traverse;

        public void onInsert(int value)
        {
            if(insert != null)
                insert(value);
        }

        public void onTraverse()
        {
            if (traverse != null)
                traverse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._7_Design
{
    public class MinStack
    {
        public int _base;
        public int _top;
        public int _initLen = 100;
        public int _increment = 20;
        public int[] _stack;
        public MinStack()
        {
            _base = 0;
            _top = 0;
            _stack = new int[_initLen];
        }
        public void Push(int x)
        {
            if (_top + 1 >= _initLen)
            {
                int[] tmp = _stack;
                _stack = new int[_top + _increment +1];
                for (int i = 0; i <= _top; i++)
                {
                    _stack[i] = tmp[i];
                }
            }
            _stack[_top] = x;
            _top++;
        }
        public void Pop()
        {
            if (_top != 0)
            {
                _top--;
            }
        }
        public int Top()
        {
            return _stack[_top-1];
        }
        public int GetMin()
        {
            int min = int.MaxValue;
            for (int i = 0; i < _top; i++)
            {
                min = min > _stack[i] ? _stack[i] : min;
            }
            return min;
        }
    }
}

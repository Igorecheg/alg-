using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            StackWithArray stack = new StackWithArray(3);

            stack.Push(42);
            stack.Push(42);
            stack.Push(42);
            stack.Push(123);
            stack.Push(42);
            stack.Push(42);
            stack.Push(42);
            stack.Push(123);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());

        }
    }

    class StackWithArray
    {
        private int[] _items;
        private int _size;
        private readonly int _initiSize = 4;
        private int _top;

        public StackWithArray()
        {
            _size = _initiSize;
            _items = new int[_size];
            _top = -1;
        }

        public StackWithArray(int size)
        {
            _size = size;
            _items = new int[_size];
            _top = -1;
        }

        public void Push(int value)
        {
            IncreaseCapacity();
            _top++;
            _items[_top] = value;
        }

        public int Pop()
        {
            int temp = Peek();
            _top--;
            DecreaseCapacity();
            return temp;
        }

        private void DecreaseCapacity()
        {

        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            return _items[_top];
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }





        private void IncreaseCapacity()
        {
            if (_top + 1 >= _size)
            {
                int[] temp = new int[_size * 2];
                for (int i = 0; i <= _top; i++)
                {
                    temp[i] = _items[i];
                }
                _items = temp;
                _size *= 2;
            }
        }






    }
}


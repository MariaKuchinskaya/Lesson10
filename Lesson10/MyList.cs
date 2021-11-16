using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson10
{
    public class MyList: IList<MyItem>
    {
        private MyItem[] _array;

        public MyList()
        {
            _array = Array.Empty<MyItem>();
        }

        public MyList(MyItem[] array)
        {
            _array = array;
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(MyItem item)
        {
            Array.Resize<MyItem>(ref _array, _array.Length +1);
            _array[_array.Length - 1] = item;
        }

        public void Clear()
        {
            _array = Array.Empty<MyItem>();

        }

        public bool Contains(MyItem item)
        {
            if (item != null)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i].GetAge() == item.GetAge())
                    {
                        return true;
                    }
                }
            }
           

            return false;
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            MyItem[] newArray = new MyItem[_array.Length + array.Length];
            for (int i = 0; i < arrayIndex; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                newArray[arrayIndex + i] = array[i];
            }

            for (int i = _array.Length - array.Length - 1; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - array.Length];
            }
        }

        public bool Remove(MyItem item)
        {
            if (item != null)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i].GetAge() == item.GetAge())
                    {
                        MyItem[] newArray = new MyItem [_array.Length - 1];
                        for (int j = 0; j < i; i++)
                        {
                            newArray[i] = _array[i];
                        }

                        for (int j = i; j < newArray.Length; j++)
                        {
                            newArray[j] = _array[j+1];
                        }

                        return true;

                    }
                }
            }

            return false;
        }

        public int Count
        {
            get
            {
                return _array.Length;
            }
        }

        public bool IsReadOnly { get; }
        public int IndexOf(MyItem item)
        {
            if (item == null) return -1;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].GetAge() == item.GetAge())
                {
                    return i;
                }

            }


            return -1;
        }

        public void Insert(int index, MyItem item)
        {
            MyItem[] newArray = new MyItem[_array.Length+1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            newArray[index] = item;

            for (int i = index+1; i < newArray.Length; i++)
            {
                newArray[i] = _array[i-1];
            }

        }

        public void RemoveAt(int index)
        {
            MyItem[] newArray = new MyItem[_array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }


            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - 1];
            }

        }

        public MyItem this[int index]
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }
    }
}
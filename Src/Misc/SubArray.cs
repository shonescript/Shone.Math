using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shone
{
    /// <summary>
    /// A generic sub array class
    /// </summary>
    public class SubArray<T> : IList<T>, IReadOnlyList<T>, IList, ICloneable
    {
        protected T[] array = Array.Empty<T>();
        protected int start;
        protected int length;

        public T[] SrcArray => array;
        public int Start => start;
        public int Count => length;
        public int End => start + length;
        public bool IsFixedSize => true;
        public bool IsReadOnly => true;
        public bool IsSynchronized => true;
        public object SyncRoot => this;

        public T this[int i]
        {
            get { return array[start + i]; }
            set { }
        }
        T IReadOnlyList<T>.this[int i] => array[start + i];
        object IList.this[int i]
        {
            get { return array[start + i]; }
            set { }
        }

        public SubArray()
        {
        }
        public SubArray(T[] a)
        {
            array = a;
            length = a.Length;
        }
        public SubArray(T[] a, int i)
        {
            array = a;
            start = i;
            length = a.Length - i;
        }
        public SubArray(T[] a, int i, int k)
        {
            array = a;
            start = i;
            length = k;
        }
        public SubArray(List<T> list)
        {
            var a = (T[])typeof(List<T>).GetField("_items", MyReflection.NonPublicInstance).GetValue(list);
            array = a;
            length = a.Length;
        }

        public bool Contains(T value)
        {
            for (int i = 0, j = start; i < length; i++, j++)
            {
                if (array[i].Equals(value)) return true;
            }
            return false;
        }
        public bool Contains(object value)
        {
            return Contains((T)value);
        }

        public int IndexOf(T value)
        {
            for (int i = 0, j = start; i < length; i++, j++)
            {
                if (array[i].Equals(value)) return i;
            }
            return -1;
        }
        public int IndexOf(object value)
        {
            return IndexOf((T)value);
        }

        public void CopyTo(T[] a, int index)
        {
            Array.Copy(array, start, a, index, length);
        }
        public void CopyTo(Array a, int index)
        {
            Array.Copy(array, start, a, index, length);
        }

        public object Clone()
        {
            return this;
        }


        void IList<T>.Insert(int index, T item)
        {
        }
        void IList.Insert(int index, object value)
        {
        }

        void ICollection<T>.Add(T item)
        {
        }
        int IList.Add(object value)
        {
            return -1;
        }

        bool ICollection<T>.Remove(T item)
        {
            return false;
        }
        void IList.Remove(object value)
        {
        }

        public void RemoveAt(int index)
        {
        }
        public void Clear()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
        {
            private readonly T[] array;
            private readonly int start;
            private readonly int end;
            private int cur;

            public T Current => array[cur];
            object IEnumerator.Current => Current;

            internal Enumerator(SubArray<T> sa)
            {
                array = sa.array;
                start = sa.start;
                end = sa.End;
                cur = start - 1;
            }

            public bool MoveNext()
            {
                if (cur < end)
                {
                    cur++;
                    return cur < end;
                }
                return false;
            }

            void IEnumerator.Reset()
            {
                cur = start - 1;
            }

            public void Dispose()
            {
            }
        }

        public T[] ToArray()
        {
            var a = new T[length];
            Array.Copy(array, start, a, 0, length);
            return a;
        }
    }
}

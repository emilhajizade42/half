using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace indexer
{
    internal class MyType<T>:IEnumerator,IEnumerable,IComparable<MyType<T>>
    {
        public T[] arr ;
        
        public T this[int index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        int position = -1;




        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = item;

        }
        public void Resizeable(bool a)
        {
         
        }
     


        public MyType( )
        {
            arr = new T[0];
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < arr.Length);
        }
        //IEnumerable
        public void Reset()
        {
            position = -1;
        }

        public int CompareTo([AllowNull] MyType<T> other)
        {
            throw new NotImplementedException();
        }

        //IEnumerable
        public object Current
        {
            get { return arr[position]; }
        }
    }
}

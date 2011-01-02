/*
 * CircularArray.cs
 *  circular array
 *
 * by janus_wel<janus.wel.3@gmail.com>
 * This source code is in public domain, and has NO WARRANTY.
 * */

using System;                       // for Array, Math
using System.Collections.Generic;   // for ICollection<>, IEnumerable<>
using System.Collections;           // for IEnumerator

namespace Utility.Data
{
    /// <summary>
    /// circular array class
    /// </summary>
    /// <typeparam name="T">a type to handle</typeparam>
    public class CircularArray<T> : ICollection<T>, IEnumerable<T>
    {
        /// <summary>
        /// default length
        /// This value is used when default constructor is called to create instances of this class.
        /// </summary>
        protected const int defaultLength = 1024;

        /// <summary>
        /// getter for the field "defaultLength"
        /// </summary>
        public int DefaultLength
        {
            get { return defaultLength; }
        }

        /// <summary>
        /// length
        /// This value shows the length of array.
        /// </summary>
        protected readonly int length;

        /// <summary>
        /// getter for the field "length"
        /// </summary>
        public int Length
        {
            get { return length; }
        }

        /// <summary>
        /// an array as an entity
        /// </summary>
        protected T[] elements;

        /// <summary>
        /// a variable to indicate head position of array.
        /// </summary>
        protected int head = 0;

        /// <summary>
        /// a variable to indicate foot position of array.
        /// </summary>
        protected int foot = 0;

        /// <summary>
        /// a variable to indicate a number of items in an array.
        /// </summary>
        protected int count = 0;

        /// <summary>
        /// default constructor
        /// </summary>
        public CircularArray()
        {
            this.length = this.DefaultLength;
            this.elements = new T[length];
        }

        /// <summary>
        /// parameter constructor
        /// </summary>
        /// <param name="length">a length of array</param>
        public CircularArray(int length)
        {
            this.length = length;
            this.elements = new T[length];
        }

        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="index">an index to get</param>
        /// <returns>item</returns>
        public T this[int index]
        {
            get
            {
                return elements[(head + index) % Length];
            }
        }

        /// <summary>
        /// Adds item to collection.
        /// </summary>
        /// <param name="item">an item to add</param>
        public void Add(T item)
        {
            elements[foot] = item;
            foot = (foot + 1) % Length;
            if (Count == Length) head = foot;
            if (Count < Length) ++count;
        }

        /// <summary>
        /// Erases all items in collection.
        /// </summary>
        public void Clear()
        {
            Array.Clear(elements, 0, elements.Length);
            this.count = 0;
        }

        /// <summary>
        /// Checks that collection has the indicated item.
        /// </summary>
        /// <param name="item">an item to check</param>
        /// <returns>true if collection has "item", otherwise false</returns>
        public bool Contains(T item)
        {
            return (Array.IndexOf<T>(elements, item) != -1)
                ? true
                : false;
        }

        /// <summary>
        /// Copies items to other array.
        /// </summary>
        /// <param name="array">an array to be copied</param>
        /// <param name="arrayIndex">a start position to copy</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// getter to return a number of added items
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// what's this?
        /// </summary>
        public bool IsReadOnly
        {
            get { return elements.IsReadOnly; }
        }

        /// <summary>
        /// Removes indicated item from collection.
        /// </summary>
        /// <param name="item">an item to remove</param>
        /// <returns>true if removing succeed, otherwise false?</returns>
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// for foreach
        /// </summary>
        /// <returns>items</returns>
        public IEnumerator<T> GetEnumerator()
        {
            int left = Count;
            for (int i = head; i < Length && 0 < left; ++i, --left)
            {
                yield return elements[i];
            }

            for (int i = 0; i < head && 0 < left; ++i, --left)
            {
                yield return elements[i];
            }
        }

        /// <summary>
        /// for foreach
        /// </summary>
        /// <returns>items</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

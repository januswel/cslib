/*
 * Pair.cs
 *  std::pair in C++
 *
 * by janus_wel<janus.wel.3@gmail.com>
 * This source code is in public domain, and has NO WARRANTY.
 * */

using System;

namespace Utility.Data
{
    /// <summary>
    /// pair
    /// </summary>
    /// <typeparam name="T">first type</typeparam>
    /// <typeparam name="U">second type</typeparam>
    public class Pair<T, U> : IEquatable<Pair<T, U>>, IComparable<Pair<T, U>>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        /// <summary>
        /// accessor for first element
        /// </summary>
        public T First { get; set; }

        /// <summary>
        /// accessor for second element
        /// </summary>
        public U Second { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Pair() { }

        /// <summary>
        /// initialize constructor
        /// </summary>
        /// <param name="first">first value</param>
        /// <param name="second">second value</param>
        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// check equivalence
        /// </summary>
        /// <param name="other">test object</param>
        /// <returns>true if this and object are equivalent, otherwise false</returns>
        public bool Equals(Pair<T, U> other)
        {
            return this.First.Equals(other.First) && this.Second.Equals(other.Second);
        }

        /// <summary>
        /// check equivalence
        /// </summary>
        /// <param name="obj">test object</param>
        /// <returns>true if this and object are equivalent, otherwise false</returns>
        public override bool Equals(object obj)
        {
            Pair<T, U> other = obj as Pair<T, U>;
            return (other != null) ? Equals(other) : false;
        }

        /// <summary>
        /// calculates hash
        /// </summary>
        /// <returns>hash</returns>
        public override int GetHashCode()
        {
            return this.First.GetHashCode() ^ this.Second.GetHashCode();
        }
        
        /// <summary>
        /// compare to other object
        /// </summary>
        /// <param name="other">target to compare</param>
        /// <returns>negative value if "this" is lower than "other", positive value if "this" is higher than "other", otherwise 0</returns>
        public int CompareTo(Pair<T, U> other)
        {
            int firstOrder = this.First.CompareTo(other.First);
            return (firstOrder != 0)
                ? firstOrder
                : this.Second.CompareTo(other.Second);
        }
    }
}

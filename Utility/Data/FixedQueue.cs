/*
 * FixedQueue.cs
 *  A queue that has fixed length
 *
 * by janus_wel<janus.wel.3@gmail.com>
 * This source code is in public domain, and has NO WARRANTY.
 * */

namespace Utility.Data
{
    public class FixedQueue<T> : System.Collections.Generic.Queue<T>
    {
        /// <summary>
        /// default length
        /// This value is used when default constructor is called to create instances.
        /// </summary>
        protected const int defaultLength = 4096;

        /// <summary>
        /// getter for the field "defaultLength"
        /// </summary>
        public int DefaultLength
        {
            get { return defaultLength; }
        }

        /// <summary>
        /// length
        /// This value shows the length of fixed queue.
        /// </summary>
        protected int length;

        /// <summary>
        /// getter for the field "length"
        /// </summary>
        public int Length
        {
            get { return this.length; }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public FixedQueue()
        {
            this.length = DefaultLength;
        }

        /// <summary>
        /// parameter constructor
        /// </summary>
        /// <param name="length">a number that indicates the length of queue</param>
        public FixedQueue(int length)
        {
            this.length = length;
        }

        /// <summary>
        /// a method to enqueue
        /// </summary>
        /// <param name="item">an item to enqueue</param>
        public new void Enqueue(T item)
        {
            if (this.length <= this.Count)
            {
                this.Dequeue();
            }
            base.Enqueue(item);
        }
    }
}

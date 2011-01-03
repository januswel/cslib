/*
 * Bind.cs
 *  definitions of static functions to bind a paramter to the function which has two arguments
 *
 * by janus_wel<janus.wel.3@gmail.com>
 * This source code is in public domain, and has NO WARRANTY.
 * */

using System;   // for Action<>, Converter<>, Predicate<>

namespace Utility
{
    /// <summary>
    /// static functions to bind a parameter to the function which has two arguments
    /// </summary>
    public partial class Function
    {
        /*
         * These delegate and functions conflict with the counterparts about Predicate<>.
         * The matter is format of Generics parameters is same ?
        /// <summary>
        /// a delegate which has two arguments and the "void" type return value
        /// two arguments version of System.Action<>
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <param name="param1">1st argument</param>
        /// <param name="param2">2nd argument</param>
        public delegate void TwoArgumentsAction<T1, T2>(T1 param1, T2 param2);

        /// <summary>
        /// a function to bind 1st argument to the two arguments action function
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <param name="action">the action function which has two arguments</param>
        /// <param name="param1">1st argument</param>
        /// <returns>1st argument bound action</returns>
        public static Action<T2> Bind1st<T1, T2>(TwoArgumentsAction<T1, T2> action, T1 param1)
        {
            return delegate(T2 param2)
            {
                action(param1, param2);
            };
        }

        /// <summary>
        /// a function to bind 2nd argument to the two arguments action function
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <param name="action">the action function which has two arguments</param>
        /// <param name="param2">2nd argument</param>
        /// <returns>2nd argument bound action</returns>
        public static Action<T1> Bind2nd<T1, T2>(TwoArgumentsAction<T1, T2> action, T2 param2)
        {
            return delegate(T1 param1)
            {
                action(param1, param2);
            };
        }
         * */

        /// <summary>
        /// a delegate which has two arguments and one return value
        /// two arguments version of System.Converter<>
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <typeparam name="TReturn">return value type</typeparam>
        /// <param name="param1">1st argument</param>
        /// <param name="param2">2nd argument</param>
        /// <returns>converted value</returns>
        public delegate TReturn TwoArgumentsConverter<T1, T2, TReturn>(T1 param1, T2 param2);

        /// <summary>
        /// a function to bind 1st argument to the two arguments converter function
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <typeparam name="TReturn">return value type</typeparam>
        /// <param name="converter">the converter function which has two arguments</param>
        /// <param name="param1">1st argument</param>
        /// <returns>1st argument bound converter</returns>
        public static Converter<T2, TReturn> Bind1st<T1, T2, TReturn>(TwoArgumentsConverter<T1, T2, TReturn> converter, T1 param1)
        {
            return delegate(T2 param2)
            {
                return converter(param1, param2);
            };
        }

        /// <summary>
        /// a function to bind 2nd argument to the two arguments converter function
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <typeparam name="TReturn">return value type</typeparam>
        /// <param name="converter">the converter function which has two arguments</param>
        /// <param name="param2">2nd argument</param>
        /// <returns>2nd argument bound converter</returns>
        public static Converter<T1, TReturn> Bind2nd<T1, T2, TReturn>(TwoArgumentsConverter<T1, T2, TReturn> converter, T2 param2)
        {
            return delegate(T1 param1)
            {
                return converter(param1, param2);
            };
        }

        /// <summary>
        /// a delegate which has two arguments and the "bool" type return value
        /// two arguments version of System.Predicate<>
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <param name="param1">1st argument</param>
        /// <param name="param2">2nd argument</param>
        /// <returns>a result of evaluating the predicate</returns>
        public delegate bool TwoArgumentsPredicate<T1, T2>(T1 param1, T2 param2);

        /// <summary>
        /// a function to bind 1st argument to the two arguments predicate function
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <param name="predicate">the predicate function which has two arguments</param>
        /// <param name="param1">1st argument</param>
        /// <returns>1st argument bound predicate</returns>
        public static Predicate<T2> Bind1st<T1, T2>(TwoArgumentsPredicate<T1, T2> predicate, T1 param1)
        {
            return delegate(T2 param2)
            {
                return predicate(param1, param2);
            };
        }

        /// <summary>
        /// a function to bind 2nd argument to the two arguments predicate function
        /// </summary>
        /// <typeparam name="T1">1st argument type</typeparam>
        /// <typeparam name="T2">2nd argument type</typeparam>
        /// <param name="predicate">the predicate function which has two arguments</param>
        /// <param name="param2">2nd argument</param>
        /// <returns>2nd argument bound predicate</returns>
        public static Predicate<T1> Bind2nd<T1, T2>(TwoArgumentsPredicate<T1, T2> predicate, T2 param2)
        {
            return delegate(T1 param1)
            {
                return predicate(param1, param2);
            };
        }
    }
}

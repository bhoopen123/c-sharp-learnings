
using System;
using System.Collections.Generic;

namespace CoAndContra_Variance
{
    public interface IOperations<T> : IReadOperations<T>, IWriteOperations<T> where T : class
    {

    }

    public interface IReadOperations<out T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
    }

    public interface IWriteOperations<in T> : IDisposable where T : class
    {
        void Add(T repository);
        void Remove(T repository);
    }

    public class Operations<T> : IOperations<T>, IDisposable where T : class
    {
        public void Add(T employee)
        {
            // adding employee
        }

        public void Dispose()
        {
            // dispose here
        }

        public IEnumerable<T> GetAll()
        {
            return null;
        }

        public void Remove(T employee)
        {
            // removing employee
        }
    }
}

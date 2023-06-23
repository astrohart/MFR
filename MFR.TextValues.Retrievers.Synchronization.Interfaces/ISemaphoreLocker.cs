using System;
using System.Threading.Tasks;

namespace MFR.TextValues.Retrievers.Actions.Interfaces
{
    public interface ISemaphoreLocker
    {
        Task LockAsync(Func<Task> worker);
        Task<T> LockAsync<T>(Func<Task<T>> worker);
    }
}
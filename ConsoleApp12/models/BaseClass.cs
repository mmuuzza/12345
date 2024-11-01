using System.Threading;

namespace YourProjectNamespace.Models
{
    public abstract class BaseClass
    {
        private static int _idCounter = 0;
        public int Id { get; private set; }

        protected BaseClass()
        {
            Id = Interlocked.Increment(ref _idCounter);
        }
    }
}
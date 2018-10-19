using System;

namespace CRDT
{
    // monotonic join semi-lattace
    public class CRDT
    {

    }

    public interface ICRDT<T>
    {
        T Merge(params T[] states);
        T Value();
    }

    public class GCounter : ICRDT<ulong>
    {
        private ulong _localState; 
        public GCounter(ulong initial = 0)
        {
            _localState = initial;
        }
        public void Increment()
        {
            _localState++;
        }
        public ulong Merge(params ulong[] states)
        {
            throw new NotImplementedException();
        }

        public ulong Value()
        {
            throw new NotImplementedException();
        }
    }

    public class Integer
    {
        public ulong _positive;
        public ulong _negative;

        public Integer()
        {
            _positive = 0L;
            _negative = 0L;
        }

        public long Value()
        {
            return (long)(_positive - _negative);
        }

        public void Increment()
        {
            _positive++;
        }
        public void Decrement()
        {
            _negative++;
        }
    }
}

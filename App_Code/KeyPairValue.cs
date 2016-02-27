using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffe
{
    class KeyValuePair<TKey, TValue>
    {
        private TKey key;
        private TValue value;

        public KeyValuePair(TKey key, TValue val)
        {
            this.key = key;
            this.value = val;
        }

        public TKey Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        public TValue Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public void Print()
        {
            Console.WriteLine("Key: " + this.key);
            Console.WriteLine("Value: " + this.value);
        }
        
        public void AddToDictionary(Dictionary<TKey, TValue> a)
        {
            a.Add(this.key, this.value);
        }
    }
}

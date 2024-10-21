using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    class FakeItem : IComparable
    {
        public int RandomNumber { get; set; }

        public FakeItem()
        {
            Random rand = new Random();

            RandomNumber = rand.Next(0, 999999999); // Generates a random integer within the specified range

        }

        public int CompareTo(object? obj)
        {
            if (obj == null) { return -1; }

            return RandomNumber - (obj as FakeItem).RandomNumber;
        }
    }
}

using System;

namespace Appalachia.Utility.Overlays.IngameDebugConsole
{
    public class DebugLogIndexList
    {
        private int[] indices;
        private int size;

        public DebugLogIndexList()
        {
            indices = new int[64];
            size = 0;
        }

        public int Count => size;
        public int this[int index] => indices[index];

        public void Add(int index)
        {
            if (size == indices.Length)
            {
                Array.Resize(ref indices, size * 2);
            }

            indices[size++] = index;
        }

        public void Clear()
        {
            size = 0;
        }

        public int IndexOf(int index)
        {
            return Array.IndexOf(indices, index);
        }
    }
}

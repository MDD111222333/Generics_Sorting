using System.Collections.Generic;

namespace Generics_Sorting
{
    public class NameComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return string.Compare(x.Name, y.Name);
        }
    }
}
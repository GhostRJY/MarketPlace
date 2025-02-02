using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class BookCreator
    {
        static public IProduct CreateBook(
            string brand,
            string name,
            double price,
            string description,
            string author,
            string genre)
        {
            return new Book(brand, name, price, description, author, genre);
        }
    }
}

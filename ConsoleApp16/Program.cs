using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniga_list bookList = new Kniga_list();
                Kniga book = new Kniga("IIIerlak Xolms");
                Kniga book2 = new Kniga("Svinka Pepa");
                Kniga book3 = new Kniga("Simpsnons ");
                Kniga book4 = new Kniga("Domentos");
            bookList.Add(book);
            bookList.Add(book2);
            bookList.Add(book3);
            Kniga_list bookListen = new Kniga_list();
            bookListen = bookList + book4;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Kniga
    {
        public string Imya { get; set; }
        public Kniga() { }
        public Kniga(string imya)
        {
            Imya = imya;
        }
        public override string ToString()
        {
            return Imya;
        }
    }

    internal class Kniga_list
    {
        static private int count = 0;
        private Kniga[] list = new Kniga[count];

        public Kniga_list() { }
        public Kniga_list(Kniga[] books)
        {
            this.list = books;
        }

        public void Add(Kniga a)
        {
            count++;
            Kniga_list buf = new Kniga_list();
            for (int i = 0; i < count - 1; i++)
                buf.list[i] = this.list[i];
            buf.list[count - 1] = a;
            this.list = buf.list;
        }
        public void Delete(Kniga a)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (list[i].Imya == a.Imya)
                    index = i;
            if (index == -1)
            {
                Console.WriteLine("Don't find this book");
                return;
            }
            count--;
            Kniga_list buf = new Kniga_list();
            for (int i = 0, j = 0; i <= count; i++)
            {
                if (i != index)
                {
                    buf.list[j] = list[i];
                    j++;
                }
            }
            this.list = buf.list;
        }
        public override string ToString()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine($"{i + 1}. {list[i]}");
            return "";
        }

        public static Kniga_list operator +(Kniga_list a, Kniga b)
        {
            count++;
            Kniga_list buf = new Kniga_list();
            for (int i = 0; i < count - 1; i++)
                buf.list[i] = a.list[i];
            buf.list[count - 1] = b;
            return buf;
        }
        public static Kniga_list operator -(Kniga_list a, Kniga b)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (a.list[i].Imya == b.Imya)
                    index = i;
            if (index == -1)
            {
                Console.WriteLine("This book don't have");
                return a;
            }
            count--;
            Kniga_list buf = new Kniga_list();
            for (int i = 0, j = 0; i < count; i++)
            {
                if (i != index)
                {
                    buf.list[j] = a.list[i];
                    j++;
                }
            }
            return buf;
        }
        public static bool operator ==(Kniga_list a, Kniga b)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (a.list[i].Imya == b.Imya)
                    index = i;
            if (index == -1)
                return false;
            else
                return true;
        }
        public static bool operator !=(Kniga_list a, Kniga b)
        {
            return !(a == b);
        }

        public void Search(string a)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (list[i].Imya == a)
                    index = i;
            if (index == -1)
                Console.WriteLine("There is no such book");
            else
                Console.WriteLine($"The book is listed under{index + 1}");
        }


        public string this[int indexasiya]
        {
            get
            {
                if (indexasiya >= list.Length || indexasiya < 0)
                    throw new Exception("Invalid index");
                else
                    return list[indexasiya].Imya;
            }
            set
            {
                if (indexasiya >= list.Length || indexasiya < 0)
                    throw new Exception("Incorrect index");
                else
                    list[indexasiya].Imya = value;
            }
        }

    }
}

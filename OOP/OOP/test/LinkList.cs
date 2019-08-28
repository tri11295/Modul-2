using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test
{
    class LinkList
    {
        public static void Main()
        {
            LinkedList<String> Relationship = new LinkedList<string>();

            Relationship.AddFirst("Khoa");

            var node = Relationship.First;
            Relationship.AddAfter(node, "Phong");

            var tu = Relationship.Find("Phong");
            Relationship.AddAfter(tu, "Tu");

            var findPhong = Relationship.Find("Phong");
            Relationship.AddAfter(findPhong, "Loc");

            foreach(var rel in Relationship)
            {
                Console.WriteLine("Item : {0}", rel);
            }
        }
    }
}

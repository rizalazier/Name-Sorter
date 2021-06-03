using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace KstTest.Class
{
    class Jobs
    {
        private static readonly string basepath = Environment.CurrentDirectory;
        private static readonly string unsortedPath = Path.Combine(Directory.GetParent(basepath).Parent.Parent.FullName, @"Content\UnsortedNames\unsorted-names-list.txt");
        private static readonly string sortedPath = Path.Combine(Directory.GetParent(basepath).Parent.Parent.FullName, @"Content\SortedNames\sorted-names-list.txt");
        private static string[] names;

        public static string ReadNamesText() 
        {
            names = File.ReadAllLines(unsortedPath);
            return String.Join(Environment.NewLine, names);
        }

        public static string SortNamesText()
        {
            Array.Sort<string>(names);
            return String.Join(Environment.NewLine, names);
        }

        public static void WriteNamesText()
        {
            File.WriteAllText(sortedPath, String.Join(Environment.NewLine, names));
        }
    }
}

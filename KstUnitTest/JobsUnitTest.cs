using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using KstTest.Class;

namespace KstUnitTest
{
    [TestClass]
    public class JobsUnitTest
    {
        private static readonly string basepath = Environment.CurrentDirectory;
        private static readonly string unsortedPath = Path.Combine(Directory.GetParent(basepath).Parent.Parent.FullName, @"Content\UnsortedNames\unsorted-names-list.txt");
        private static readonly string sortedPath = Path.Combine(Directory.GetParent(basepath).Parent.Parent.FullName, @"Content\SortedNames\sorted-names-list.txt");
        private string[] unsortedNames {
            get { return File.ReadAllLines(unsortedPath); }
        }
        private string[] sortedNames {
            get { return File.ReadAllLines(sortedPath); }
        }

        [TestMethod]
        public void ReadSortTest()
        {
            var jobs = new Jobs();
            string unsortEx = String.Join(Environment.NewLine, unsortedNames);
            string sortEx = String.Join(Environment.NewLine, sortedNames);
            string resultUnsort = jobs.ReadNamesText();
            string resultSort = jobs.SortNamesText();

            Assert.AreEqual(unsortEx, resultUnsort, "Read Names Text is Incorrect");
            Assert.AreEqual(sortEx, resultSort, "Read Names Text is Incorrect");
        }

        [TestMethod]
        public void ReadTest()
        {
            var jobs = new Jobs();
            string unsortEx = String.Join(Environment.NewLine, unsortedNames);
            string resultUnsort = jobs.ReadNamesText();

            Assert.AreEqual(unsortEx, resultUnsort, "Read Names Text is Inorrect");
        }

        [TestMethod]
        public void SortTest()
        {
            var jobs = new Jobs();
            string sortEx = String.Join(Environment.NewLine, sortedNames);
            string resultSort = jobs.SortNamesText();

            Assert.AreEqual(sortEx, resultSort, "Read Names Text is Inorrect");
        }
    }
}

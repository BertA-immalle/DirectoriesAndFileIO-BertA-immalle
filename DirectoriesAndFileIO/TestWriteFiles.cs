using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    class TestWriteFiles
    {

        [TestClass]
        public class TestReadFiles
        {
            string testDir = "";
            string fileA = "";
            string fileAContents = "";
            string fileB = "";
            string fileBContents = "Hallo \nIk ben Bert Anthonissen";
            string subDir = "";
            string subDirFile = "";
            string subDirFileContents = "";

            [TestInitialize]
            public void Initialize()
            {
                // Create a test-directory with known files and directories
                testDir = "testDir";
                fileA = Path.Combine(testDir, "a.txt");
                fileB = Path.Combine(testDir, "b.txt");
                subDir = Path.Combine(testDir, "subDir");
                subDirFile = Path.Combine(subDir, subDirFile);
                fileAContents = "This is a.txt.";
                fileBContents = "This is b.txt.";
                subDirFileContents = "This is a file in a sub-directory.";

                Directory.CreateDirectory(testDir);
                File.WriteAllText(fileA, fileAContents);
                File.WriteAllText(fileB, fileBContents);
                Directory.CreateDirectory(subDir);
            }

            [TestCleanup]
            public void CleanUp()
            {
                if (Directory.Exists(testDir))
                {
                    Directory.Delete(testDir, true);
                }
            }

            [TestMethod]
            public void TestWriteAllText()
            {
                string txt1 = File.WriteAllText(fileA, "this is a file named a.txt");
                Assert.AreEqual(fileAContents,txt1);
            }

            [TestMethod]
            public void TestWriteAllLines()
            {
            }

            [TestMethod]
            public void TestStreamWriter()
            {
            }
        }
    }
}

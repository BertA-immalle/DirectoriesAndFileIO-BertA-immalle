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
            string[] fileBContents = new string[] { "Hallo", "Ik ben Bert Anthonissen" };
            string subDir = "";
            string subDirFile = "";
            string subDirFileContents = "";

            [TestInitialize]
            public void Initialize()
            {
                // Create a test-directory with unknown files and directories
                testDir = "testDir";
                fileA = Path.Combine(testDir, "a.txt");
                fileB = Path.Combine(testDir, "b.txt");
                subDir = Path.Combine(testDir, "subDir");
                subDirFile = Path.Combine(subDir, subDirFile);
                fileAContents = "This is a.txt.";
                subDirFileContents = "This is a file in a sub-directory.";

                Directory.CreateDirectory(testDir);
                File.WriteAllText(fileA, fileAContents);
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
                StreamReader reader = new StreamReader(fileA);
                string result = reader.ReadToEnd();
                Assert.AreEqual(result,fileAContents);
                reader.Close();
            }

            [TestMethod]
            public void TestWriteAllLines()
            {
                File.WriteAllLines(fileB, fileBContents);
                StreamReader reader = new StreamReader(fileB);
                string result = reader.ReadToEnd();
                Assert.AreEqual(result, "one\r\ntwo\r\n");
                reader.Close();
            }

            [TestMethod]
            public void TestStreamWriter()
            {
                StreamWriter writer = new StreamWriter(fileA);
                writer.Write(fileAContents);
                writer.Close();

                StreamReader reader = new StreamReader(fileA);
                var testreader = reader.ReadToEnd();
                reader.Close();
                Assert.AreEqual(testreader, fileAContents);
            }
        }
    }
}

﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DirectoriesAndFileIO
{
    [TestClass]
    public class TestReadFiles
    {
        string testDir = "";
        string fileA = "";
        string fileAContents = "";
        string fileB = "";
        string fileBContents = "Hallo \n Ik ben bert";
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
        public void TestFileReadAllText()
        {
            string txtA = File.ReadAllText(fileA);
            string txtB = File.ReadAllText(fileB);

            Assert.AreEqual(fileAContents, txtA);
            Assert.AreEqual(fileBContents, txtB);
        }

        [TestMethod]
        public void TestReadAllLines()
        {
            string[] linesA = File.ReadAllLines(fileA);
            string[] linesB = File.ReadAllLines(fileB);

            Assert.AreEqual(1, linesA.Length);
            Assert.AreEqual(fileAContents, linesA[0]);

            Assert.AreEqual(2, linesB.Length);
            Assert.AreEqual(fileBContents, linesB[0]);
        }

        [TestMethod]
        public void TestFileOpenText()
        {
            using (StreamReader sr = File.OpenText(fileA))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        [TestMethod]
        public void TestStreamReader()
        {
            StreamReader s = new StreamReader(fileA);

            string txt = s.ReadToEnd();
            Assert.AreEqual(fileAContents, txt);

            s.Close();
        }

        [TestMethod]
        public void TestFileStream()
        {
            byte[] data = new byte[20];

            FileStream stream = File.OpenRead(fileA);
            int r = stream.Read(data, 0, 20);

            string txt = "";
            foreach(byte b in data)
            {
                if(b != 0)
                {
                    txt += (char)b;
                }
            }

            Assert.AreEqual(fileAContents.Length, r);
            Assert.AreEqual(fileAContents, txt);

            stream.Close();
        }

        

    }
}

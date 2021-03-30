using FileChecking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectForTesting
{
    [TestClass]
    public class FileNameTest
    {
        [TestMethod]
        public void TestFileName_FileNameExpectedNameId_NameVersionIdSet()
        {
            //Arrange 
            string newName = "file_1.pdf";

            // Act
            File fileClass = new File(newName);

            //Assert
            Assert.AreEqual("file_1", fileClass.Name);
            Assert.AreEqual(1, fileClass.VersionId);
        }
        [TestMethod]
        public void TestFileName_FileWithoutVersionId_VersionZero()
        {
            //Arrange 
            string newName = "file.pdf";

            // Act
            File fileClass = new File(newName);

            //Assert
            Assert.AreEqual("file", fileClass.Name);
            Assert.AreEqual(0, fileClass.VersionId);
        }
    }
}

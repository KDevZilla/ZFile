using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using ZFilesUtils;

namespace ZFilesTest
{
    [TestClass]
    public class DeleteFileTest
    {
        static String PrepareData01Path = @"D:\Test\ZFilesTest\PrepareData01\";
        [TestMethod]
        public static void PrapareData()
        {
            String Path = @"D:\Test\ZFilesTest\";
            List<String> fileNames = new List<string>(){
                "File001.txt","File002.txt","Excel999.xlsx"
            };
            fileNames.ForEach(x => File.Copy($"{Path}{x}", $@"{PrepareData01Path}{x}", overwrite: true));

        }

        [TestMethod]
        public void DeleteFile()
        {
            DeleteFileTest.PrapareData();

            ZFilesUtils.DeleteFiles del = new DeleteFiles();

            
            List<String> fileNames = new List<string>(){
                $"{PrepareData01Path}File001.txt",
                $"{PrepareData01Path}File002.txt",
                $"{PrepareData01Path}Excel999.xlsx"
            };
            DeleteFileResult deleteResult= del.DeleteFile(fileNames,true);
            Assert.IsTrue(deleteResult.FileDeleted.Count == 3);
            Assert.IsTrue(deleteResult.FileCannotDeleted.Count == 0);
            int i;
            for (i = 0; i < fileNames.Count; i++)
            {
                Assert.IsTrue(deleteResult.FileDeleted[i] == fileNames[i]);
            }
            for (i = 0; i < fileNames.Count; i++)
            {
                Assert.IsFalse(System.IO.File.Exists (  fileNames[i]));
            }


            ZFilesUtils.SearchFile search = new ZFilesUtils.SearchFile();
            SearchFileResult searchResult = search.SearchListOfFiles(fileNames);
            Assert.IsTrue(searchResult.FileFound.Count == 0);
            Assert.IsTrue(searchResult.FileNotFound.Count == 3);

    
        }


        [TestMethod]
        public void DeleteNonExistFile()
        {
            DeleteFileTest.PrapareData();

            ZFilesUtils.DeleteFiles del = new DeleteFiles();


            List<String> fileNames = new List<string>(){
                $"{PrepareData01Path}File001.txt",
                $"{PrepareData01Path}File002.txt",
                $"{PrepareData01Path}NonExist.xlsx"
            };
            DeleteFileResult deleteResult = del.DeleteFile(fileNames, ifFileNotExistCountAsError: true);
            Assert.IsTrue(deleteResult.FileDeleted.Count == 2);
            Assert.IsTrue(deleteResult.FileCannotDeleted.Count == 1);
            int i;
            for (i = 0; i < 2; i++)
            {
                Assert.IsTrue(deleteResult.FileDeleted[i] == fileNames[i]);
            }
            for (i = 0; i < fileNames.Count; i++)
            {
                Assert.IsFalse(System.IO.File.Exists(fileNames[i]));
            }
            Assert.IsTrue(deleteResult.FileCannotDeleted[0].FileName == fileNames[2]);
            Assert.IsTrue(deleteResult.FileCannotDeleted[0].ExceptionFromDelete != null);

            DeleteFileTest.PrapareData();


            deleteResult = del.DeleteFile(fileNames, ifFileNotExistCountAsError: false);
            Assert.IsTrue(deleteResult.FileDeleted.Count == 3);
            Assert.IsTrue(deleteResult.FileCannotDeleted.Count == 0);

            for (i = 0; i < fileNames.Count ; i++)
            {
                Assert.IsTrue(deleteResult.FileDeleted[i] == fileNames[i]);
            }
            for (i = 0; i < fileNames.Count; i++)
            {
                Assert.IsFalse(System.IO.File.Exists(fileNames[i]));
            }
           
        }
    }
}

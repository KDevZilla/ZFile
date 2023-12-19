using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using ZFilesUtils;
namespace ZFilesTest
{
    [TestClass]
    public class SearchFileTest
    {
        //Prepare need to be run first before running search Testing
        static String PrepareData01Path = @"D:\Test\ZFilesTest\PrepareData01\";
        [TestMethod]
        public static  void PrapareData()
        {
            String Path = @"D:\Test\ZFilesTest\";
            List<String> fileNames = new List<string>(){
                "File001.txt","File002.txt","Excel999.xlsx"
            };
            fileNames.ForEach(x => File.Copy($"{Path}{x}", $@"{PrepareData01Path}{x}",overwrite :true));
            
        }

        [TestMethod]
        public void SearchByPattern()
        {
            SearchFileTest.PrapareData();

            ZFilesUtils.SearchFile search = new ZFilesUtils.SearchFile();
            List<String> listFileFound = search.SearchByPattern(PrepareData01Path, "*.xlsx");
            Assert.IsTrue(listFileFound.Count == 1);
            Assert.IsTrue(listFileFound[0] == $"{PrepareData01Path}Excel999.xlsx");


            listFileFound = search.SearchByPattern(PrepareData01Path, "*.txt");
            Assert.IsTrue(listFileFound.Count == 2);
            Assert.IsTrue(listFileFound[0] == $"{PrepareData01Path}File001.txt");
            Assert.IsTrue(listFileFound[1] == $"{PrepareData01Path}File002.txt");


        }
        [TestMethod]
        public void SearchListOfFiles()
        {
            SearchFileTest.PrapareData();


            ZFilesUtils.SearchFile search = new ZFilesUtils.SearchFile();
            List<String> fileNames = new List<string>(){
                $"{PrepareData01Path}File001.txt",
                $"{PrepareData01Path}File002.txt",
                $"{PrepareData01Path}Excel999.xlsx"
            };
            SearchFileResult searchResult = search.SearchListOfFiles(fileNames);
            Assert.IsTrue(searchResult.FileFound.Count == 3);
            Assert.IsTrue(searchResult.FileNotFound.Count == 0);
            Assert.IsTrue(searchResult.FileFound[0] == fileNames[0]);
            Assert.IsTrue(searchResult.FileFound[1] == fileNames[1]);
            Assert.IsTrue(searchResult.FileFound[2] == fileNames[2]);


            fileNames = new List<string>(){
                $"{PrepareData01Path}File001.txt",
                $"{PrepareData01Path}FileDoestNotExist.txt",
                $"{PrepareData01Path}Excel999.xlsx"
            };

            searchResult = search.SearchListOfFiles(fileNames);
            Assert.IsTrue(searchResult.FileFound.Count == 2);
            Assert.IsTrue(searchResult.FileNotFound.Count == 1);
            Assert.IsTrue(searchResult.FileFound[0] == fileNames[0]);
            Assert.IsTrue(searchResult.FileFound[1] == fileNames[2]);
            Assert.IsTrue(searchResult.FileNotFound[0]  == fileNames[1]);

            fileNames = new List<string>();
            searchResult = search.SearchListOfFiles(fileNames);
            Assert.IsTrue(searchResult.FileFound.Count == 0);
            Assert.IsTrue(searchResult.FileNotFound.Count == 0);

            //search.SearchListOfFiles ()
        }
    }
}

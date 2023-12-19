using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ZFilesUtils
{
    public class SearchFile
    {
        //public List<String> 
        public List<String> SearchByPattern(String path, String pattern)
            => Directory.EnumerateFiles(path, pattern).ToList();
        
        public SearchFileResult  SearchListOfFiles(List<String> listofFileToSearch)
            =>  new SearchFileResult(listofFileToSearch
                    .Where(file => File.Exists(file))
                    .ToList(),  
                                    listofFileToSearch
                    .Where(file => !File.Exists(file))
                    .ToList());

        
        
    }
}

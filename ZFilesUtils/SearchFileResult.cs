using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFilesUtils
{
    public class SearchFileResult
    {
        public List<String> FileFound { get; private set; } = new List<string>();
        public List<String> FileNotFound { get; private set; } = new List<string>();

        public SearchFileResult (List<String> pFileFound, List<String> pFileNotFound)
        {
            this.FileFound = pFileFound;
            this.FileNotFound = pFileNotFound;
        }
    }
}

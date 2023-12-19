using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFilesUtils
{
    public class DeleteFileResult
    {
        public List<String> FileDeleted { get; private set; } = new List<string>();
        public List<FileCannotDelete> FileCannotDeleted { get; private set; } = new List<FileCannotDelete>();

        public DeleteFileResult(List<String> pFileDeleted, List<FileCannotDelete> pFileCannotDeleted)
        {
            this.FileDeleted = pFileDeleted;
            this.FileCannotDeleted = pFileCannotDeleted;
        }
    }
    public class FileCannotDelete
    {
        public String FileName { get; private set; } = "";
        public Exception ExceptionFromDelete { get; private set; } = null;
        public FileCannotDelete (String pFileName, Exception pException)
        {
            this.FileName = pFileName;
            this.ExceptionFromDelete = pException;
        }
    }
}

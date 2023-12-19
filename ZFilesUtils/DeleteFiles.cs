using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFilesUtils
{
    public class DeleteFiles
    {
        public DeleteFileResult DeleteFile(List<String> listFiles,bool ifFileNotExistCountAsError)
        {
            List<String> FileDeleted = new List<string>();
            List<FileCannotDelete> FileCannotDeleted = new List<FileCannotDelete>();
            int i;
            for (i = 0; i < listFiles.Count; i++)
            {
                String fileName = listFiles[i];
                try
                {
                    if(ifFileNotExistCountAsError && !System.IO.File.Exists(fileName))
                    {
                        throw new Exception("File does not exist");
                    }
                    
                    System.IO.File.Delete(fileName);
                    FileDeleted.Add(fileName);
                    if(System.IO.File.Exists(fileName))
                    {
                        throw new Exception("File still exist after being deleted");
                    }
                }
                catch (Exception ex)
                {
                    FileCannotDelete filecannotdelete = new FileCannotDelete(fileName, ex);
                    FileCannotDeleted.Add(filecannotdelete);
                }
            }
            return new DeleteFileResult(FileDeleted, FileCannotDeleted);

        }
}
}

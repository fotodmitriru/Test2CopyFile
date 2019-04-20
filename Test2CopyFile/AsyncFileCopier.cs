using System.IO;
using System.Threading.Tasks;

namespace Test2CopyFile
{
    public class FileCopyManager
    {
        private string SourceFile { get; set; }
        private string DistanationFile { get; set; }

        public delegate void FileCopyDelegate(string idFile);
        public event FileCopyDelegate CopyCompleted;

        public async Task FileCopy(string sourceFile, string distFile)
        {
            SourceFile = sourceFile;
            DistanationFile = distFile;
            await Task.Run(CopyFileAsync);
        }

        private Task CopyFileAsync()
        {
            string sourceFile = SourceFile;
            string destinationFile = DistanationFile;
            using (var sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read, 4096,
                FileOptions.Asynchronous | FileOptions.SequentialScan))
            {
                using (var destinationStream = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write,
                    FileShare.None, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan))
                    sourceStream.CopyTo(destinationStream);
                CopyCompleted?.Invoke(sourceFile + " -> " + destinationFile);
            }

            return Task.CompletedTask;
        }
    }
}

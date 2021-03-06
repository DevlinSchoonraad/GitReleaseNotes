using System;

namespace GitReleaseNotes.FileSystem
{
    public class ReleaseFileWriter
    {
        private readonly IFileSystem _fileSystem;

        public ReleaseFileWriter(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void OutputReleaseNotesFile(string releaseNotesOutput, string outputFile)
        {
            if (string.IsNullOrEmpty(outputFile))
                return;
            _fileSystem.WriteAllText(outputFile, releaseNotesOutput);
            Console.WriteLine("Release notes written to {0}", outputFile);
        }
    }
}
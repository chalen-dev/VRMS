using System;
using System.IO;

namespace Helpers.DirectoryCleaner
{
    public static class Dir
    {
        /// <summary>
        /// Empties a directory but preserves specific filenames (e.g. .gitignore).
        /// </summary>
        public static void Empty(string rootPath, params string[] preserveFiles)
        {
            if (!Directory.Exists(rootPath))
                return;

            var preserveSet = new HashSet<string>(
                preserveFiles,
                StringComparer.OrdinalIgnoreCase
            );

            // Delete files
            foreach (var file in Directory.GetFiles(rootPath))
            {
                var fileName = Path.GetFileName(file);
                if (preserveSet.Contains(fileName))
                    continue;

                File.Delete(file);
            }

            // Delete subdirectories
            foreach (var dir in Directory.GetDirectories(rootPath))
            {
                Directory.Delete(dir, recursive: true);
            }
        }
    }
}
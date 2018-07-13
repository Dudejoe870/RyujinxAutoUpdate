using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RyujinxAutoUpdate
{
    class GitParser
    {
        public static string GitCurrentBranch(string ProjectPath)
        {
            if (!IsDirectoryEmpty(ProjectPath))
            {
                Process Git = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "git",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                List<string> Output = new List<string>();
                string Result = null;

                Git.StartInfo.Arguments = "-C \"" + ProjectPath + "\" branch";

                Git.OutputDataReceived += (s, e) =>
                {
                    if (!String.IsNullOrWhiteSpace(e.Data)) Output.Add(e.Data);
                };

                Git.ErrorDataReceived += (s, e) =>
                {
                    if (!String.IsNullOrWhiteSpace(e.Data)) Output.Add(e.Data);
                };

                Git.Start();
                Git.BeginOutputReadLine();
                Git.BeginErrorReadLine();

                Git.WaitForExit();

                if (Git.ExitCode != 0)
                {
                    Console.WriteLine("Uh oh!  Git threw an error!");
                    return null;
                }

                foreach (string s in Output)
                {
                    if (s.StartsWith("*"))
                    {
                        Result = Regex.Replace(s, @"\s+", "").Substring(1);
                    }
                }

                return Result;
            }

            return null;
        }

        public static string[] GitBranches(string ProjectPath)
        {
            if (!IsDirectoryEmpty(ProjectPath))
            {
                Process Git = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "git",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                Git.StartInfo.Arguments = "-C \"" + ProjectPath + "\" fetch";
                Git.Start();

                Git.WaitForExit();

                if (Git.ExitCode != 0)
                {
                    Console.WriteLine("Uh oh!  Git threw an error!");
                    return null;
                }

                Git.StartInfo.Arguments = "-C \"" + ProjectPath + "\" branch -r";
                List<string> Output = new List<string>();

                string[] Result;

                Git.OutputDataReceived += (s, e) =>
                {
                    if (!String.IsNullOrWhiteSpace(e.Data)) Output.Add(e.Data.Split('/')[1]);
                };

                Git.ErrorDataReceived += (s, e) =>
                {
                    if (!String.IsNullOrWhiteSpace(e.Data)) Output.Add(e.Data.Split('/')[1]);
                };

                Git.Start();
                Git.BeginOutputReadLine();
                Git.BeginErrorReadLine();

                Git.WaitForExit();

                if (Git.ExitCode != 0)
                {
                    Console.WriteLine("Uh oh!  Git threw an error!");
                    return null;
                }

                Git.Dispose();

                Output.RemoveAt(0);

                Result = Output.ToArray();

                return Result;
            }
            else
            {
                return null;
            }
        }

        private static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}

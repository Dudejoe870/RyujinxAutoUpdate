using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RyujinxAutoUpdate
{
    class GitParser
    {
        public static void GitLoggedIn(string Username, string Email)
        {
            if (String.IsNullOrWhiteSpace(Username) && String.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Login Failed, Username and Email is Empty.", "Error");
                return;
            }

            if (String.IsNullOrWhiteSpace(Username)) {
                MessageBox.Show("Login Failed, Username is Empty.", "Error");
                return;
            }

            if (String.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Login Failed, Email is Empty.", "Error");
                return;
            }

            Process Git = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            Git.StartInfo.Arguments = "-C \"" + MainForm.RyujinxDownloadPath + "\" config user.name \"" + Username + '\"';

            Git.Start();

            Git.WaitForExit();

            if (Git.ExitCode != 0)
            {
                MessageBox.Show("Login Failed!  Git Exit Code: " + Git.ExitCode, "Error");
                Git.Dispose();
                return;
            }

            Git.StartInfo.Arguments = "-C \"" + MainForm.RyujinxDownloadPath + "\" config user.email \"" + Email + '\"';

            Git.Start();

            Git.WaitForExit();

            if (Git.ExitCode != 0)
            {
                MessageBox.Show("Login Failed!  Git Exit Code: " + Git.ExitCode, "Error");
                Git.Dispose();
                return;
            }

            Git.Dispose();

            MessageBox.Show("Login Successful!", "Login");
        }

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

        public static string[] GitRemoteBranches(string ProjectPath)
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RyujinxAutoUpdate
{
    class GitParser
    {
        private static Process Git = new Process
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

        public static string[] GitBranches(string ProjectPath)
        {
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

            Git.OutputDataReceived += (s, e) => {
                if (!String.IsNullOrWhiteSpace(e.Data)) Output.Add(e.Data.Split('/')[1]);
            };

            Git.ErrorDataReceived  += (s, e) => {
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

            Output.RemoveAt(0);

            Result = Output.ToArray();

            return Result;
        }
    }
}

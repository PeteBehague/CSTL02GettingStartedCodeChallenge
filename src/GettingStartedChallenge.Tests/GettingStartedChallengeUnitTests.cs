using System;
using Xunit;
using GettingStartedChallenge;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace SimpleConsoleAppTests
{
    public class GettingStartedChallengeUnitTests
    {
        TextWriter m_normalOutput;
        StringWriter m_testingConsole;
        StringBuilder m_testingSB;

        //User input
        string name = "Fred";
        string age = "22";
        DateTime dob = Convert.ToDateTime("01/01/2000");

        public GettingStartedChallengeUnitTests()
        {
            // Set current folder to testing folder
            //string assemblyCodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string assemblyCodeBase = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dirName = Path.GetDirectoryName(assemblyCodeBase);

            if (dirName.StartsWith("file:\\"))
                dirName = dirName.Substring(6);

            Environment.CurrentDirectory = dirName;

            m_testingSB = new StringBuilder();
            m_testingConsole = new StringWriter(m_testingSB);
            m_normalOutput = System.Console.Out;
            System.Console.SetOut(m_testingConsole);
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(0, StartConsoleApplication(""));
            Assert.Contains($"Hello {name}", m_testingSB.ToString());
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(0, StartConsoleApplication(""));
            Assert.Contains($"You are {age} years old", m_testingSB.ToString());
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(0, StartConsoleApplication(""));
            int numDaysAlive = (new TimeSpan(DateTime.Now.Ticks - dob.Ticks)).Days;
            Assert.Contains($"You are {numDaysAlive} days old", m_testingSB.ToString());
        }

        private int StartConsoleApplication(string arguments)
        {
            //Program.Main(arguments.Split(' '));
            Process proc = new Process();
            proc.StartInfo.FileName = "GettingStartedChallenge.exe";
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.Start();
            proc.StandardInput.WriteLine(name);
            proc.StandardInput.WriteLine(age);
            proc.StandardInput.WriteLine(dob);
            proc.WaitForExit();
            System.Console.WriteLine(proc.StandardOutput.ReadToEnd());
            System.Console.Write(proc.StandardError.ReadToEnd());
            return proc.ExitCode;
        }
    }
}

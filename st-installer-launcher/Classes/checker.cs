using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace test_launcher_winui3.checker;

public class GIT
{
    public enum Action
    {
        Clone,
        Pull,
        Switch
    }

    public static int clone(string url, string path = "")
    {
        if (path == "") { path = Environment.CurrentDirectory; };
        var process = new Process
        {
            StartInfo =
                {
                    FileName = "git",
                    Arguments = $"clone {url} {path}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
        };
        process.Start();
        process.WaitForExit();
        return process.ExitCode;
    }

    /*public GIT(Action action, string url, string path = "", string branch = "master")
    {
        if (path == "")
            path = Environment.CurrentDirectory;

        switch (action)
        {
            case Action.Clone:
                return clone(url, path);
            case Action.Pull:
                break;
            case Action.Switch:
                break;
        }
    }*/
}

public class Checker
{
    public static bool GitInstalled()
    {
        var gitinstalled = false;

        try
        {
            var git = new ProcessStartInfo("git", "--version")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var proc = Process.Start(git);
            if (proc != null)
            {
                proc.WaitForExit();
                if (proc.ExitCode == 0)
                {
                    gitinstalled = true;
                    return true;
                }
            }
            return gitinstalled;
        }
        catch (Exception)
        {
            return gitinstalled;
        }
    }

    public static bool NodeInstalled ()
    {
        var nodeinstalled = false;

        try
        {
            var node = new ProcessStartInfo("node", "--version")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var proc = Process.Start(node);
            if (proc != null)
            {
                proc.WaitForExit();
                if (proc.ExitCode == 0)
                {
                    nodeinstalled = true;
                    return true;
                }
            }
            return nodeinstalled;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public static bool SevenZipInstalled()
    {
        var SevenZipInstalled = false;

        try {
            var sevenzip = new ProcessStartInfo("7z")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var proc = Process.Start(sevenzip);
            if (proc != null)
            {
                proc.WaitForExit();
                if (proc.ExitCode == 0)
                {
                    SevenZipInstalled = true;
                    return true;
                }
            }
            return SevenZipInstalled;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public static string CheckNPM()
    {
        try {
            var npm = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                WorkingDirectory = Environment.CurrentDirectory,
            };
            var npmrun = Process.Start(npm);
            npmrun.StandardInput.WriteLine("npm --version & exit");
            npmrun.WaitForExit();
            if (npmrun.ExitCode == 0)
            {
                return $"Available";
            }
            return $"exit code: {npmrun.ExitCode}";
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return $"Error: {e.Message}";
        }
    }
}
public enum WingetApps
{
    git,
    nodejs,
    sevenZip,
    FFmpeg,
    pwdtest,
}
/**
<summary>
    Check if the winget app is installed

</summary>
<param name="app">The winget app to check</param>
*/
public class AppWingetInfo
{
    // winget show git.git
    private static async Task<int> CheckGIT()
    {
        try
        {
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
            };
            var proc = Process.Start(winget);
            if (proc == null) { return -1; }
            await proc.StandardInput.WriteLineAsync("winget list -q git.git & exit");
            proc.WaitForExit();
            if (proc != null)
            {
                return proc.ExitCode;
            }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }
    // winget show OpenJS.NodeJS
    private static async Task<int> CheckNODE()
    {
        try
        {
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
            };
            var proc = Process.Start(winget);
            if (proc == null) { return -1; }
            await proc.StandardInput.WriteLineAsync("winget list -q OpenJS.NodeJS & exit");
            proc.WaitForExit();
            if (proc != null)
            {
                return proc.ExitCode;
            }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }
    // winget show 7zip.7zip
    private static async Task<int> Check7ZIP()
    {
        try
        {
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
            };
            var proc = Process.Start(winget);
            if (proc == null) { return -1; }
            await proc.StandardInput.WriteLineAsync("winget list -q 7zip.7zip & exit");
            proc.WaitForExit();
            if (proc != null)
            { return proc.ExitCode; }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        } 
    }

    public static async Task<int> Validate(WingetApps app)
    {
        switch (app)
        {
            case WingetApps.git: return await CheckGIT();
            case WingetApps.nodejs: return await CheckNODE();
            case WingetApps.sevenZip: return await Check7ZIP();
            default: return new int();
        }
    }
}
/**
<summary>
    Downloads and installs applications
</summary>
*/
public class ApplicationManager
{
    private static async Task<int> DownloadGIT()
    {
        try
        {
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
            };
            var proc = Process.Start(winget);
            if (proc == null) { return -1; }
            await proc.StandardInput.WriteLineAsync("winget install -e --id Git.Git");
            if (proc != null) { proc.WaitForExit(); return proc.ExitCode; }
            return -1;
        } catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }
    private static async Task<int> DownloadNODE()
    {
        try
        {
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
            };
            var proc = Process.Start(winget);
            if (proc == null) { return -1; }
            await proc.StandardInput.WriteLineAsync("winget install -e --id OpenJS.NodeJS & exit");
            proc.WaitForExit();
            if (proc != null) { return proc.ExitCode; }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }
    private static async Task<int> Download7ZIP()
    {
        try
        {
            // require admin rights
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
            };
            var proc = Process.Start(winget);
            if (proc == null) { return -1; }
            await proc.StandardInput.WriteLineAsync("winget install -e --id 7zip.7zip & exit");
            proc.WaitForExit();
            if (proc != null)
            { return proc.ExitCode; }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }
    private static async Task<int> CWD()
    {
        try
        {
            var winget = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true,
            };
            var proc = Process.Start(winget);
            await proc.StandardInput.WriteLineAsync("cd");
            proc.WaitForExit();
            if (proc != null)
            {
                return proc.ExitCode;
            }
            return -1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }
    public static int DonwloadApplication(WingetApps app)
    {
        switch (app)
        {
            case WingetApps.git: return DownloadGIT().Result;
            case WingetApps.nodejs: return DownloadNODE().Result;
            case WingetApps.sevenZip: return Download7ZIP().Result;
            case WingetApps.pwdtest: return CWD().Result;
            default: return -1;
        }
    }
}
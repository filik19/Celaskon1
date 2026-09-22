using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    static void Main()
    {
        Console.WriteLine("[DEBUG] user32.dll was imported successfully");

        // unused now
        //# uint flags = 0x00000004 | 0x00000040;

        Console.WriteLine("[INFO] Thanks for downloading my little program/game :)");
        Console.WriteLine($"[INFO] Current C# version: {Environment.Version}");
        Console.WriteLine("[INFO] This is a console for debugging, you may minimize it for a better experience.");
        Console.WriteLine("[]");

        int response1 = MessageBox(IntPtr.Zero, "Hello! Do you want to continue?", "Celaskon 1", 0x00000004);


        // 6 = Yes
        // 7 = No
        // 2 = Cancel i think
        switch (response1)
        {
            case 6:
                Console.WriteLine("[DEBUG] yes from response1");
                break;
            case 7:
                Console.WriteLine("[DEBUG] no from response1");
                Console.WriteLine("[DEBUG] Quitting with code 1");
                Environment.Exit(1);
                break;
        }

        MessageBox(IntPtr.Zero, "You started coughing...", "Celaskon 1", 0x00000000 | 0x00000040);
        Console.WriteLine("[DEBUG] comfirmed info1");

        int response2 = MessageBox(IntPtr.Zero, "Do you want to take celaskon?", "Celaskon 1", 0x00000004 | 0x00000020);

        switch (response2)
        {
            case 6:
                Console.WriteLine("[DEBUG] yes from response2");
                MessageBox(IntPtr.Zero, "You got the celaskon... That means...", "Celaskon 1", 0x00000000);
                Console.WriteLine("[DEBUG] comfirmed info2");
                MessageBox(IntPtr.Zero, "YOU LIVE!!", "Celaskon 1", 0x00000000 | 0x00000040);
                Console.WriteLine("[DEBUG] comfirmed info3");
                break;
            case 7:
                Console.WriteLine("[DEBUG] no from response2");
                MessageBox(IntPtr.Zero, "You died.", "Celaskon 1", 0x00000000 | 0x00000030);
                Console.WriteLine("[DEBUG] comfirmed info4");
                break;
        }
        string baseFolder = Environment.CurrentDirectory;
        string endApp = Path.Combine(baseFolder, "CelaskonEnd.exe");

        if (File.Exists(endApp))
        {
            Process.Start(endApp);
        }
        else
        {
            Console.WriteLine("[ERROR] did not find the endApp in the directory");
            MessageBox(IntPtr.Zero, "Did not find the endApp in this directory. May be a coding mistake or user deleted the file.", "ERROR", 0x00000000 | 0x00000030);
            Console.WriteLine($"[DUMP] Dump start here\n  ErrorCode:-2147467259\n  HResult:-2147467259\n  Message:'The system cannot find the file specified.'\n  NativeErrorCode:2\n  InstalledDir: {Environment.CurrentDirectory}\n Host Information:\n  OSVersion: {Environment.OSVersion}\n  MachineName: {Environment.MachineName}\n  C# Version: {Environment.Version}\n  UserName: {Environment.UserName}\n  CPUs: {Environment.ProcessorCount}\n  Is64Bit: {Environment.Is64BitOperatingSystem}\n[DUMP] Dump ends here");
            MessageBox(IntPtr.Zero, "A dump has been written into the console. Please check that you are not missing these files in your InstalledDir:\n'Celaskon 1.exe', 'CelaskonEnd.exe' or similiar\n\nPlease check this before reporting to the developer.", "Default Caption", 0x00000000 | 0x00000030);
            Environment.Exit(-2147467259);
        }
    }
}
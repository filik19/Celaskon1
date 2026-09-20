using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    static void Main()
    {
        Console.WriteLine("If you see this, user32.dll was successfully imported. Yay");

        // unused now
        //# uint flags = 0x00000004 | 0x00000040;

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Dear User.");
        Console.WriteLine("");
        Console.WriteLine("This program is NOT a virus. That means it will NOT damage your computer.");
        Console.WriteLine("More info here:");
        Console.WriteLine("  This program will NOT Delete half of your drive, exactly: /ProgramFiles(x86) ,/ProgramFiles ,/users/* and /windows/system32/cmd.exe");

        int response = MessageBox(IntPtr.Zero, "This is NOT a virus, it will NOT damage your fucking computer. Information on what will it NOT do are dumped in the console window. Please read them before continuing. Do you want to 'continue = true'?", "Celaskon 3000", 0x00000004 | 0x00000040);


        // 6 = Yes
        // 7 = No
        // 2 = smth i guess
        switch (response)
        {
            case 6:
                Console.SetWindowPosition(0, 0);
                Console.WriteLine("Getting chinaManDriver-1.5 from https://youtube.com/@tranium ...");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                break;
            case 7:
                Console.WriteLine("Ass response. Goonbye!");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                break;
            case 2:
                Console.WriteLine("How did you even? its not even an option.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                break;
        }
    }
}
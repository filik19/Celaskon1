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

        Console.WriteLine("Thanks for downloading my little program :)");
        Console.WriteLine("");

        int response1 = MessageBox(IntPtr.Zero, "This is NOT a virus, it will NOT damage your fucking computer. Do you want to 'continue = true'?", "Celaskon 1", 0x00000004);


        // 6 = Yes
        // 7 = No
        // 2 = cancel i think
        switch (response1)
        {
            case 6:
                Console.WriteLine("yes from response1");
                break;
            case 7:
                Console.WriteLine("no from response1");
                break;
            case 2:
                Console.WriteLine(" from response1");
                break;
        }

        MessageBox(IntPtr.Zero, "You started coughing...", "Celaskon 1", 0x00000000 | 0x00000040);

        int response2 = MessageBox(IntPtr.Zero, "Do you want to take celaskon?", "Celaskon 1", 0x00000004 | 0x00000040);

        switch (response2)
        {
            case 6:
                Console.WriteLine("yes from response2");
                MessageBox(IntPtr.Zero, "You got the celaskon... That means...", "Celaskon 1", 0x00000000 | 0x00000040);
                MessageBox(IntPtr.Zero, "YOU LIVE!!", "Celaskon 1", 0x00000000 | 0x00000040);
                break;
            case 7:
                Console.WriteLine("no from response2");
                MessageBox(IntPtr.Zero, "You died.", "Celaskon 1", 0x00000000 | 0x00000040);
                break;
        }


    }
}
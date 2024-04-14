using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
    private const uint MOUSEEVENTF_LEFTUP = 0x04;

    static void Main(string[] args)
    {
        Console.WriteLine("How many clicks do you want?");
        int click = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= click; i++)
        {
            MouseClick();
            Console.WriteLine("Click");
        }
    }

    static void MouseClick()
    {
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }
}

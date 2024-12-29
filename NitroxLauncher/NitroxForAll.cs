using System;
using System.Runtime.InteropServices;

namespace NitroxLauncher;

public static class NitroxForAll
{

    public static string OS = "";
    
    
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;
    const int SW_SHOW = 5;
    
    [DllImport("Kernel32")]
    public static extern void AllocConsole();
    
    public static void Setup()
    {
        
        AllocConsole();
        Log.Info("Welcome to Nitrox For All!\nIt's Nitrox but without all the bullshit ;3");
    }
    
}

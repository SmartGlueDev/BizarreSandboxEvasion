using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

public class FeatureUsage
{

    public static void Main(string[] args)
    {
        try
        {
            int StartMenu = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\TrayButtonClicked", "StartButton", null);

            int SearchBox = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\TrayButtonClicked", "SearchBox", null);

            if (StartMenu == 0 || SearchBox == 0)
            {
                // empty... Sandbox?!
            }
        }

        catch (NullReferenceException e)

        {
            // empty... Sandbox?!
        }

    }
}
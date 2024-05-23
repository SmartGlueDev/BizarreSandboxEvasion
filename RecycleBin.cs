using System;
using System.IO;
using System.Runtime.InteropServices;
using Shell32;

public class RecycleBinLister
{

    [STAThread()]
    public static void Main(string[] args)
    {

        Shell shell = new Shell();
        Folder recycleBin = shell.NameSpace(10);
        int TotalFiles = recycleBin.Items().Count;

        //Put here condition to evade...

    }
}
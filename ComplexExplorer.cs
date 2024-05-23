using Microsoft.Win32;
using System;

namespace RegistryKeyCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int recentDocsCount = GetRegistryKeyCount(Registry.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs");
            int wordWheelQueryCount = GetRegistryKeyCount(Registry.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\WordWheelQuery");
            int runMRUCount = GetRegistryKeyCount(Registry.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\RunMRU");

            Console.WriteLine("Number of keys in RecentDocs: " + recentDocsCount);
            Console.WriteLine("Number of keys in WordWheelQuery: " + wordWheelQueryCount);
            Console.WriteLine("Number of keys in RunMRU: " + runMRUCount);
			
			// add evasion checks/conditions...

            Console.ReadKey();
        }

        static int GetRegistryKeyCount(RegistryKey baseKey, string subKeyPath)
        {
            using (RegistryKey subKey = baseKey.OpenSubKey(subKeyPath))
            {
                if (subKey != null)
                {
                    return subKey.ValueCount;
                }
                else
                {
                    return 0;
					
					//HA-HA
                }
            }
        }
    }
}


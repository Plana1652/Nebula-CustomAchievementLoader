using System;
using System.IO;
using BepInEx;
using Nebula;
using UnityEngine;
public class PDebug
{
    public static void Log(object message)
    {
        if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/LOG"))
        {
            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/LOG/log.txt", message.ToString() + Environment.NewLine);
        }
        File.AppendAllText(Application.dataPath + "/MoreRolesLog.txt", message.ToString()+Environment.NewLine);
    }
}

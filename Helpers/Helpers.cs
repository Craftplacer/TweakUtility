﻿using System;
using System.IO;

namespace TweakUtility.Helpers
{
    public static class Helpers
    {
        public static string ResolvePath(string path)
        {
            path = Environment.ExpandEnvironmentVariables(path);

            if (File.Exists(path))
            {
                return path;
            }

            string fullpath = Path.GetFullPath(path);
            if (File.Exists(fullpath))
            {
                return fullpath;
            }

            string[] paths = (Environment.GetEnvironmentVariable("PATH") + @";C:\Windows\sysnative\").Split(';');
            foreach (string variablePath in paths)
            {
                string combined = Path.Combine(variablePath, path);
                if (File.Exists(combined))
                {
                    return combined;
                }
            }

            return null;
        }
    }
}
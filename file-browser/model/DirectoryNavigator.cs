using System;
using System.IO;

namespace file_browser.model {

    static class DirectoryNavigator {
        static string currentDirectory = Environment.CurrentDirectory;
        //Get all files
        public static String[] getAllFiles(String pPath) {
            return Directory.GetFiles(pPath);
        }
        //Get all files (no path)
        public static String[] getAllFilesNoPath() {
            String[] files = Directory.GetFiles(currentDirectory);
            String[] newFiles = new String[files.Length];

            foreach(String file in files) {
                newFiles[Array.IndexOf(files,file)] = file.Replace(currentDirectory + "/","");
            }

            return newFiles;
        }
        //Get folders/directories
        public static String[] getFolders(String path) {
            return Directory.GetDirectories(path);
        }
        //Get current directory
        public static String getCurrentDirectory() {
            return Environment.CurrentDirectory;
        }
        //Change Directory
        public static void changeDirectory(String nDirectory) {
            Environment.CurrentDirectory = nDirectory;
            currentDirectory = Environment.CurrentDirectory;
        }
        //Create Directory
        //Delete Directory
        //Create File
        //Delete File
        //Open File
        //Get Directory Info
        public static String[] getDirectoryInfo() {
            return null; //Todo:
        }
        //Go to Home Directory
        public static void goHome() {
            Environment.CurrentDirectory = Constants.homePath;
        }
    }

}
using System;
using System.IO;

namespace file_browser.model {

    class Folder {

    String path;
    String name;
    Folder[] subFolders;
    File[] subFiles;

    public Folder() {
        path = DirectoryNavigator.getCurrentDirectory();
        name = new DirectoryInfo(path).Name;
    }

    public Folder(String pPath) {
        path = pPath;
        name = new DirectoryInfo(path).Name;
    }

    //OpenFolder
        //Get subfiles and subfolders
        //Change directory
    public void openFile() {
        //Get subFiles
        String[] sFolders = DirectoryNavigator.getFolders(path);
        subFolders = new Folder[sFolders.Length];
        foreach(String folder in sFolders) {
            subFolders[Array.IndexOf(sFolders,folder)] = new Folder(folder);
        }
        //Get subFolders
        String[] sFiles = DirectoryNavigator.getAllFiles(path);
        subFiles= new File[sFiles.Length];
        foreach(String file in sFiles) {
            subFiles[Array.IndexOf(sFiles,file)] = new File(file);
        }
        //Change Current Directory
        DirectoryNavigator.changeDirectory(path);
    }

    public Folder[] getSubFolders() {
        return subFolders;
    }

    public File[] getSubFiles() {
        return subFiles;
    }

    public String getName() {
        return name;
    }
    public String getPath() {
        return path;
    }


    //Delete

    //Create





    }

}

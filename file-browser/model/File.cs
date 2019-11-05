using System;
using System.IO;

namespace file_browser.model {

    public class File {
        String name;
        String path;

        public File(String pPath) {
            path = pPath;
            name = Path.GetFileName(pPath);
        }

        public String getName() {
            return name;
        }
        public String getPath() {
            return path;
        }
        //Open File
        //Delete File
        //Get Attributes
    }

}
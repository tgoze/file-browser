using System;
using System.IO;

namespace file_browser.model {

    class Constants {
        public static String homePath = (Environment.OSVersion.Platform == PlatformID.Unix || 
                   Environment.OSVersion.Platform == PlatformID.MacOSX)
                    ? Environment.GetEnvironmentVariable("HOME")
                    : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
    }

}
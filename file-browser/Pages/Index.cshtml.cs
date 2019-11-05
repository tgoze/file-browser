using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using file_browser.model;

namespace file_browser.Pages
{    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ArrayList files { get; set; }        

        [BindProperty]
        public int chosenDirectory { get; set; }

        [BindProperty]
        public string chosenDirectoryName { get; set; }

        public void OnGet()
        {
            DirectoryNavigator.goHome();
            Folder homeFolder = new Folder();
            chosenDirectoryName = homeFolder.getName();
            homeFolder.openFile();
            files = new ArrayList();
            foreach(Folder subFolder in homeFolder.getSubFolders()) {
                files.Add(subFolder.getName());                
            }      
        }

        public void OnPostView(int subFolderId)
        {          
            Folder homeFolder = new Folder();          
            homeFolder.openFile();
            Folder newHome = homeFolder.getSubFolders()[subFolderId];  
            newHome.openFile();                    
            chosenDirectoryName = newHome.getName();            
            files = new ArrayList();
            foreach(Folder subFolder in newHome.getSubFolders()) {
                files.Add(subFolder.getName());                
            }      
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.UserShell
    {
    public class UserShellPage
        {
        public static string getPathOfChangeCustomersContact() { return "/contextmenu[@controltypename='ToolStripDropDownMenu' and @instance='0']/menuitem[@accessiblename='Change customer''s contact']"; }
        public static string getPathOfFindField() { return "/form[@controlname='ChangeContactForm']/?/?/toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Find']"; }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.BusinessProcesses
    {
   public class BusinessProcessesPage
        {
        public static string getPathOfExecuteButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultipleBusinessProcessesForm']/?/?/menubar[@controlname='menuStrip2']/menuitem[@accessiblename='Execute step']";
            }

        public static string getPathOfOKButtonOnBusinessProcessFormWPF()
            {
            return "/form[@controlname='BusinessProcessFormWPF']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfFilterButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultipleBusinessProcessesForm']/?/?/menubar[@controlname='menuStrip2']/menuitem[@accessiblename='Filter']";
            }

        public static string getPathOfFindBpId()
            {
            return "/form[@controlname='BusinessProcessesFilterForm']/container[@controlname='parametersPanel1']/container[@controlname='VsblBPId']//text[@controlname='upDownEdit']";
            }

        public static string getPathOfFirstCheckBox()
            {
            return @"/form[@title='CustomWare.NET']/?/?/form[@controlname='MultipleBusinessProcessesForm']/container[@controlname='panel1']/?/?/table[@accessiblename~'^Please\ wait\ while\ loading']//cell[@accessiblename='Checked Column row 0']";
            }
        }
    }

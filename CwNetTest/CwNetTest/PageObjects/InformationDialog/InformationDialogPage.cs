using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.InformationDialog
    {
   public class InformationDialogPage
        {
        public static string getPathOfYesButton()
            {
            return "/form[@controlname='InformationDialog']/?/?/button[@text='Yes']";
            }

        public static string getPathOfOkButton()
            {
            return "/form[@controlname = 'InformationDialog'] /?/?/ button[@text = 'Ok']";
            }
        }
    }

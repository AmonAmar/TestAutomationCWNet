using Ranorex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.Core
    {
   public class MenuItemCopy
        {
        string _controlPath;

        public MenuItemCopy(string controlPath)
            {
            _controlPath = controlPath;
            }

        public void operationWithMenuItem()
            {
            try
                {
                MenuItem mi = MenuItem.FromPath(_controlPath);
                if (mi.Visible && mi.Enabled)
                    {
                    mi.Click();                
                   // Report.Screenshot(mi);
                  //  Report.Log(ReportLevel.Info, "Element with path '" + _controlPath + "' clicked.");                        
                    }                
                }
            catch (RanorexException ex)
                {
                throw new RanorexException("Element with path '" + _controlPath + "' is not visible/enabled on screen.");
                }
            }
        }
    }

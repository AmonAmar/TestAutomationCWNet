using Ranorex;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CwNetTest.Core
    {
    public class CellCopy
        {
        private string _controlPath;
        private string _value;

        public CellCopy(string controlPath)
            {
            _controlPath = controlPath;
            }
        public CellCopy() { }
        public CellCopy(string controlPath, string value)
            {
            _controlPath = controlPath;
            _value = value;
            }
        public void operationWithCell()
            {            
            try
                {
                Cell cell = Cell.FromPath(_controlPath);                
                if (cell.Visible && cell.Enabled)
                    {
                    cell.Focus();
                    cell.Click();
                    Delay.Duration(1000);
                    Keyboard.Press("{LControlKey down}");
                    Keyboard.Press("{Akey}");
                    Keyboard.Press("{LControlKey up}");
                    Keyboard.Press(Keys.Back);
                    cell.PressKeys(_value != null ? _value : "");
                    Keyboard.Press(Keys.Enter);
                   // Report.Screenshot(cell);
                  //  Report.Log(ReportLevel.Info, "Element with path '" + _controlPath + "' clicked.");                                       
                    }
                }
            catch (RanorexException ex)
                {
                throw new RanorexException("Element with path '" + _controlPath + "' is not visible/enabled on screen.");
                }           
            }

        public void operationWithCellDoubleClick()
            {            
            try
                {
                Cell cell = Cell.FromPath(_controlPath);                
                if (cell.Visible && cell.Enabled)
                    {
                    cell.Focus();
                    cell.DoubleClick();
                    Delay.Duration(1000);
                    Keyboard.Press("{LControlKey down}");
                    Keyboard.Press("{Akey}");
                    Keyboard.Press("{LControlKey up}");
                    Keyboard.Press(Keys.Back);
                    cell.PressKeys(_value != null ? _value : "");
                    Keyboard.Press(Keys.Enter);
                  //  Report.Screenshot(cell);
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
    

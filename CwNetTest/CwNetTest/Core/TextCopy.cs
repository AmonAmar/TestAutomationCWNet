using Ranorex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CwNetTest.Core
    {
   public class TextCopy
        {
        private string _controlPath;
        private string _value;

        public TextCopy(string controlPath)
            {
            _controlPath = controlPath;
            }

        public TextCopy(string value , string controlPath)
            {
            _value = value;
            _controlPath = controlPath;           
            }

        public void operationWithText()
            {
            List<object> ranrexElement_Visible = new List<object>();
            try
                {
                Text text = Text.FromPath(_controlPath);
                ranrexElement_Visible.Add(text);
                if (text.Visible)
                    {
                    text.Focus();
                    text.DoubleClick();
                    Delay.Duration(2000);
                    Keyboard.Press("{LControlKey down}");
                    Keyboard.Press("{Akey}");
                    Keyboard.Press("{LControlKey up}");
                    Keyboard.Press(Keys.Back);
                    text.PressKeys(_value != null ? _value : "");                    
                    Keyboard.Press(Keys.Enter);
                 //   Report.Screenshot(text);
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

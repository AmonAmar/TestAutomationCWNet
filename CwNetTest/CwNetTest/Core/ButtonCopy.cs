using Ranorex;

namespace CwNetTest.Core
    {
    public class ButtonCopy
        {
        private string _controlPath;

        public ButtonCopy(string controlPath)
            {
            _controlPath = controlPath;
            }

        public void operationWithButton()
            {
            try
                {
                Button button = Button.FromPath(_controlPath);
                if (button.Visible && button.Enabled)
                    {
                    button.Click();                
                   // Report.Screenshot(button);
                   // Report.Log(ReportLevel.Info, "Element with path '" + _controlPath + "' clicked.");
                    }                
                }
            catch (RanorexException ex)
                {
                throw new RanorexException("Element with path '" + _controlPath + "' is not visible/enabled on screen.");
                }
            }
        }
    }

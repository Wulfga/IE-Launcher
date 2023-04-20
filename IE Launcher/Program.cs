using System;

namespace IE_Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var IE = new SHDocVw.InternetExplorer();
            object URL = "www.google.de";

            IE.ToolBar = 0;
            IE.StatusBar = false;
            IE.MenuBar = false;

            //
            //IE.Width = 999;
            //IE.Height = 999;
            IE.Visible = true;

            //Open URL
            IE.Navigate2(ref URL);
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Services
{
    internal class ScreenshotHelper
    {
        public static void TakeScreenShotFullscreenHideTaskbars(string identifier = "")
        {
            using var bitmap = new Bitmap(1920, 1005);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(0, 35, 0, 0,
                bitmap.Size, CopyPixelOperation.SourceCopy);
            }
            bitmap.Save(@$"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\Data\Screenshots\OACIS-Screenshot - {$"{identifier} - "}{DateTime.Now.ToString("dd-MM-yy-HH-mm-ss")}.jpg"
                , ImageFormat.Jpeg);
            Console.WriteLine("Screenshot recorded.");
        }
        public static void TakeScreenShotBrowserContents(IWebDriver driver, string identifier="")
        {
            try
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(@$"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\Data\Screenshots\OACIS-Screenshot - {$"{identifier} - "}{DateTime.Now.ToString("dd-MM-yy-HH-mm-ss")}.jpg", ScreenshotImageFormat.Jpeg);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.WriteLine("Screenshot recorded.");
        }
    }
}

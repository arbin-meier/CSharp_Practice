using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheArtOfDev.HtmlRenderer.WinForms;
using System.Drawing.Imaging;
using System.IO;
using CoreHtmlToImage;
using System.Threading;
using System.Windows.Forms;

namespace ConvertHtmlToImage
{
    internal class Program
    {
        public static void ConvertHtmlToImage_HtmlRenderer()
        {
            string html = File.ReadAllText("Template1.html");
            Bitmap m_Bitmap = new Bitmap(1000, 1200);
            PointF point = new PointF(0, 0);
            SizeF maxSize = new System.Drawing.SizeF(500, 600);
            HtmlRender.RenderGdiPlus(Graphics.FromImage(m_Bitmap), html, point, maxSize);

            m_Bitmap.Save(@"Test.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        public static void ConvertHtmlToImage_CoreHtmlToImage()
        {
            var converter = new HtmlConverter();
            var html = File.ReadAllText("Template1.html");
            var bytes = converter.FromHtmlString(html);
            File.WriteAllBytes("image.jpg", bytes);

        }

        private static void StartBrowser(string source)
        {
            var th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                webBrowser.IsWebBrowserContextMenuEnabled = true;
                webBrowser.AllowNavigation = true;

                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
                webBrowser.DocumentText = source;

                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public static void ConvertHtmlToImage_Combined()
        {
            var source = File.ReadAllText("Template1.html");
            StartBrowser(source);
            Console.ReadLine();
        }
        static void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var webBrowser = (WebBrowser)sender;
            using (Bitmap bitmap =
                new Bitmap(
                    webBrowser.Width,
                    webBrowser.Height))
            {
                webBrowser
                    .DrawToBitmap(
                    bitmap,
                    new System.Drawing
                        .Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(@"filename.jpg",
                    System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }
        static void Main(string[] args)
        {
            ConvertHtmlToImage_Combined();
        }
    }
}

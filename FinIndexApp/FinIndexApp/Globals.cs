using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Resources;
using System.IO;
using System.Windows.Media.Imaging;

namespace FinIndexApp
{
    public sealed class Globals
    {
        public static Stream GetImageStreamFromDLL(string strImageName)
        {
            if (string.IsNullOrEmpty(strImageName))
                return null;

            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Images/" + strImageName, UriKind.Relative));
            if (streamInfo == null)
                return null;
            else
                return streamInfo.Stream;
        }

        public static BitmapImage GetImageFromDLL(string strImageName)
        {
            Stream imageStream = GetImageStreamFromDLL(strImageName);

            if (imageStream == null)
                return null;

            BitmapImage image = new BitmapImage();
            image.SetSource(imageStream);
            return image;
        }
    }
}

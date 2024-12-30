using UIKit;
using EClinicMaui.GeneralServices;
using CoreGraphics;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using AVFoundation;
using Foundation;

namespace EClinicMaui.Platforms
{
    public class CurrentDevice : MyDevice
    {
        public void PlayAudioFile(string fileName)
        {
            var player = AVAudioPlayer.FromUrl(NSUrl.FromFilename(fileName));
            player.Play();
        }
        public void Exit()
        {
            System.Environment.Exit(0);
        }

        public IPAddress GetIPAddress()
        {

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

            foreach (var netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (var addrInfo in netInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (addrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddress = addrInfo.Address;

                        }
                    }
                }
            }

            return ipAddress;
        }

        public string GetSavingPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library");
        }
        public void RestartApp()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var rootViewController = window.RootViewController;

            // Re-create the main page
            //window.RootViewController = new UINavigationController(new App());

            // Optionally, you could force the app to exit (not recommended):
            // Process.GetCurrentProcess().CloseMainWindow();
        }

        public string SavingPathForBackup()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library");
        }
        public string SavingPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "data");
        }
        public string GetIdentifier()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.ToString();
        }

        public void MakePhoneCall(string phoneNumber)
        {

        }

        public void ChatViaWhatsApp(string phoneNumber)
        {


        }

        public void SendSms(string phoneNumber)
        {
        }

public void OpenFile(string FilePath){
    
}
        public byte[] ResizeImage(Stream ImageStream, float width, float height, int quality)
        {

            byte[] imageData = BytingServices.StreamToBytes(ImageStream);
            UIImage originalImage = ImageFromByteArray(imageData);


            float oldWidth = (float)originalImage.Size.Width;
            float oldHeight = (float)originalImage.Size.Height;
            float scaleFactor = 0f;

            if (oldWidth > oldHeight)
            {
                scaleFactor = width / oldWidth;
            }
            else
            {
                scaleFactor = height / oldHeight;
            }

            float newHeight = oldHeight * scaleFactor;
            float newWidth = oldWidth * scaleFactor;

            //create a 24bit RGB image
            using (CGBitmapContext context = new CGBitmapContext(IntPtr.Zero,
                (int)newWidth, (int)newHeight, 8,
                (int)(4 * newWidth), CGColorSpace.CreateDeviceRGB(),
                CGImageAlphaInfo.PremultipliedFirst))
            {

                System.Drawing.RectangleF imageRect = new System.Drawing.RectangleF(0, 0, newWidth, newHeight);

                // draw the image
                context.DrawImage(imageRect, originalImage.CGImage);

                UIImage resizedImage = UIImage.FromImage(context.ToImage());

                // save the image as a jpeg
                return resizedImage.AsJPEG((float)quality).ToArray();
            }
        }

        public byte[] ResizeImage(UIImage originalImage, float width, float height, int quality)
        {

            float oldWidth = (float)originalImage.Size.Width;
            float oldHeight = (float)originalImage.Size.Height;
            float scaleFactor = 0f;

            if (oldWidth > oldHeight)
            {
                scaleFactor = width / oldWidth;
            }
            else
            {
                scaleFactor = height / oldHeight;
            }

            float newHeight = oldHeight * scaleFactor;
            float newWidth = oldWidth * scaleFactor;

            //create a 24bit RGB image
            using (CGBitmapContext context = new CGBitmapContext(IntPtr.Zero,
                (int)newWidth, (int)newHeight, 8,
                (int)(4 * newWidth), CGColorSpace.CreateDeviceRGB(),
                CGImageAlphaInfo.PremultipliedFirst))
            {

                System.Drawing.RectangleF imageRect = new System.Drawing.RectangleF(0, 0, newWidth, newHeight);

                // draw the image
                context.DrawImage(imageRect, originalImage.CGImage);

                UIImage resizedImage = UIImage.FromImage(context.ToImage());

                // save the image as a jpeg
                return resizedImage.AsJPEG((float)quality).ToArray();
            }
        }

        public UIKit.UIImage ImageFromByteArray(byte[] data)
        {
            if (data == null)
            {
                return null;
            }

            UIKit.UIImage image;
            try
            {
                image = new UIKit.UIImage(Foundation.NSData.FromArray(data));
            }
            catch (Exception e)
            {
                Console.WriteLine("Image load failed: " + e.Message);
                return null;
            }
            return image;
        }

        public string ResizeImage(string FilePath, float width, float height, int quality)
        {
            throw new NotImplementedException();
        }

        public byte[] ResizeImage(string FilePath, int quality)
        {
            byte[] imageData;

            FileStream ImageStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

            imageData = BytingServices.StreamToBytes(ImageStream);

            UIImage originalImage = ImageFromByteArray(imageData);


            float oldWidth = (float)originalImage.Size.Width - 10;
            float oldHeight = (float)originalImage.Size.Height - 10;

            return ResizeImage(originalImage, oldWidth, oldHeight, quality);
        }

        public Stream ResizeImageAsMemoryStream(Stream ImageStream, float width, float height, int quality)
        {
            throw new NotImplementedException();
        }
    }
}

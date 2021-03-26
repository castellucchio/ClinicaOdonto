using System;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace Segalla.Views
{
    /// <summary>
    /// Interação lógica para Sobre.xam
    /// </summary>
    public partial class Sobre : UserControl
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void InstaClinica_Click(object sender, RoutedEventArgs e)
        {
            string url = ConfigurationManager.AppSettings.Get("InstaClinica");
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    //MainWindow.ErrorOcurred?.Invoke(ex.Message, ex);
                }
            }
        }

        private void FBClinica_Click(object sender, RoutedEventArgs e)
        {
            string url = ConfigurationManager.AppSettings.Get("FaceClinica");
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    //MainWindow.ErrorOcurred?.Invoke(ex.Message, ex);
                }
            }
        }

        private void WppDev_Click(object sender, RoutedEventArgs e)
        {
            string DevWpp = ConfigurationManager.AppSettings.Get("WppDev");
            string url = $"https://api.whatsapp.com/send?phone=+55{DevWpp}&text="; //uri da API do whatsapp
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    //MainWindow.ErrorOcurred?.Invoke(ex.Message, ex);
                }
            }
        }

        private void LinkDev_Click(object sender, RoutedEventArgs e)
        {

            string url = ConfigurationManager.AppSettings.Get("LinkedinDev");
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    //MainWindow.ErrorOcurred?.Invoke(ex.Message, ex);
                }
            }
        }
    }

}
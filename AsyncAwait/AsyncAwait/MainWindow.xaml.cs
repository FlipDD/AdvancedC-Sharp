using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAwait
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Synchronous Program Execution                                                                                             
    //      Program is executed line by line, one at a time;                                                                     
    //      When a function is called, program execution has to wait until the function returns.                                 
    // Asynchronous Program Execution                                                                                            
    //      When a function is called, program execution continues to the next line, without waiting for the function to complete
    // 
    // Examples:
    //      Accessing the web;
    //      Working with files and databases;
    //      Working with images.
    //
    // How?
    //  Traditional:
    //      Multi-threading;
    //      Callbacks.
    //  New since NET 4.5:
    //      Async;
    //      Await.
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //var html = GetHtml("http://msdn.microsoft.com");
            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show("Waiting for the task to complete");
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //DownloadHtmlAsync("http://msdn.microsoft.com");
        //}

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        // Encapsulates the state of an asynchronous operation
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();

            // "await" is a marker for the compiler
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\Games\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\Games\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}

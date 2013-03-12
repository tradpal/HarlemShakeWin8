using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HarlemShakeWin8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnGo_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.txtUrl.Text.Length == 0)
                return;

            if (!(this.txtUrl.Text.ToLower().StartsWith("http://") || this.txtUrl.Text.ToLower().StartsWith("https://")))
            {
                this.txtUrl.Text = "http://" + this.txtUrl.Text;
            }

            this.wbMain.Navigate(new Uri(this.txtUrl.Text, UriKind.Absolute));

        }

        private void wbMain_LoadCompleted_1(object sender, NavigationEventArgs e)
        {       
            if(this.audioPlayer.CurrentState != MediaElementState.Playing)
                PlayMusic();
        }

        public void PlayMusic()
        {
            this.audioPlayer.Play();
            this.Anim3.Begin();
        }

    }
}

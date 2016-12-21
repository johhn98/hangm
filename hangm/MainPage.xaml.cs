using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace hangm
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private BitmapIcon[] hangImages = { hangm.MainPage.Hang1, hangm.MainPage.Hang2, hangm.MainPage.Hang3, hangm.MainPage.Hang4, hangm.MainPage.Hang5, hangm.MainPage.Hang6, hangm.MainPage.Hang7


        private int wrongGuesses = 0;

        public MainPage()
        {
            this.InitializeComponent();





            Application.Current.DebugSettings.EnableFrameRateCounter = false;
        }

        public static BitmapIcon Hang1 { get; private set; }
        public static object Properties { get; private set; }

        private int wrongGuesses = 0;

        private string[] words;

        public Frame()
        {
            InitializeComponent();

        }

        private void loadwords()
        {

        }



        private void guessClick(object sender, EventArgs e)
        {
            wrongGuesses++;
            if (wrongGuesses > 7)
            {
                hangImages.Image = hangImages[wrongGuesses];


            }
            else
            {
                ContentDialogResult.None = "Verloren";
            }


        }
    }
}




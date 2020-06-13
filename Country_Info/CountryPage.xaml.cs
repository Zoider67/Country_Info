using Newtonsoft.Json;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Country_Info
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CountryPage : Page
    {
        public CountryPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if(e.Parameter != null)
            {
                var uri = new System.Uri("https://restcountries.eu/rest/v2/name/" + e.Parameter.ToString());
                using (var httpClient = new Windows.Web.Http.HttpClient())
                {
                    try
                    {
                        string result = await httpClient.GetStringAsync(uri);
                    }
                    catch (Exception ex)
                    {
                        //TODO: messagebox  с ошибкой
                    }
                }
               
            }
        }

        private void DontSaveButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

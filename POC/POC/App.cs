using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using POC.Views;
using Xamarin.Forms;

namespace POC
{
    public class App
    {
        public static Page GetMainPage()
        {
            //string result = "Résultat : " + Environment.NewLine;

            

            //return new ContentPage
            //{
            //    Content = new Label
            //    {
            //        Text = result,
            //        VerticalOptions = LayoutOptions.CenterAndExpand,
            //        HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    },
            //};

            return new PageTest();

        }
    }
}

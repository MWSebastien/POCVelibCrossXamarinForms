using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POC.Models;
using POC.ViewModels;
using Xamarin.Forms;

namespace POC.Views
{
    public partial class PageTest
    {
        public PageTest()
        {
            InitializeComponent();

            LoadVisuel();
        }

        private async void LoadVisuel()
        {
            ListView lv = new ListView();
            


            lv.ItemsSource = await ServiceProxy.Instance.Service.GetVelib();
            lv.ItemTemplate = new DataTemplate(() =>
            {
                TextCell tc = new TextCell();
                tc.SetBinding(TextCell.TextProperty, "name");
                return tc;
            });

            this.Content = lv;
        }
    }
}

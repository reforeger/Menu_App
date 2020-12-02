using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Menu_APP
{
    public partial class MainPage : MasterDetailPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            //IMG.Source = ImageSource.FromFile("");
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
            aboutList.ItemsSource = GetMenuList();
        }
        
        public List<MasterMenuitems> GetMenuList()
        {
            
            var list = new List<MasterMenuitems>();
            list.Add(new MasterMenuitems()
            {

                Text = "Minust",
                Detail = "Lühike info",
                //ImagePath = "about.png",
                TargetPage = typeof(Views.AboutPage)
            });


            list.Add(new MasterMenuitems()
            {
                Text = "Minu kogemus",
                Detail = "Lühike info",
                //ImagePath = "list.png",
                TargetPage = typeof(Views.onePage)
            });


            list.Add(new MasterMenuitems()
            {
                Text = "Minust",
                Detail = "Lühike info",
                //ImagePath = "slills.png",
                TargetPage = typeof(Views.twoPage)
            });


            list.Add(new MasterMenuitems()
            {
                Text = "Minust",
                Detail = "Lühike info",
                //ImagePath = "awards.png",
                TargetPage = typeof(Views.threePage)
            });
            return list;
        }



        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuitems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}

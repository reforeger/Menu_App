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

            
            IMG.Source = ImageSource.FromFile("swed.png");
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

                Text = "Главное меню",
                Detail = "вход в меню",
                
                ImagePath = "swed.png",
                TargetPage = typeof(Views.AboutPage)



            });


            list.Add(new MasterMenuitems()
            {
                
                Text = "О Банковской системе",
                Detail = "дополнительная безопастность",
                ImagePath = "lok.png",
                TargetPage = typeof(Views.onePage)
            });


            list.Add(new MasterMenuitems()
            {
                Text = "Дополнительная информация",
                Detail = "информация о приложении",
                ImagePath = "qu.png",
                TargetPage = typeof(Views.twoPage)
            });


            list.Add(new MasterMenuitems()
            {
                Text = "Обзор",
                
                ImagePath = "hos.png",
                TargetPage = typeof(Views.threePage)
            });

            list.Add(new MasterMenuitems()
            {
                Text = "Платежи",
               
                ImagePath = "mon.png",
                TargetPage = typeof(Views.fourPage)
            });

            list.Add(new MasterMenuitems()
            {
                Text = "Карты",
                Detail = "выбор банковских карт",
                ImagePath = "card.png",
                TargetPage = typeof(Views.fivePage)
            });

            list.Add(new MasterMenuitems()
            {
                Text = "Услуги",
                ImagePath = "list.png",
                TargetPage = typeof(Views.sixPage)
            });

            list.Add(new MasterMenuitems()
            {
                Text = "Контакты",
                Detail = "Частный клиент",
                ImagePath = "kont.png",
                TargetPage = typeof(Views.sevenPage)
            });

            list.Add(new MasterMenuitems()
            {
                Text = "Выход",
                ImagePath = "kont1.png",
                TargetPage = typeof(Views.eightPage)
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

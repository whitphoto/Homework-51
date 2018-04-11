/********************************************************
*														*
*		Nathan Whitchurch								*
*		CIS 223 COMPUTER PROJECTS & APPLICATIONS    	*
*		Dr Whittle										*
*		Homework 5-2 Menu Program						*
*														*
********************************************************/


/********************************************************
*                                                       *
*       MainPage.xaml.cs                                *
*                                                       *
********************************************************/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Homework_51
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static meal[] menuItems = new meal[20];
        public static meal[] menuChoices = new meal[20];
        string menuSelections;

        public MainPage()
        {
            this.InitializeComponent();
            Loaded += PopulateArray;
        }


        public async void PopulateArray(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            char switchCheck;

            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///MenuItems.txt"));
            using (var inputStream = await file.OpenReadAsync())
            using (var classicStream = inputStream.AsStreamForRead())
            using (var streamReader = new StreamReader(classicStream))
            {
                while (streamReader.Peek() >= 0)
                {
                    string itemIn = string.Format(streamReader.ReadLine());
                    string[] item = itemIn.Split('/');
                    switchCheck = Convert.ToChar(item[0]);
                    switch (switchCheck)
                    {
                        case 'b':
                            menuItems[counter] = new breakfast(Convert.ToChar(item[0]), item[1], Convert.ToDecimal(item[2]));
                            break;
                        case 'l':
                            menuItems[counter] = new lunch(Convert.ToChar(item[0]), item[1], Convert.ToDecimal(item[2]));
                            break;
                        case 'd':
                            menuItems[counter] = new dinner(Convert.ToChar(item[0]), item[1], Convert.ToDecimal(item[2]));
                            break;

                    }//end switch
                    counter++;
                }//end while`
            }

        }//end populateArray method

        private void BreakfastButton_Click(object sender, RoutedEventArgs e)
        {
            MenuList.Items.Clear();
            List<string> menu = new List<string>();

            for (int i = 0; i < menuItems.Length && menuItems[i] != null; i++)
            {
                if (menuItems[i].getMealType() == 'b')
                    menu.Add(menuItems[i].getMealDesc());

            }//end for loop

            for (int i =0; i < menu.Count; i++)
            {
                MenuList.Items.Add(menu[i]);
            }
          
        }//end  BreakfastButton_Click

        private void LunchButton_Click(object sender, RoutedEventArgs e)
        {
            MenuList.Items.Clear();
            List<string> menu = new List<string>();

            for (int i = 0; i < menuItems.Length && menuItems[i] != null; i++)
            {
                if (menuItems[i].getMealType() == 'l')
                    menu.Add(menuItems[i].getMealDesc());

            }//end for loop

            for (int i = 0; i < menu.Count; i++)
            {
                MenuList.Items.Add(menu[i]);
            }
        }//end LunchButton_Click

        private void DinnerButton_Click(object sender, RoutedEventArgs e)
        {
            MenuList.Items.Clear();
            List<string> menu = new List<string>();

            for (int i = 0; i < menuItems.Length && menuItems[i] != null; i++)
            {
                if (menuItems[i].getMealType() == 'd')
                    menu.Add(menuItems[i].getMealDesc());

            }//end for loop

            for (int i = 0; i < menu.Count; i++)
            {
                MenuList.Items.Add(menu[i]);
            }//end for 


        }//end DinnerButton_Click

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {

            foreach (string eachItem in MenuList.SelectedItems)
            /*  {*/

            { menuSelections += eachItem + "/"; }
                  
                    /*int i = 0, ii = 0;
                    for (i= 0 ; i < menuItems.Length && i < (eachItem.Count()-1); i++ )
                            {
                                if (menuItems[i].getMealDesc() == eachItem)

                                {
                                    menuChoices[ii] = menuItems[i];
  
                                }//end if
                            }//end for loop
                    ii++;
                }//end foreach loop
                */

            Frame.Navigate(typeof(Page2), menuSelections);


        }//end CheckoutButton_Click




    }//end mainpage
}

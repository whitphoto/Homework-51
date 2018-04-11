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
*       Page2.xaml.cs                                   *
*                                                       *
********************************************************/


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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Homework_51
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string menuSelections = e.Parameter.ToString();
            string[] menuSelectionArray = menuSelections.Split('/');
            int inner = 0, outer = 0;
            for (outer = 0; outer < menuSelectionArray.Length; outer++)
            {
                for (inner = 0; inner < MainPage.menuItems.Length && MainPage.menuItems[inner] != null; inner++ )
                {
                    if (menuSelectionArray[outer] == MainPage.menuItems[inner].getMealDesc())
                    { MainPage.menuChoices[outer] = MainPage.menuItems[inner]; }
                }
            }
          

            
            decimal totalPrice = 0;
            TotalBox.Text = "Your menu choices are:\n" +  "\n";
            for (int i = 0; i < MainPage.menuChoices.Length && MainPage.menuChoices[i] != null; i++)
                 {
                    
                    TotalBox.Text +=  "\n" + MainPage.menuChoices[i].getMealDesc();
                    totalPrice += MainPage.menuChoices[i].getMealPrice();

                 }
            TotalBox.Text += "\n\nYour Total Price is: $" + totalPrice;

    

            //TotalBox.Text += e.Parameter;
        }
    }
}

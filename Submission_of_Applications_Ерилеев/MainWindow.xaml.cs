using Submission_of_Applications_Ерилеев.pages;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Submission_of_Applications_Ерилеев
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Page> pages = new List<Page>();
        private int currentPageIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            pages.Add(new Statement());
            pages.Add(new Education());
            pages.Add(new Speciality());
            pages.Add(new Passport());
            pages.Add(new Contacts());
            pages.Add(new Parents());

            frame.Navigate(pages[currentPageIndex]);
        }

        public void NextPage()
        {
            if (currentPageIndex < pages.Count - 1)
            {
                currentPageIndex++;
                frame.Navigate(pages[currentPageIndex]);
            }
        }

    }
}

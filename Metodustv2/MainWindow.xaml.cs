using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.Entity;
using System.Collections;

namespace Metodustv2
{
   
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : RibbonWindow
    {
        
        abidatEntities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new abidatEntities();

        }

      
 
      
      

       

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWind = new AddWindow();
            addWind.Show();
        }

        

      

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ChangeUserButton_Click(object sender, RoutedEventArgs e)
        {
            EnterWindow EntWind = new EnterWindow();
            Close();
            EntWind.Show();
        }

        private void StudYearButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

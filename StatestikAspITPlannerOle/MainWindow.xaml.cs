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

namespace StatestikAspITPlannerOle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
            //exist the program
        {
            Environment.Exit(0);

        }
        private void Load()
        //Set the user list
        {
            //call db function and get user list and add to combobox
            
            try
            {
                
                        
                studentpicker.ItemsSource = DBCon.GetStudents();
                
                             
            }
            catch (Exception e)
            {
                MessageBox.Show("load fejl besked"+e.Message);
            }

            
        }

        private void BGetdata_Click(object sender, RoutedEventArgs e)
        {
            //Student studentinfocus = new Student();
            try
            {
                Student value = studentpicker.SelectedItem as Student;
                MessageBox.Show("id valgt: " + value.id + " name: " + value.name);
            }
            catch(Exception e2)
            {
                MessageBox.Show("Fejl i combobox change: " + e2.Message);
            }
            
        }
    }
}

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
using Base.ViewModel;

namespace KNP_Urban.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // link to application object: ((App)Application.Current).something

        // binding: myComponent.SetBinding(myComponent.BindingProperty, new Binding("BindingPath"){Source = this.DataContext});

        /* Binding Example
            Binding myBinding = new Binding();
            myBinding.Path = new PropertyPath("Name");
            myBinding.Source = this.DataContext;
            BindingOperations.SetBinding(myButton, Button.ContentProperty, myBinding);

            Binding myCommandBinding = new Binding();
            myCommandBinding.Path = new PropertyPath("NewCommand");
            myCommandBinding.Source = this.DataContext;
            myButton.SetBinding(Button.CommandProperty, myCommandBinding);
         */
    }
}

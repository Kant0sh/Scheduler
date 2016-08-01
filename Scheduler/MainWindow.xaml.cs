using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace Scheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            slider.ValueChanged += Slider_ValueChanged;
            this.SizeChanged += MainWindow_SizeChanged;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(ColumnDefinition col in grid.ColumnDefinitions)
            {
                col.MinWidth = this.ActualWidth / grid.ColumnDefinitions.Count;
            }
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            label.Content = "" + slider.Value * this.ActualWidth / 10;
            foreach (ColumnDefinition col in grid.ColumnDefinitions)
            {
                col.Width = new GridLength(slider.Value * this.ActualWidth / 10);
                col.MinWidth = this.ActualWidth / grid.ColumnDefinitions.Count;
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label.Content = "" + slider.Value * this.ActualWidth/10;
            foreach (ColumnDefinition col in grid.ColumnDefinitions)
            {
                col.Width = new GridLength(slider.Value*this.ActualWidth/10);
            }
        }
    }
}

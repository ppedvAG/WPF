using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace RoutedEvents
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

        public MainWindow()
        {
            InitializeComponent();
            eventsDataGrid.ItemsSource = Items;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Items.Clear();
        }

        private void Element_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as FrameworkElement;
            Items.Add(new Item { EventName = "PrieviewMouseDown", ControlName = element.Name });

            if (element.Name == GreenRectangle.Name)
                e.Handled = true;
        }

        private void Element_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as FrameworkElement;
            Items.Add(new Item { EventName = "MouseDown", ControlName = element.Name });
        }
    }
}

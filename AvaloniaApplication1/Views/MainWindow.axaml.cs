using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace AvaloniaApplication1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Theme_ChangeToLight(object? sender, RoutedEventArgs e)
        {
            Application.Current!.RequestedThemeVariant = ThemeVariant.Light;
        }

        public void Theme_ChangeToDark(object? sender, RoutedEventArgs e)
        {
            Application.Current!.RequestedThemeVariant = ThemeVariant.Dark;
        }
    }
}
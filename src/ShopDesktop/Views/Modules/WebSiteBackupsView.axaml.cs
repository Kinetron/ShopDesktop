using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ShopDesktop.ViewModels;

namespace ShopDesktop.Views.Modules;

public partial class WebSiteBackupsView : UserControl
{
    public WebSiteBackupsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
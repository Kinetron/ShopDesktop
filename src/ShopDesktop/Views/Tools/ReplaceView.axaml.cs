﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ShopDesktop.Views.Tools;

public partial class ReplaceView : UserControl
{
    public ReplaceView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}

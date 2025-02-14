using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace TitlebarTest;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ExtendsContentIntoTitleBar = true;
    }

    private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
    {
        titleBar.IsBackButtonVisible = toggleSwitch.IsOn;
    }

    private void titleBar_BackRequested(TitleBar sender, object args)
    {
        ClickEventTxtBlock.Text = "Back button clicked: " + DateTime.Now.ToString();
    }
}

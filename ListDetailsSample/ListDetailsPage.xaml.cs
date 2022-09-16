using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ListDetailsSample;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class ListDetailsPage : Page
{
    public ListDetailsPage()
    {
        this.InitializeComponent();

        Items = new ObservableCollection<Detail>()
        {
            new Detail(){ID = 1, Name = "name" },
            new Detail(){ID = 2, Name = "name2" },
        };
    }

    private ObservableCollection<Detail> items;

    public ObservableCollection<Detail> Items
    {
        get => items;
        set => items = value;
    }

    private void ListDetailsView_ViewStateChanged(object sender, CommunityToolkit.WinUI.UI.Controls.ListDetailsViewState e)
    {

    }
}

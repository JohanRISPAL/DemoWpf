using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace WpfDemo;

public partial class ListCraftUC : UserControl
{

    public CompleteItemManager CompleteItemManager { get; set; } = new CompleteItemManager();
    public ListCraftUC()
    {
        InitializeComponent();
        ListBoxCompleteItem.ItemsSource = CompleteItemManager.CompleteItems;
    }

    public void Control_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        for (int i = 0; i < 9; i++)
        {
            object component = CraftList.FindName($"Component{i}") ?? throw new InvalidOperationException();
            ((Label)component).Content = $"{((ListBoxItem) sender).Content}Component";
        }
    }
    
    /*
     * Create an event to get back to the menu with User Control
     */
    public static readonly RoutedEvent BackToMenuEvent = EventManager.RegisterRoutedEvent(
        "BackToMenu", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(ListCraftUC));
    
    public event RoutedEventHandler BackToMenu
    {
        add { AddHandler(BackToMenuEvent, value); }
        remove { RemoveHandler(BackToMenuEvent, value); }
    }
    
    /*
     * OnClick method who will raise the event on the button "BackToMenu" click
     */
    public void BackToMenuClick(object sender, RoutedEventArgs e)
    {
        RaiseEvent(new RoutedEventArgs(BackToMenuEvent));
    }

    private void ListBoxItem_OnSelected(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Bite");
    }
    
}
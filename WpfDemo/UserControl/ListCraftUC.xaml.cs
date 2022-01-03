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
    
    private void ListBoxCompleteItem_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var listBox = (ListBox)sender;
        var selectedItem = (CompleteItem)listBox.SelectedItem;
        MessageBox.Show($"Item {selectedItem.Name}");
    }
}
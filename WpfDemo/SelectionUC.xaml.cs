using System.Windows;
using System.Windows.Controls;

namespace WpfDemo;

public partial class SelectionUC : UserControl
{
    public SelectionUC()
    {
        InitializeComponent();
    }
    
    /*
     * Create an event to get back to the menu with User Control
     */
    public static readonly RoutedEvent GoToCraftListEvent = EventManager.RegisterRoutedEvent(
        "Tap", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(SelectionUC));
    
    public event RoutedEventHandler GoToCraftList
    {
        add { AddHandler(GoToCraftListEvent, value); }
        remove { RemoveHandler(GoToCraftListEvent, value); }
    }
    
    /*
     * OnClick method who will raise the event on the button "BackToMenu" click
     */
    public void GoToCraftListClick(object sender, RoutedEventArgs e)
    {
        RaiseEvent(new RoutedEventArgs(GoToCraftListEvent));
    }
}
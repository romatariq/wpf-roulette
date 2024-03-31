using System.Windows;
using System.Windows.Controls;
using Models;
using WpfApp.ViewModels;

namespace WpfApp.Views;

public partial class BoardNumberView : UserControl
{
    public static readonly DependencyProperty RouletteNumberProperty =
        DependencyProperty.Register(nameof(RouletteNumber), typeof(RouletteNumber), typeof(BoardNumberView), new PropertyMetadata(null, OnRouletteNumberChanged));

    public RouletteNumber RouletteNumber
    {
        get => (RouletteNumber)GetValue(RouletteNumberProperty);
        set => SetValue(RouletteNumberProperty, value);
    }
    
    public BoardNumberView()
    {
        InitializeComponent();
    }
    
    private static void OnRouletteNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not BoardNumberView boardNumberView) return;
        if (e.NewValue is not RouletteNumber value) return;
            
        boardNumberView.DataContext = new BoardNumberViewModel(value);
    }
}
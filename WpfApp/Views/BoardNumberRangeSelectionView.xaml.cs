using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Views;

public partial class BoardNumberRangeSelectionView : UserControl
{
    public static readonly DependencyProperty AngleProperty =
        DependencyProperty.Register(nameof(Angle), typeof(int), typeof(BoardNumberRangeSelectionView));
    
    public static readonly DependencyProperty BackgroundColorProperty =
        DependencyProperty.Register(nameof(BackgroundColor), typeof(string), typeof(BoardNumberRangeSelectionView));
    
    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register(nameof(Label), typeof(string), typeof(BoardNumberRangeSelectionView));

    public int Angle
    {
        get => (int) GetValue(AngleProperty);
        set => SetValue(AngleProperty, value);
    }
    
    public string BackgroundColor
    {
        get => (string) GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }
    
    public string Label
    {
        get => (string) GetValue(BackgroundColorProperty);
        set => SetValue(LabelProperty, value);
    }
    
    public BoardNumberRangeSelectionView()
    {
        InitializeComponent();
        DataContext = this;
    }
}
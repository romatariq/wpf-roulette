using System.Windows;
using WpfApp.ViewModels;

namespace WpfApp.Views;

public partial class BoardView : Window
{
    public BoardView()
    {
        InitializeComponent();
        DataContext = new BoardViewModel();
    }
}
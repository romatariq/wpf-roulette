using Models;

namespace WpfApp.ViewModels;

public class BoardNumberViewModel: BaseViewModel
{
    public RouletteNumber RouletteNumber { get; set; }
    
    public BoardNumberViewModel(RouletteNumber rouletteNumber)
    {
        RouletteNumber = rouletteNumber;
    }
}
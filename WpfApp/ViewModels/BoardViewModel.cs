using System.Collections.ObjectModel;
using Models;

namespace WpfApp.ViewModels;

public class BoardViewModel : BaseViewModel
{

    public ObservableCollection<RouletteNumber> Numbers { get; set; } = CreateRouletteTable();

    private static ObservableCollection<RouletteNumber> CreateRouletteTable()
    {
        int[] reds = [1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36];
        var numbers = new ObservableCollection<RouletteNumber>();
        
        for (var row = 0; row < 3; row++)
        {
            for (var col = 0; col < 12; col++)
            {
                var number = (col * 3) + (2 - row) + 1;
            
                numbers.Add(new RouletteNumber
                {
                    Number = number.ToString(),
                    IsRed = reds.Contains(number)
                });
            }
        }

        return numbers;
    }
}
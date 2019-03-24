using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modular_dice_roller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random theRandom = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var numberOfDiceRolled = NumberOfDice.Value.Value;
            var diceRangeMinimum = DiceRangeMin.Value.Value;
            var diceRangeMaximum = DiceRangeMax.Value.Value;
            var numberOfRolls = NumberOfRolls.Value.Value;
            var targerValue = TargetValue.Value.Value;


            var singleDiceRoll = GenerateSingleDiceRoll(numberOfDiceRolled, diceRangeMinimum, diceRangeMaximum);

            MessageBox.Show("" + singleDiceRoll);

        }

        private int GenerateSingleDiceRoll (int numberOfDice, int diceRangeMinimum, int diceRangeMaximum)
        {
            int result = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                result = result + theRandom.Next(diceRangeMinimum, diceRangeMaximum);
            }

            return result;
        }

        private List<int> GenerateCollectionOfRolls(int numberOfRolls)
        {
            List<int> newCollectionOfRolls = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                newCollectionOfRolls.Add(1);
            }
            return newCollectionOfRolls;
        }


    }
}

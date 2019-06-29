using System;
using System.Windows;
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
using System.Collections.Generic;

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

        private void FlatValueTestGenerteRoll(object sender, RoutedEventArgs e)
        {
            var theDiceRoll = new DiceRoll(NumberOfDice.Value.Value, DiceRangeMin.Value.Value, DiceRangeMax.Value.Value);
            var numberOfRolls = NumberOfRolls.Value.Value;
            var targetValue = TargetValue.Value.Value;

            var collectionOfRolls = GenerateCollectionOfRolls(numberOfRolls, theDiceRoll);

            AverageResult.Text = collectionOfRolls.Average().ToString();
            SuccessRate.Text = (100.0f * collectionOfRolls.Where(x => x >= targetValue).Count() / numberOfRolls).ToString();
            LowestValue.Text = collectionOfRolls.Min().ToString();
            HighestValue.Text = collectionOfRolls.Max().ToString();
        }

        private int[] GenerateCollectionOfRolls(int numberOfRolls, DiceRoll diceRoll)
        {
            int[] newCollection = new int[numberOfRolls];

            for (int i = 0; i < newCollection.Length; i++)
            {
                newCollection[i] = GenerateSingleDiceRoll(diceRoll);
            }

            return newCollection;
        }

        private int GenerateSingleDiceRoll(DiceRoll diceRoll)
        {
            int result = 0;

            for (int i = 0; i < diceRoll.NumberOfDice; i++)
            {
                result = result + theRandom.Next(diceRoll.DiceRangeMinimum, diceRoll.DiceRangeMaximum + 1); //upper limit of .Next() is exclusive, thus +1
            }

            return result;
        }

        private void ShowAllResults(int[] collection)
        {
            var results = string.Join(", ", collection);
            MessageBox.Show(results);
        }
    }
}


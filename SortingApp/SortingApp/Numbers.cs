using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApp
{
    class Numbers
    {
        public string unorderedNumbersString { get; set; } //A class ezen a property-n keresztül veszi át a számsort       
        private int[] numbersArray { get; set; } //A class ebben tárolja az unorderedNumbersString-ből vett számokat      

        //A lenti metódus a string típusú számsort egy integer típusú tömbbe teszi az elválasztó karakterek kivételével
        public void ConvertToIntArray()
        {
            string separators = string.Empty;
            for (int i = 0; i < unorderedNumbersString.Length; i++)
            {
                if (!char.IsDigit(unorderedNumbersString[i]))
                {
                    separators += unorderedNumbersString[i];
                }
            }
            numbersArray = unorderedNumbersString.Split(separators.ToCharArray()).Select(int.Parse).ToArray();
        }
        //A lenti metódus növekvő sorrendbe rendezi a tömb elemeit
        public void SortArray()
        {
            Array.Sort(numbersArray);
        }
        //A lenti metódus kiírja egy felugró ablak segítségével a rendezett számsort
        public void ShowOrderedNumbers()
        {
            string ascendingOrder = string.Empty;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if(i == numbersArray.Length - 1) { ascendingOrder += numbersArray[i]; }
                else { ascendingOrder += numbersArray[i] + ","; }
                
            }
            MessageBox.Show(ascendingOrder);
        }
    }
}


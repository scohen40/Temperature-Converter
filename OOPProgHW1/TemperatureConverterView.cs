using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProgHW1
    /**
    * Included is a second option for the data to change when the text is changed, in the comments below
    * to use, delete or comment out all code regarding onClick for all buttons in this file and TemperatureConverterView.Designer.cs
    * and uncomment all of the the TexedChanged code in both as well. 
    **/
{
    public partial class TemperatureConverterView : Form
    {
        private TemperatureConverterModel temperatureConverterModel = new TemperatureConverterModel();

        public TemperatureConverterView()
        {
            InitializeComponent();
        }

        private void convertFahrButton_Click(object sender, EventArgs e)
        {
            temperatureConverterModel.convertFromFahr(Convert.ToDouble(convertFahrText.Text));
            updateTemps();
        }
       // private void convertFahrText_TextChanged(object sender, EventArgs e)
       // {
       //     temperatureConverterModel.convertFromFahr(Convert.ToDouble(convertFahrText.Text));
       // }


        private void convertCelsButton_Click(object sender, EventArgs e)
        {
            temperatureConverterModel.convertFromCels(Convert.ToDouble(convertCelsText.Text));
            updateTemps();
        }
        //private void convertCelsText_TextChanged(object sender, EventArgs e)
        //{
        //   // temperatureConverterModel.convertFromCels(Convert.ToDouble(convertCelsText.Text));
        //}


        private void convertKelvButton_Click(object sender, EventArgs e)
        {
            temperatureConverterModel.convertFromKelv(Convert.ToDouble(convertKelvText.Text));
            updateTemps();
        }
        //private void convertKelvText_TextChanged(object sender, EventArgs e)
        //{
        //    //temperatureConverterModel.convertFromKelv(Convert.ToDouble(convertKelvText.Text));
        //}


        private void updateTemps()
        {
            convertFahrText.Text = temperatureConverterModel.FahrTemp.ToString();
            convertCelsText.Text = temperatureConverterModel.CelsTemp.ToString();
            convertKelvText.Text = temperatureConverterModel.KelvTemp.ToString();
        }

        
    }
}

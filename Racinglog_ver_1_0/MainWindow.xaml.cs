using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Racinglog_ver_1_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_Load(object sender, RoutedEventArgs e)
        {
            //var Printout = Printout_TextChanged.Text;
            string[] lines = System.IO.File.ReadAllLines(@"Racelog.txt");

            foreach (var item in lines)
	        {
                Printout.Text += item;
                Printout.Text += "\n";
	        }

        }


        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            LeftFrontSuspensionClick.Text = "8";
            RightFrontSuspensionClick.Text = "8";
            LeftRearSuspensionClick.Text = "6";
            RightRearSuspensionClick.Text = "6";
            LeftFrontTyreNum.Text = "Tyre Num?";
            RightFrontTyreNum.Text = "Tyre Num?";
            LeftRearTyreNum.Text = "Tyre Num?";
            RightRearTyreNum.Text = "Tyre Num?";
            LeftFrontColdPressure.Text = "1,8 bar";
            LeftRearColdPressure.Text = "2,0 bar";
            RightRearColdPressure.Text = "1,9 bar";
            RightFrontColdPressure.Text = "1,7 bar";
            LeftFrontColdTemp.Text = "Temp ?";
            RightFrontColdTemp.Text = "Temp ?";
            LeftRearColdTemp.Text = "Temp ?";
            RightRearColdTemp.Text = "Temp ?";
            LeftFrontWarmPressure.Text = "2,4 bar";
            RightFrontWarmPressure.Text = "2,4 bar";
            LeftRearWarmPressure.Text = "2,4 bar";
            RightRearWarmPressure.Text = "2,4 bar";
            LeftFrontWarmTemp.Text = "80 deg C";
            RightFrontWarmTemp.Text = "80 deg C";
            LeftRearWarmTemp.Text = "80 deg C";
            RightRearWarmTemp.Text = "80 deg C";
            LeftFrontCornerWeight.Text = "250 kg";
            RightFrontCornerWeight.Text = "250 kg";
            LeftRearCornerWeight.Text = "250 kg";
            RightRearCornerWeight.Text = "250 kg";
            LeftFrontToeIn.Text = "-2 mm";
            RightFrontToeIn.Text = "-2 mm";
            LeftRearToeIn.Text = "-2 mm";
            RightRearToeIn.Text = "-2 mm";

        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            var SuspensionClickLF = LeftFrontSuspensionClick.Text;
            var SuspensionClickRF = RightFrontSuspensionClick.Text;
            var SuspensionClickLR = LeftRearSuspensionClick.Text;
            var SuspensionClickRR = RightFrontSuspensionClick.Text;
            var TyreNumLF = LeftFrontTyreNum.Text;
            var TyreNumRF = RightFrontTyreNum.Text;
            var TyreNumLR = LeftRearTyreNum.Text;
            var TyreNumRR = RightRearTyreNum.Text;
            var TyrePreColdLF = LeftFrontColdPressure.Text;
            var TyrePreColdLR = LeftRearColdPressure.Text;
            var TyrePreColdRR = RightRearColdPressure.Text;
            var TyrePreColdRF = RightFrontColdPressure.Text;
            var TyreTempColdLF = LeftFrontColdTemp.Text;
            var TyreTempColdRF = RightFrontColdTemp.Text;
            var TyreTempColdLR = LeftRearColdTemp.Text;
            var TyreTempColdRR = RightRearColdTemp.Text;
            var TyrePreWarmLF = LeftFrontWarmPressure.Text;
            var TyrePreWarmRF = RightFrontWarmPressure.Text;
            var TyrePreWarmLR = LeftRearWarmPressure.Text;
            var TyrePreWarmRR = RightRearWarmPressure.Text;
            var TyreTempWarmLF = LeftFrontWarmTemp.Text;
            var TyreTempWarmRF = RightFrontWarmTemp.Text;
            var TyreTempWarmLR = LeftRearWarmTemp.Text;
            var TyreTempWarmRR = RightRearWarmTemp.Text;
            var CornerWeighLF = LeftFrontCornerWeight.Text;
            var CornerWeightRF = RightFrontCornerWeight.Text;
            var CornerWeightLR = LeftRearCornerWeight.Text;
            var CornerWeightRR = RightRearCornerWeight.Text;
            var ToeInLF = LeftFrontToeIn.Text;
            var ToeInRF = RightFrontToeIn.Text;
            var ToeInLR = LeftRearToeIn.Text;
            var ToeInRR = RightRearToeIn.Text;

            System.IO.File.Delete(@"Racelog.txt");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Racelog.txt", true))
            {
                
                file.WriteLine(SuspensionClickLF);
                file.WriteLine(SuspensionClickRF);
                file.WriteLine(SuspensionClickLR);
                file.WriteLine(SuspensionClickRR);
                file.WriteLine(TyreNumLF);
                file.WriteLine(TyreNumRF);
                file.WriteLine(TyreNumLR);
                file.WriteLine(TyreNumRR);
                file.WriteLine(TyrePreColdLF);
                file.WriteLine(TyrePreColdLR);
                file.WriteLine(TyrePreColdRR);
                file.WriteLine(TyrePreColdRF);
                file.WriteLine(TyreTempColdLF);
                file.WriteLine(TyreTempColdRF);
                file.WriteLine(TyreTempColdLR);
                file.WriteLine(TyreTempColdRR);
                file.WriteLine(TyrePreWarmLF);
                file.WriteLine(TyrePreWarmRF);
                file.WriteLine(TyrePreWarmLR);
                file.WriteLine(TyrePreWarmRR);
                file.WriteLine(TyreTempWarmLF);
                file.WriteLine(TyreTempWarmRF);
                file.WriteLine(TyreTempWarmLR);
                file.WriteLine(TyreTempWarmRR);
                file.WriteLine(CornerWeighLF);
                file.WriteLine(CornerWeightRF);
                file.WriteLine(CornerWeightLR);
                file.WriteLine(CornerWeightRR);
                file.WriteLine(ToeInLF);
                file.WriteLine(ToeInRF);
                file.WriteLine(ToeInLR);
                file.WriteLine(ToeInRR);

            }
        
        
        }

        private void LeftColdPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontColdPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightRearColdPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearColdPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontColdPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Printout_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TyreNumLF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontSuspensionClick_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontColdTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontWarmPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontWarmTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontCornerWeight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontToeIn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontSuspensionClick_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontColdTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontCornerWeight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftFrontTyreNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontWarmTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontWarmPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightFrontToeIn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearColdTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearWarmPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearWarmTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearCornerWeight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearToeIn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LeftRearSuspensionClick_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightRearColdTemp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightRearWarmPressure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightRearCornerWeight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RightRearToeIn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Test_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}

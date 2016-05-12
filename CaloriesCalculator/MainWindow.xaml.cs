using System;
using System.Collections.Generic;
using System.Globalization;
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
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.ImplementedClass.Models.PersonModel;

namespace CaloriesCalculator
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PersonRequirements person = new PersonRequirements(Sex.Male, int.Parse(AgeBox.Text),
                double.Parse(WeightBox.Text, CultureInfo.InvariantCulture),
                double.Parse(HeightBox.Text, CultureInfo.InvariantCulture));

            ResultBox.Text = person.CaloriesRequirement.ToString(ContentStringFormat);
        }
    }
}

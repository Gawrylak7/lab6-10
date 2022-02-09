using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab9
{
    /// <summary>
    /// Logika interakcji dla klasy GradeAddWindow.xaml
    /// </summary>
    public partial class GradeAddWindow : Window
    {
        public Ocena ocena { get; set; }

        public GradeAddWindow(Ocena ocena)
        {
            this.ocena = ocena;
            InitializeComponent();
            TextSubj.Text = ocena.przedmiot;
            TextVal.Text = ocena.wartosc.ToString();
        }

        public GradeAddWindow() : this(new Ocena())
        {
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextVal.Text, "\\d+((.?|,?)\\d+)?")) return;

            ocena.przedmiot = TextSubj.Text;
            ocena.wartosc = Convert.ToDouble(TextVal.Text);
            DialogResult = true;
        }
    }
}
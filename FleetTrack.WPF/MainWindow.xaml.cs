using System.Windows;
using FleetTrack.Domain;

namespace FleetTrack.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vehicul v = new Vehicul(
                txtNumar.Text,
                txtMarca.Text,
                txtModel.Text,
                double.Parse(txtCapacitate.Text),
                Culoare.Negru,
                Optiuni.AerConditionat
            );

            txtRezultat.Text = $"{v.Marca} {v.Model} - {v.CapacitateIncarcare} kg";
        }
    }
}
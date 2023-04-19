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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void buttonValidate_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            // Валидация поля "Больница"
            if (textBoxHospital.Text.Length < 10 || textBoxHospital.Text.Length > 40)
            {
                MessageBox.Show("Поле 'Больница' должно содержать от 10 до 40 символов");
                isValid = false;
            }

            // Валидация поля "ФИО врача"
            if (textBoxDoctor.Text.Length < 10 || textBoxDoctor.Text.Length > 60)
            {
                MessageBox.Show("Поле 'ФИО врача' должно содержать от 10 до 60 символов");
                isValid = false;
            }

            // Валидация поля "ФИО пациента"
            if (textBoxPatient.Text.Length < 10 || textBoxPatient.Text.Length > 60)
            {
                MessageBox.Show("Поле 'ФИО пациента' должно содержать от 10 до 60 символов");
                isValid = false;
            }

            // Валидация поля "Номер в очереди"
            if (!int.TryParse(textBoxQueue.Text, out int queueNumber) || queueNumber < 0)
            {
                MessageBox.Show("Поле 'Номер в очереди' должно содержать неотрицательное число");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Данные прошли валидацию");
            }
        }
    }
}

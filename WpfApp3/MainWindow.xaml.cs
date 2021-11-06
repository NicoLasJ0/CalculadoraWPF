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

namespace WpfApp3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String numT { get; set; }
        public String numT2 { get; set; }
        public double op1 { get; set; }
        public double op2 { get; set; }
        public double resultado { get; set; }
        public String signo { get; set; }

       
        string ni;
        
        


        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            numT = numT + (string)btn.Content;
            MostrarEnPantalla(numT);

        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            texto.Clear();
            numT = "";
            op1 = 0;
            op2 = 0;
            numT2 = "";
            resultado = 0;
            ni = "";
            signo = "";

        }
        private void MostrarEnPantalla(String num) 
        {
            texto.Text = num;
        }
           
        private void Button_Operacion(object sender, RoutedEventArgs e) 
        {

            
            texto.Clear();
            try
            {
                op1 = Double.Parse(numT);
                numT = "";
                Button button = sender as Button;
                signo = signo + (string)button.Content;
                if (signo == "+") ni = "+";
                if (signo == "-") ni = "-";
                if (signo == "*") ni = "*";
                if (signo == "/") ni = "/";
            }
            catch (FormatException)
            {

                texto.Text = "El valor introducido no es valido";
                op1 = 0;
            }
            
            


        }
        private void Button_Resultado(object sender, RoutedEventArgs e) 
        {
            try
            {
                numT2 = texto.Text;
                op2 = Double.Parse(numT2);
            }
            catch (FormatException)
            {

                texto.Text = "Introduzca un caracter valido";
                op2 = 0;
            }
            
            if (ni == "+") resultado = op1 + op2;
            if (ni == "-") resultado = op1 - op2;
            if (ni == "*") resultado = op1 * op2;
            if (ni == "/") resultado = op1 / op2;
            
            MostrarEnPantalla(resultado.ToString());
           
            
            //MessageBox.Show(op2.ToString());
        }
        private void Button_Punto(object sender, RoutedEventArgs e) 
        {
            MostrarEnPantalla(".");
        }



    }
}

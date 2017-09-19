using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            guardar.Clicked += guardar_Clicked;
        }
        private void guardar_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Datos Ingresados", "Bienvenida \n" + Nombre.Text + "\n" + Apellidos.Text + "" + Direccion.Text + "\n" + Telefono.Text + "\n" + Carrera.Text + "\n" + Semestre.Text + "\n" + Matricula.Text + "\n" + Correo.Text + "\n" + GitHub.Text, "OK");
        }
    }
}

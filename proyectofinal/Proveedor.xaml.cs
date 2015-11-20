using proyectofinal.mibd;
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

namespace proyectofinal
{
    /// <summary>
    /// Interaction logic for nuevaVentana.xaml
    /// </summary>
    public partial class nuevaVentana : Window
    {
        public nuevaVentana()
        {
            InitializeComponent();
        }

        private void enviarbd_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtnom.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(txtdir.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(txtgiro.Text, @"^[a-zA-Z]+$"))
            {
            index db = new index();
            Proveedor prov = new Proveedor();
            prov.NombreProveedor=txtnom.Text;
            prov.Direccion = txtdir.Text;
            prov.Giro=txtgiro.Text;


            db.Proveedores.Add(prov);
            db.SaveChanges();
        }
             else {MessageBox.Show("Solo letras y numero");}
        
        }
<<<<<<< HEAD
    }
}
=======

        private void borrarP_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(Actualizar.Text, @"^\d+$"))
            {

                index db = new index();
                int id = int.Parse(Actualizar.Text);
                var prov = db.Proveedores.SingleOrDefault(x => x.IdProveedor == id);

                if (prov != null)
                {
                    db.Proveedores.Remove(prov);
                    db.SaveChanges();

                }
            }
            else { MessageBox.Show("Solo Numeros en #id "); }
        }

        private void ModP_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtnom.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(txtdir.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(txtgiro.Text, @"^[a-zA-Z]+$"))
            {
                index db = new index();
                int id = int.Parse(Actualizar.Text);
                var prov = db.Proveedores.SingleOrDefault(x => x.IdProveedor == id);
               
                if (prov != null)
                {
                    prov.NombreProveedor = txtnom.Text;
                    prov.Direccion = txtdir.Text;
                    prov.Giro = txtgiro.Text;
                    db.SaveChanges();

                }
            }
            else { MessageBox.Show("Solo letras y numeros"); }
        }

        private void conp_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(Actualizar.Text, @"^\d+$"))
            {
                index db = new index();
                int id = int.Parse(Actualizar.Text);
                var registros = from s in db.Proveedores
                                where s.IdProveedor == id
                                select new
                                {
                                    s.NombreProveedor,
                                    s.Direccion,
                                    s.Giro
                                };
                dbgrid.ItemsSource = registros.ToList();
            }
            else { MessageBox.Show("Solo numeros"); }
        }
    }
  }
    
>>>>>>> creacion de pantallas

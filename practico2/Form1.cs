using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;

namespace practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            // para ver si los datos estan cargados o no en los text box
            if (String.IsNullOrEmpty(Tdni.Text) || String.IsNullOrEmpty(Tapellido.Text) || String.IsNullOrEmpty(Tnombre.Text))
            {

                //el primer parametro es el mensaje, el segunto es el titulo y el tercero o cuarto son los botones que van a aparecer
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                // permite modificar el label que se encuentra en rojo si pasa la primera validacion
                LModificar.Text = "MODIFICADO";
                DialogResult ask = MessageBox.Show("Seguro que\r\ndesea insertar un nuevo Cliente?", "Confirmacion insercion", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    String Tnomcompleto = Tapellido.Text + " " + Tnombre.Text;
                    MessageBox.Show("El cliente:" + " " + Tnomcompleto + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // determino si el valor que se coloco en el text de dni es un digito decimal
            bool digitodecimal = char.IsDigit(e.KeyChar);

            // la segunda parte solo permite que coloques numeros y no letras
            if (!digitodecimal && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("debe tener solo 8 caracteres", "Error", MessageBoxButtons.OKCancel);
                e.Handled = true;
            }

            if (Tdni.Text.Length == 8)
            {

                MessageBox.Show("debe tener solo 8 caracteres", "Error", MessageBoxButtons.OKCancel);
                e.Handled = true;
            }


        }

        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {


            //luego hacemos las verificaciones en base al valor obtenido del teclado, usaremos char.IsLetter si no es un valor que no sea letra y char.Iscontrol si es una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //no te deja ingresar mas datos al textbox en caso de que se cumpla la condicion
                e.Handled = true;
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            String Tnomcompleto = Tapellido.Text + " " + Tnombre.Text;

            if (String.Equals(LModificar.Text, "Modificar") == true)
            {
                MessageBox.Show("No hay cliente para eliminiar", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Esta a punto de eliminar al cliente:" + Tnomcompleto, "Confirmar eliminacion", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    Tdni.Clear();
                    Tapellido.Clear();
                    Tnombre.Clear();
                }
            }
        }

        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //luego hacemos las verificaciones en base al valor obtenido del teclado, usaremos char.IsLetter si no es un valor que no sea letra y char.Iscontrol si es una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //no te deja ingresar mas datos al textbox en caso de que se cumpla la condicion
                e.Handled = true;
            }
        }
    }
}

namespace U20251147
{

    /*Edgar Rigofredo Bermúdez Magaña codigo U20251147
     Mi autoevaluación es de 8.5
     Lo que me sale bien:

    Supe cómo hacer que los textBox solo acepten letras o números con la tecla que presiono (KeyPress).
    Le puse ganas para que el DUI lleve el guion solo y se vea más chivo, use herramientas externas como .
    Encontré un poco de dificultad en las condiciones dentro de los if, ya que para mi es nuevo lenguaje, soy nuevo usando C#.
    Revisar bien que los nombres de los textBox en la pantalla se llamen igual en el código.
    
    Deberia de mejorar el uso de las opciones que ya trae el programa como MaxLength para no complicarme tanto.
    Revisar siempre que no queden las casillas vacías antes de guardar. */ 

    public partial class FrmFichaEmpleado : Form
    {
        public FrmFichaEmpleado()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtDUI.Text.Length == 8 && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                txtDUI.Text += "-";
                txtDUI.SelectionStart = txtDUI.Text.Length;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string genero = "";
            if (rbiMasculino.Checked)
            {
                genero = "Masculino";
            }
            if (rbiFemenino.Checked)
            {
                genero = "Femenino";
            }
            string cargo = txtCargo.Text;
            string dui = txtDUI.Text;
            string edad = txtEdad.Text;
            string fechaIngreso = dtpFechaIngreso.Value.ToString("dd/MM/yyyy");

            MessageBox.Show($"Empleado Agregado Correctamente: \nNombre: {nombre}\nApellido: {apellido}\nGenero: {genero}\nCargo: {cargo}\nDUI: {dui}\nEdad: {edad}\nFecha de Ingreso: {fechaIngreso}");
        }
    }
}

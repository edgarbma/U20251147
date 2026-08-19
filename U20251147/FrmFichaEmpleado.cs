namespace U20251147
{
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

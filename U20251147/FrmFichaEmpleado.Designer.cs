namespace U20251147
{
    partial class FrmFichaEmpleado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblDUI = new Label();
            lblEdad = new Label();
            lblCargo = new Label();
            Genero = new Label();
            lblFechaIngreso = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDUI = new TextBox();
            txtEdad = new TextBox();
            txtCargo = new TextBox();
            rbiMasculino = new RadioButton();
            rbiFemenino = new RadioButton();
            dtpFechaIngreso = new DateTimePicker();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(84, 14);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.Location = new Point(84, 67);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 21);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDUI
            // 
            lblDUI.AutoSize = true;
            lblDUI.Font = new Font("Segoe UI", 12F);
            lblDUI.Location = new Point(84, 126);
            lblDUI.Name = "lblDUI";
            lblDUI.Size = new Size(39, 21);
            lblDUI.TabIndex = 2;
            lblDUI.Text = "DUI:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 12F);
            lblEdad.Location = new Point(84, 187);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(47, 21);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 12F);
            lblCargo.Location = new Point(84, 360);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(55, 21);
            lblCargo.TabIndex = 4;
            lblCargo.Text = "Cargo:";
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Font = new Font("Segoe UI", 12F);
            Genero.Location = new Point(84, 243);
            Genero.Name = "Genero";
            Genero.Size = new Size(64, 21);
            Genero.TabIndex = 5;
            Genero.Text = "Genero:";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 12F);
            lblFechaIngreso.Location = new Point(84, 298);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(130, 21);
            lblFechaIngreso.TabIndex = 6;
            lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(234, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 23);
            txtNombre.TabIndex = 7;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(234, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(234, 23);
            txtApellido.TabIndex = 8;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtDUI
            // 
            txtDUI.Location = new Point(234, 124);
            txtDUI.MaxLength = 10;
            txtDUI.Name = "txtDUI";
            txtDUI.Size = new Size(234, 23);
            txtDUI.TabIndex = 9;
            txtDUI.KeyPress += txtDUI_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(234, 185);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(234, 23);
            txtEdad.TabIndex = 10;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(234, 358);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(234, 23);
            txtCargo.TabIndex = 11;
            txtCargo.KeyPress += txtCargo_KeyPress;
            // 
            // rbiMasculino
            // 
            rbiMasculino.AutoSize = true;
            rbiMasculino.Location = new Point(243, 243);
            rbiMasculino.Name = "rbiMasculino";
            rbiMasculino.Size = new Size(80, 19);
            rbiMasculino.TabIndex = 12;
            rbiMasculino.TabStop = true;
            rbiMasculino.Text = "Masculino";
            rbiMasculino.UseVisualStyleBackColor = true;
            // 
            // rbiFemenino
            // 
            rbiFemenino.AutoSize = true;
            rbiFemenino.Location = new Point(374, 245);
            rbiFemenino.Name = "rbiFemenino";
            rbiFemenino.Size = new Size(78, 19);
            rbiFemenino.TabIndex = 13;
            rbiFemenino.TabStop = true;
            rbiFemenino.Text = "Femenino";
            rbiFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(234, 297);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(234, 23);
            dtpFechaIngreso.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Location = new Point(220, 415);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmFichaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 450);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(rbiFemenino);
            Controls.Add(rbiMasculino);
            Controls.Add(txtCargo);
            Controls.Add(txtEdad);
            Controls.Add(txtDUI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblFechaIngreso);
            Controls.Add(Genero);
            Controls.Add(lblCargo);
            Controls.Add(lblEdad);
            Controls.Add(lblDUI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmFichaEmpleado";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Ficha de Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDUI;
        private Label lblEdad;
        private Label lblCargo;
        private Label Genero;
        private Label lblFechaIngreso;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDUI;
        private TextBox txtEdad;
        private TextBox txtCargo;
        private RadioButton rbiMasculino;
        private RadioButton rbiFemenino;
        private DateTimePicker dtpFechaIngreso;
        private Button btnGuardar;
    }
}

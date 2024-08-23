namespace practico2
{
    partial class Form1
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
            LNombre = new Label();
            LModificar = new Label();
            Lnombree = new Label();
            LApellido = new Label();
            LDni = new Label();
            Tnombre = new TextBox();
            Tapellido = new TextBox();
            Tdni = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(40, 68);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(113, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre y Apellido :";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(187, 68);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // Lnombree
            // 
            Lnombree.AutoSize = true;
            Lnombree.Location = new Point(40, 248);
            Lnombree.Name = "Lnombree";
            Lnombree.Size = new Size(57, 15);
            Lnombree.TabIndex = 2;
            Lnombree.Text = "Nombre :";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(40, 182);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(57, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido :";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(40, 126);
            LDni.Name = "LDni";
            LDni.Size = new Size(33, 15);
            LDni.TabIndex = 4;
            LDni.Text = "DNI :";
            // 
            // Tnombre
            // 
            Tnombre.Location = new Point(145, 240);
            Tnombre.Name = "Tnombre";
            Tnombre.Size = new Size(100, 23);
            Tnombre.TabIndex = 5;
            Tnombre.KeyPress += Tnombre_KeyPress;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(145, 182);
            Tapellido.Name = "Tapellido";
            Tapellido.Size = new Size(100, 23);
            Tapellido.TabIndex = 6;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // Tdni
            // 
            Tdni.Location = new Point(145, 123);
            Tdni.Name = "Tdni";
            Tdni.Size = new Size(100, 23);
            Tdni.TabIndex = 7;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(78, 298);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(210, 298);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 425);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(Tdni);
            Controls.Add(Tapellido);
            Controls.Add(Tnombre);
            Controls.Add(LDni);
            Controls.Add(LApellido);
            Controls.Add(Lnombree);
            Controls.Add(LModificar);
            Controls.Add(LNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label LModificar;
        private Label Lnombree;
        private Label LApellido;
        private Label LDni;
        private TextBox Tnombre;
        private TextBox Tapellido;
        private TextBox Tdni;
        private Button BGuardar;
        private Button BEliminar;
    }
}

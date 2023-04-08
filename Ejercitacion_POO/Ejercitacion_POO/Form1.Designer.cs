namespace Ejercitacion_POO
{
    partial class FormPrincipal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelMostrarLista = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            btnSaludar = new Button();
            btnMostrarLista = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 22);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 111);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 205);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese su DNI:";
            // 
            // labelMostrarLista
            // 
            labelMostrarLista.AutoSize = true;
            labelMostrarLista.BackColor = SystemColors.GradientActiveCaption;
            labelMostrarLista.Location = new Point(252, 143);
            labelMostrarLista.Name = "labelMostrarLista";
            labelMostrarLista.Size = new Size(0, 20);
            labelMostrarLista.TabIndex = 3;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(50, 45);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(137, 27);
            textNombre.TabIndex = 4;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(50, 143);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(136, 27);
            textApellido.TabIndex = 5;
            // 
            // textDni
            // 
            textDni.Location = new Point(51, 241);
            textDni.Name = "textDni";
            textDni.Size = new Size(137, 27);
            textDni.TabIndex = 6;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(252, 45);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(169, 51);
            btnSaludar.TabIndex = 7;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // btnMostrarLista
            // 
            btnMostrarLista.Location = new Point(512, 45);
            btnMostrarLista.Name = "btnMostrarLista";
            btnMostrarLista.Size = new Size(169, 51);
            btnMostrarLista.TabIndex = 8;
            btnMostrarLista.Text = "Mostrar lista de clientes";
            btnMostrarLista.UseVisualStyleBackColor = true;
            btnMostrarLista.Click += btnMostrarLista_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 309);
            Controls.Add(btnMostrarLista);
            Controls.Add(btnSaludar);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(labelMostrarLista);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "Agregar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelMostrarLista;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private Button btnSaludar;
        private Button btnMostrarLista;
    }
}
namespace Repasoi1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonIngresarEmpleados = new System.Windows.Forms.Button();
            this.numericUpDownSueldoHora = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNoEmpleado = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonGenerar_Reporte = new System.Windows.Forms.Button();
            this.dataGridViewAsistencias = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSueldoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoEmpleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 646);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonIngresarEmpleados);
            this.tabPage1.Controls.Add(this.numericUpDownSueldoHora);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxApellido);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDownNoEmpleado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(614, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 499);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonIngresarEmpleados
            // 
            this.buttonIngresarEmpleados.Location = new System.Drawing.Point(193, 329);
            this.buttonIngresarEmpleados.Name = "buttonIngresarEmpleados";
            this.buttonIngresarEmpleados.Size = new System.Drawing.Size(235, 86);
            this.buttonIngresarEmpleados.TabIndex = 8;
            this.buttonIngresarEmpleados.Text = "Ingresar Empleado ";
            this.buttonIngresarEmpleados.UseVisualStyleBackColor = true;
            this.buttonIngresarEmpleados.Click += new System.EventHandler(this.buttonIngresarEmpleados_Click);
            // 
            // numericUpDownSueldoHora
            // 
            this.numericUpDownSueldoHora.DecimalPlaces = 2;
            this.numericUpDownSueldoHora.Location = new System.Drawing.Point(216, 233);
            this.numericUpDownSueldoHora.Name = "numericUpDownSueldoHora";
            this.numericUpDownSueldoHora.Size = new System.Drawing.Size(290, 22);
            this.numericUpDownSueldoHora.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sueldo por hora:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(216, 168);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(296, 22);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(216, 102);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(285, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // numericUpDownNoEmpleado
            // 
            this.numericUpDownNoEmpleado.Location = new System.Drawing.Point(216, 38);
            this.numericUpDownNoEmpleado.Name = "numericUpDownNoEmpleado";
            this.numericUpDownNoEmpleado.Size = new System.Drawing.Size(285, 22);
            this.numericUpDownNoEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de empleado:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAsistencias);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonGenerar_Reporte);
            this.tabPage3.Controls.Add(this.dataGridViewReporte);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1109, 617);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(169, 64);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(809, 325);
            this.dataGridViewReporte.TabIndex = 0;
            // 
            // buttonGenerar_Reporte
            // 
            this.buttonGenerar_Reporte.Location = new System.Drawing.Point(480, 443);
            this.buttonGenerar_Reporte.Name = "buttonGenerar_Reporte";
            this.buttonGenerar_Reporte.Size = new System.Drawing.Size(175, 59);
            this.buttonGenerar_Reporte.TabIndex = 1;
            this.buttonGenerar_Reporte.Text = "Generar reporte ";
            this.buttonGenerar_Reporte.UseVisualStyleBackColor = true;
            this.buttonGenerar_Reporte.Click += new System.EventHandler(this.buttonGenerar_Reporte_Click);
            // 
            // dataGridViewAsistencias
            // 
            this.dataGridViewAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencias.Location = new System.Drawing.Point(163, 36);
            this.dataGridViewAsistencias.Name = "dataGridViewAsistencias";
            this.dataGridViewAsistencias.RowHeadersWidth = 51;
            this.dataGridViewAsistencias.RowTemplate.Height = 24;
            this.dataGridViewAsistencias.Size = new System.Drawing.Size(806, 320);
            this.dataGridViewAsistencias.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 670);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSueldoHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoEmpleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericUpDownNoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericUpDownSueldoHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIngresarEmpleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGenerar_Reporte;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.DataGridView dataGridViewAsistencias;
    }
}


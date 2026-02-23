using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Repasoi1
{
    public partial class Form1 : Form
    {
        List <Empleados> empleado2 = new List<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Leer() 
        {
            string fileName = @"C:\Users\hp\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso1\Empleados.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader .Peek() > -1)
            {

                // Lee cada línea del archivo y asigna los valores a las propiedades del objeto Empleados
                Empleados empleado = new Empleados();
                empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.Apellido = reader.ReadLine();
                empleado.SuedoHora = Convert.ToDecimal(reader.ReadLine());

                empleado2.Add(empleado);
            }
            reader.Close();
        }

        private void GuardadEmpleados()
        {
            FileStream Stream = new FileStream(@"C:\Users\hp\Desktop\UMES 2025\3 semestre ing\Progra III\Repaso1\Empleados.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(Stream);
            foreach (var empleado in empleado2)
            {
                writer.WriteLine(empleado.NoEmpleado);
                writer.WriteLine(empleado.Nombre);
                writer.WriteLine(empleado.Apellido);
                writer.WriteLine(empleado.SuedoHora);

            }
            writer.Close();

        }

        private void mostrar()
        {
            dataGridView1 = null;
            dataGridView1.DataSource = empleado2;
        }


        private void buttonIngresarEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            empleado.NoEmpleado = Convert.ToInt16(numericUpDownNoEmpleado.Text);
            empleado.Nombre = textBoxNombre.Text;
            empleado.Apellido = textBoxApellido.Text;
            empleado.SuedoHora = numericUpDownSueldoHora.Value;

            empleado2.Add(empleado);

            GuardadEmpleados();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Leer();
            mostrar();
            numericUpDownNoEmpleado.Value = empleado2.Count + 1;


        }
    }
}

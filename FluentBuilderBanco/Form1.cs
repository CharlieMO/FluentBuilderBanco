using FluentBuilderBanco.Builder;
using FluentBuilderBanco.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentBuilderBanco
{
    public partial class Form1 : Form
    {
        private readonly Cuentas _Cuentas;

        public Form1()
        {
            InitializeComponent();

            _Cuentas = Cuentas.GetInstance();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string aux = textBox1.Text;
            bool[] flag = new bool[4];

            for (int i = 0; i < aux.Length; i++)
            {
                if (Char.IsDigit(aux[i]) == false)
                {
                    label7.Show();
                    flag[0] = true;
                    break;
                }
            }

            aux = textBox2.Text;

            if (aux.Length == 0)
            {
                flag[1] = true;
                label8.Show();
            }

            aux = textBox4.Text;
            int puntos = 0;

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == '.')
                    puntos++;

                else if (Char.IsDigit(aux[i]) == false || puntos > 1)
                {
                    label9.Show();
                    flag[2] = true;
                    break;
                }
            }

            aux = textBox3.Text;
            puntos = 0;

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == '.')
                    puntos++;

                else if (Char.IsDigit(aux[i]) == false || puntos > 1)
                {
                    label10.Show();
                    flag[3] = true;
                    break;
                }
            }

            for(int i=0; i<4; i++)
            {
                if(flag[i] == true)
                {
                    MessageBox.Show("Revisar sus datos. Verificar las instrucciones en rojo.");
                    return;
                }
            }

            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }


            TipoEnum tipo = (TipoEnum)Enum.Parse(typeof(TipoEnum), comboBox1.SelectedItem.ToString());

            Cuenta cuentanueva = CuentaFluentBuilder.Crear(tipo)
                .NumeroCuenta(Int32.Parse(textBox1.Text))
                .Propietario(textBox2.Text)
                .Tasa(double.Parse(textBox3.Text))
                .SaldoInicial(double.Parse(textBox4.Text))
                .AbrirCuenta();

            _Cuentas.ListaCuentas.Add(cuentanueva);

            var source = new BindingSource(_Cuentas.ListaCuentas, null);
            dataGridView1.DataSource = source;

            MessageBox.Show("Cuenta creada exitosamente.");
        }

        private void label7_corregir(object sender, EventArgs e)
        {
            label7.Hide();
        }
        private void label8_corregir(object sender, EventArgs e)
        {
            label8.Hide();
        }
        private void label9_corregir(object sender, EventArgs e)
        {
            label9.Hide();
        }
        private void label10_corregir(object sender, EventArgs e)
        {
            label10.Hide();
        }

    }
}

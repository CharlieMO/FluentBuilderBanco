using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderBanco.Models
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public string Propietario { get; set; }
        public double Tasa { get; set; }
        public TipoEnum Tipo { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(int numerocuenta, double saldo, string propietario, double tasa, TipoEnum tipo)
        {
            NumeroCuenta = numerocuenta;
            Saldo = saldo;
            Propietario = propietario;
            Tasa = tasa;
            Tipo = tipo;
        }
    }
}

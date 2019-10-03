using FluentBuilderBanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderBanco.Builder
{
    public class CuentaFluentBuilder
    {
        private readonly Cuenta _cuenta;

        public static CuentaFluentBuilder Crear(TipoEnum tipo)
        {
            return new CuentaFluentBuilder(tipo);
        }

        private CuentaFluentBuilder(TipoEnum tipo)
        {
            _cuenta = new Cuenta {Tipo = tipo};
        }

        public CuentaFluentBuilder NumeroCuenta(int numerocuenta)
        {
            _cuenta.NumeroCuenta = numerocuenta;
            return this;
        }
        public CuentaFluentBuilder Propietario(string propietario)
        {
            _cuenta.Propietario = propietario;
            return this;
        }
        public CuentaFluentBuilder Tasa(double tasa)
        {
            _cuenta.Tasa = tasa;
            return this;
        }
        public CuentaFluentBuilder SaldoInicial(double saldoinicial)
        {
            _cuenta.Saldo = saldoinicial;
            return this;
        }

        public Cuenta AbrirCuenta()
        {
            return _cuenta;
        }
    }
}

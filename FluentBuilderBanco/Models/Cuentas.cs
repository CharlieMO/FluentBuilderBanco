using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderBanco.Models
{
    public class Cuentas
    {
        private Cuentas() { }

        private static Cuentas _instance;

        private static readonly object _lock = new object();

        public static Cuentas GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Cuentas();
                    }
                }
            }
            return _instance;
        }

        public List<Cuenta> ListaCuentas = new List<Cuenta>();
    }
}

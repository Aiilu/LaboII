﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banano :Planta
    {
        private string codigo;

        public Banano(string nombre, int tamanio, string codigo) :base(nombre, tamanio)
        {
            this.codigo = codigo;
        }

        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }

        public override bool TieneFruto
        {
            get
            {
                return true;
            }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.ResumenDeDatos());
            datos.AppendFormat(" Codigo Internacional: {0}", this.codigo);

            return datos.ToString();
        }
    }
}

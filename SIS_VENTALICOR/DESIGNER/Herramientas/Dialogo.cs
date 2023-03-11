﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Herramientas
{
    public static class Dialogo
    {
        //Enviar alertas informes simples
        public static void Informar(string mensaje)
        {
            MessageBox.Show(mensaje, "Licoreria versión 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //alerta tipo error
        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Licoreria versión 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //alerta tipo pregunta
        public static DialogResult Preguntar(string mensaje)
        {
            return MessageBox.Show(mensaje, "Licoreria versión 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

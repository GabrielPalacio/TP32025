using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio.Metodo
{
    internal class MetodoEuler
    {

        // dS/dT = -10-S^2/S0

        private double variable_t; //t
        private double variable_S0; //s
        private double proximo_valor; 
        private double paso_h;

        private Formulario_Euler formulario_euler;

        private double tiempo_obtenido;

        public MetodoEuler(double paso, double condicion_inicial_uno)
        {
            this.paso_h = paso;
            this.variable_t = condicion_inicial_uno;

            this.formulario_euler = new Formulario_Euler();
        }

        public double calcular_tiempo_para_formateo_inicial(Double valor_H_corte, Double condicion_inicial_dos)
        {
            double t = this.variable_t;
            double s = condicion_inicial_dos;
            double s0 = condicion_inicial_dos;
            double ds = Math.Round((-10 - ((Math.Pow(s, 2)) / s)) * 10000) / 10000;

            //dS/dT = -10-S^2/S0

            this.proximo_valor = Math.Round((s + this.paso_h*ds) * 10000) / 10000;
            switch (condicion_inicial_dos)
            {
                case 1000:
                    this.formulario_euler.agregar_fila(t, s, ds, this.proximo_valor,1);
                    do
                    {
                        //Actualización de la variable independiente
                        t = Math.Round((this.paso_h + t) * 100) / 100;
                        //Actualización de la variable dependiente
                        s = proximo_valor;
                        //acá si le pongo dividido por s, funciona de maravilla
                        ds = Math.Round((-10 - ((Math.Pow(s, 2)) / s0)) * 10000) / 10000;
                        //Calculamos el proximo valor
                        //this.proximo_valor = -5 * Math.Pow(t, 2) + 2 * H - 200;
                        this.proximo_valor = Math.Round((s + this.paso_h * ds) * 10000) / 10000;
                        this.formulario_euler.agregar_fila(t, s, ds, this.proximo_valor, 1);
                    } while (valor_H_corte < s);
                    //Marcamos en la grilla el valor obtenido
                    this.formulario_euler.pintar_fila_seleccionada(1);
                    break;
                case 1500:
                    this.formulario_euler.agregar_fila(t, s, ds, this.proximo_valor, 2  );
                    do
                    {
                        //Actualización de la variable independiente
                        t = Math.Round((this.paso_h + t) * 100) / 100;
                        //Actualización de la variable dependiente
                        s = proximo_valor;
                        //acá si le pongo dividido por s, funciona de maravilla
                        ds = Math.Round((-10 - ((Math.Pow(s, 2)) / s0)) * 10000) / 10000;
                        //Calculamos el proximo valor
                        //this.proximo_valor = -5 * Math.Pow(t, 2) + 2 * H - 200;
                        this.proximo_valor = Math.Round((s + this.paso_h * ds) * 10000) / 10000;
                        this.formulario_euler.agregar_fila(t, s, ds, this.proximo_valor,2);
                    } while (valor_H_corte < s);
                    //Marcamos en la grilla el valor obtenido
                    this.formulario_euler.pintar_fila_seleccionada(2);
                    break;
                case 2000:
                    this.formulario_euler.agregar_fila(t, s, ds, this.proximo_valor,3);
                    do
                    {
                        //Actualización de la variable independiente
                        t = Math.Round((this.paso_h + t) * 100) / 100;
                        //Actualización de la variable dependiente
                        s = proximo_valor;
                        //acá si le pongo dividido por s, funciona de maravilla
                        ds = Math.Round((-10 - ((Math.Pow(s, 2)) / s0)) * 10000) / 10000;
                        //Calculamos el proximo valor
                        //this.proximo_valor = -5 * Math.Pow(t, 2) + 2 * H - 200;
                        this.proximo_valor = Math.Round((s + this.paso_h * ds) * 10000) / 10000;
                        this.formulario_euler.agregar_fila(t, s, ds, this.proximo_valor,3);
                    } while (valor_H_corte < s);
                    //Marcamos en la grilla el valor obtenido
                    this.formulario_euler.pintar_fila_seleccionada(3);
                    break;
            }
                    //Saliendo del ciclo H, devolvemos la variable t (tiempo)
                    //return t;
                    this.tiempo_obtenido = t;
                    return t;

        }

        internal void mostrar_grilla()
        {
            this.formulario_euler.ShowDialog();
        }

    }
}

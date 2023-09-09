using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class CalculadoraTest
    {
        // Clase_Metodo_ResultadoEsperado
        [Fact]
        public void Calculadora_Sumar_RetornaEntero()
        {
            //A - Arrage, obtener todo lo que se necesita 
            Calculadora calculadora = new Calculadora();
            int numeroUno = 1;
            int numeroDos = 2;

            //A - Act, Ejecutar la función
            int resultado = calculadora.Sumar(numeroUno, numeroDos);

            //A - Assert, Validar si funciona correctamente, si funciona como lo esperamos
            if (resultado == 3)
            {
                Console.WriteLine("APROBADO: Calculadora_Sumar_RetornaEntero");
            }
            else
            {
                Console.WriteLine("FALLIDO: Calculadora_Sumar_RetornaEntero");
            }

        }

        [Fact]
        public void Calculadora_Restar_RetornaEntero()
        {
            //A - Arrage, obtener todo lo que se necesita 
            Calculadora calculadora = new Calculadora();
            int numeroUno = 2;
            int numeroDos = 1;

            //A - Act, Ejecutar la función
            int resultado = calculadora.Restar(numeroUno, numeroDos);

            //A - Assert, Validar si funciona correctamente, si funciona como lo esperamos
            if (resultado == 1)
            {
                Console.WriteLine("APROBADO: Calculadora_Restar_RetornaEntero");
            }
            else
            {
                Console.WriteLine("FALLIDO: Calculadora_Restar_RetornaEntero");
            }

        }

        [Fact]
        public void Calculadora_Sumar_RetornaLaSuma()
        {
            Calculadora calculadora = new Calculadora();
            int numeroUno = 1;
            int numeroDos = 2;

            int resultado = calculadora.Sumar(numeroDos, numeroUno);

            Assert.Equal(3, resultado);
        }
    }
}

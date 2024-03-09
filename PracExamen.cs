using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenED
{
    public class Persona
    {
        public string nombre;
        public int altura;
        public double peso;
        public int edad;

        public const int ERROR_ESTATURA = -1;
        public const int ERROR_PESO = -1;
        public const int ERROR_NOMBRE = 0;
        public const int ERROR_EDAD = -1;

        public Persona() {
            this.nombre = "";
            this.altura = 0;
            this.peso = 0.0;
            this.edad = 0;
        }

        public Persona(string nombre,int altura,double peso,int edad) {
            Nombre = nombre;
            this.Altura = altura;
            Peso = peso;
            this.Edad = edad;
        }

        public string Nombre {
            get => nombre;
            set {
                if (value != "") {
                    this.nombre = value;
                } else {
                    this.nombre = ERROR_NOMBRE.ToString();
                }
            }
        }

        public int Altura {
            get => altura;
            set {

                if (value > 1) {
                    this.altura = value;
                } else {
                    this.altura = ERROR_ESTATURA;
                }
            }
        }

        public double Peso {
            get => peso;
            set {
                if (value > 1) {
                    this.peso = value;
                } else {
                    this.peso = ERROR_PESO;
                }
            }
        }

        public int Edad {
            get => edad;
            set {
                if (value > 0) {
                    this.edad = value;
                } else {
                    this.edad = ERROR_EDAD;
                }
            }
        }

        public double imc() {
            double imc = 0.0;
            if (peso < 1) {
                return Persona.ERROR_PESO;
            }
            if (altura < 10) {
                return Persona.ERROR_ESTATURA;
            }

            imc = (peso / ((altura/100) * (altura/100)) );

            return imc;
        }

        public string estaturaMedia() {
            string estatura = "";
            if (altura > 0) {
                if (altura < 100) {
                    estatura = "Posible Acondroplasia";
                }
                if (altura > 100 && altura < 180) {
                    estatura = "normal";
                }
                if (altura > 180) {
                    estatura = "mayor de la media";
                }
            } else {
                estatura = Persona.ERROR_ESTATURA.ToString();
            }
            return estatura;
        }

        public string mostrarPersona() {
            return this.nombre + "\n" +
            this.altura + " cms\n" +
            this.peso + " kgs\n" +
            this.edad + " anyos\n";
        }
    }
}

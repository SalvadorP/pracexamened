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
                    this.nombre = "";
                }
            }
        }

        public int Altura {
            get => altura;
            set {

                if (value > 1) {
                    this.altura = value;
                } else {
                    this.altura = 1;
                }
            }
        }

        public double Peso {
            get => peso;
            set {
                if (value > 1) {
                    this.peso = value;
                } else {
                    this.peso = 1;
                }
            }
        }

        public int Edad {
            get => edad;
            set {
                if (value > 0) {
                    this.edad = value;
                } else {
                    this.edad = 1;
                }
            }
        }

        public double imc() {
            double imc = 0.0;
            if (peso < 1) {
                return 1;
            }
            if (altura < 10) {
                return 1;
            }

            double alt = (((double) altura)/100);
            imc = (peso / (alt*alt));

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
                estatura = "";
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

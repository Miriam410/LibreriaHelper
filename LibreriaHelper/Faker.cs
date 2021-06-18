using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHelper
{
    public class Faker
    {
        // https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=netcore-3.1
        private Random _rnd;

        // Read more: https://10ejemplos.com/10-ejemplos-de-nombres-propios/#ixzz6bopYzxHx
        private string[] _nombres = {
            "Álan", "Jacinto", "Martinez", "Alicia", "Jesús", "Mirta", "Andrea", "Josefina", "Mónica", "Andrés", "Juan", "Nicolás", "Antonia", "Juana", "Noé", "Antonio", "Juano", "Noelia", "Azul", "Julia", "Paula", "Bartolomé", "Julián", "Pomponio", "Belén", "Juliana", "Renzo", "Celeste", "Julio", "Rodrigo", "Edgardo", "Leandra", "Rodriguez", "Felicia", "Luis", "Romina", "Florencia", "Luisa", "Rosario", "Gaspar", "Marcelo", "Tato", "Gerardo", "Marcos", "Tomás", "Gimenez", "María", "Victor", "Gonzalo", "Mariano", "Yayo", "Gustavo", "Martín", "Zulema"
        };
        private string[] _apellidos = {
            "García", "González", "Rodríguez", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martin", "Jiménez", "Ruiz", "Hernández", "Diaz", "Moreno", "Muñoz", "Álvarez", "Romero", "Alonso", "Gutiérrez", "Navarro", "Torres", "Domínguez", "Vázquez", "Ramos", "Gil", "Ramírez", "Serrano", "Blanco", "Molina", "Morales", "Suarez", "Ortega", "Delgado", "Castro", "Ortiz", "Rubio", "Marín", "Sanz", "Núñez", "Iglesias", "Medina", "Garrido", "Cortes", "Castillo", "Santos", "Lozano", "Guerrero", "Cano", "Prieto", "Méndez", "Cruz", "Calvo", "Gallego", "Vidal", "León", "Márquez", "Herrera", "Peña", "Flores", "Cabrera", "Campos", "Vega", "Fuentes", "Carrasco", "Diez", "Caballero", "Reyes", "Nieto", "Aguilar", "Pascual", "Santana", "Herrero", "Lorenzo", "Montero", "Hidalgo", "Giménez", "Ibáñez", "Ferrer", "Duran", "Santiago", "Benítez", "Mora", "Vicente", "Vargas", "Arias", "Carmona", "Crespo", "Román", "Pastor", "Soto", "Sáez", "Velasco", "Moya", "Soler", "Parra", "Esteban", "Bravo", "Gallardo", "Rojas"
        };
        private string[] _nombresMujer = {
            "Adriana", "Alejandra", "Bertha", "Carmen", "Diana", 
            "Josefina", "Julieta", "Karla", "María", "Susana"
        };
        private string[] _nombresHombre = {
            "Alejandro", "Benito", "Carlos", "Daniel", "Ernesto", 
            "Felipe", "Gerardo", "Héctor", "Isaías", "Omar"
        };
        private string[] _nombreLugares = {
            "Ámsterdam", "Berlín", "Caracas", "Durango", "Edimburgo", 
            "Filipinas", "Groenlandia", "Irlanda", "Oklahoma", "México"
        };
        private string[] _materialesRopa = {
            "Algodón", "Batista de algodón", "Lino", "Punto de jersey de algodón", 
            "Voile", "Polar", "Muselina", "Microfibra", "Cuero"
        };
        private string[] _tallesRopa = {
            "XS", "XS", "XS", "S", "S", "M", "M", "L", "L", "XL", "XL", "XXL", "XXL"
        };
        private string[] _tiposMangasCamisa = {
            "Manga francesa", "Manga kimono", "Mangas farol", "Manga bombacha"
        };
        private string[] _tiposGaseosas = {
            "Coca-Cola", "Pepsi", "Dr Pepper", "Fanta", "7 Up", "Sprite", "Royal Crown Cola", 
            "Big Cola", "Canada Dry", "Inca Kola"
        };
        private bool[] _trueFalse = { true, false };

        public Faker()
        {
            this._rnd = new Random();
        }

        public bool Booleano()
        {
            return this._trueFalse[GetBooleanIndex(this._trueFalse)];
        }

        public int Integer(int min = 5000, int max = 100000)
        {
            return this._rnd.Next(min, max);
        }

        public double Decimal(int min = 5000, int max = 100000)
        {
            return (double) this.Integer(min, max) / 100;
        }

        public string Nombre()
        {
            return this._nombres[GetIndex(this._nombres)];
        }

        public string Apellido()
        {
            return this._apellidos[GetIndex(this._apellidos)];
        }

        public string Codigo(string prefijo = "")
        {
            return prefijo + this.Integer();
        }

        public string NombreMujer()
        {
            return this._nombresMujer[GetIndex(this._nombresMujer)];
        }

        public string NombreHombre()
        {
            return this._nombresHombre[GetIndex(this._nombresHombre)];
        }

        public string NombreLugar()
        {
            return this._nombreLugares[GetIndex(this._nombreLugares)];
        }

        public string MaterialRopa()
        {
            return this._materialesRopa[GetIndex(this._materialesRopa)];
        }

        public string TalleRopa()
        {
            return this._tallesRopa[GetIndex(this._tallesRopa)];
        }

        public string MangaCamisa()
        {
            return this._tiposMangasCamisa[GetIndex(this._tiposMangasCamisa)];
        }

        public string Gaseosa()
        {
            return this._tiposGaseosas[GetIndex(this._tiposGaseosas)];
        }

        private int GetIndex(string[] listado)
        {
            return this._rnd.Next(listado.Length);
        }

        private int GetBooleanIndex(bool[] listado)
        {
            return this._rnd.Next(listado.Length);
        }
    }
}

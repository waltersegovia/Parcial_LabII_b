using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Jardin
{
    public class CargaInfo
    {
        List<Docente>listaDocentesSinAula;
        List<Alumno> alumnos;
        List<Administrativo> listaNoDocente;
   
        public List<Docente> Docentes { get { return this.listaDocentesSinAula; } }
        public List<Alumno> listaAlumnos{ get { return this.alumnos; } }
        public List<Administrativo> NoDocentes { get { return this.listaNoDocente; } }

        public CargaInfo()
        {
            alumnos = new List<Alumno>();
            listaDocentesSinAula = new List<Docente>();
            listaNoDocente = new List<Administrativo>();


            //**** Docentes ****
            Docente d1 = new Docente("Alberto", "Trota", 11111111, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), 500.00);
            Docente d2 = new Docente("Franco", "Marcheta", 11111112, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), 500.00);
            Docente d3 = new Docente("Esteban", "Rojo", 11111113, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), 500.00);
            Docente d4 = new Docente("Vanesa", "Vazquez", 11111114, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), 600.00);
            Docente d5 = new Docente("Marcela", "Quinteroz", 11111115, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), 600.00);
            listaDocentesSinAula.Add(d1);
            listaDocentesSinAula.Add(d2);
            listaDocentesSinAula.Add(d3);
            listaDocentesSinAula.Add(d4);
            listaDocentesSinAula.Add(d5);
            //auxAula = new Aula(EColores.Amarillo, ETurno.Mañana, d1);


            listaNoDocente.Add(new Administrativo("Armando", "Fernandez", 52345641, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), ECargo.Cocina));
            listaNoDocente.Add(new Administrativo("Bastian", "Barrios", 52345642, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), ECargo.Dirección));
            listaNoDocente.Add(new Administrativo("Ivan", "Vallejos", 52345643, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), ECargo.Portería));
            listaNoDocente.Add(new Administrativo("Leo", "Garciarena", 52345644, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), ECargo.Secretaría));
            listaNoDocente.Add(new Administrativo("Adrian", "Ponce", 52345645, false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), ECargo.Tesorería));
            listaNoDocente.Add(new Administrativo("Lolo", "Garcia", 52345646, false, DateTime.Parse("13:00"), DateTime.Parse("17:00"), ECargo.Portería));
            listaNoDocente.Add(new Administrativo("Lara", "Gonzalez", 52345647, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), ECargo.Cocina));
            listaNoDocente.Add(new Administrativo("Catalina", "Perez", 52345648, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), ECargo.Cocina));
            listaNoDocente.Add(new Administrativo("Mora", "Ramirez", 52345649, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), ECargo.Secretaría));
            listaNoDocente.Add(new Administrativo("Mara", "Mendez", 52345650, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), ECargo.Cocina));

        }

        public void Carga()
        {

            Responsable r1 = new Responsable("Alberto", "Gomez", 12345672, EParentesco.Padre, "1111111");
            Responsable r2 = new Responsable("Jimena", "Garcia", 22345678, EParentesco.Madre, "2111111");
            Responsable r3 = new Responsable("Angie", "Ponce", 32345671, EParentesco.Madre, "3111111");
            Responsable r4 = new Responsable("Juan", "Garcia", 23345678, EParentesco.Abuelo, "4111111");
            Responsable r5 = new Responsable("Antonio", "Gonzalez", 13345676, EParentesco.Abuelo, "5111111");
            Responsable r6 = new Responsable("Jorgelina", "Perez", 42345678, EParentesco.Madre, "6111111");
            Responsable r7 = new Responsable("Amelia", "Ramirez", 35345675, EParentesco.Madre, "7111111");
            Responsable r8 = new Responsable("Jose", "Mendez", 45345678, EParentesco.Tio, "8111111");
            Responsable r9 = new Responsable("Jorge", "Fernandez", 28345675, EParentesco.Padre, "9111111");
            Responsable r10 = new Responsable("Alicia", "Barrios", 25346678, EParentesco.Madre, "1011111");
            Responsable r11 = new Responsable("Angelica", "Vallejos", 31145678, EParentesco.Madre, "1211111");
            Responsable r12 = new Responsable("Juana", "Garciarena", 24545674, EParentesco.Madre, "1311111");
            Responsable r13 = new Responsable("Mauro", "Cortez", 55345378, EParentesco.Padre, "1411111");
            Responsable r14 = new Responsable("Marcelo", "Perez", 42665671, EParentesco.Padre, "1511111");
            Responsable r15 = new Responsable("Carmen", "Benitez", 35995678, EParentesco.Madre, "1611111");
            Responsable r16 = new Responsable("Javier", "Mendez", 39345673, EParentesco.Tio, "1811111");
            Responsable r17 = new Responsable("Alfio", "Gomez", 12345672, EParentesco.Padre, "1111111");
            Responsable r18 = new Responsable("Jime", "Garcia", 22355678, EParentesco.Madre, "2111111");
            Responsable r19 = new Responsable("Laura", "Ponce", 32355671, EParentesco.Madre, "3111111");
            Responsable r20 = new Responsable("Andres", "Junco", 23145678, EParentesco.Abuelo, "4111111");
            Responsable r21 = new Responsable("Manuel", "Duarte", 13241676, EParentesco.Abuelo, "5111111");
            Responsable r22 = new Responsable("Marcela", "Perez", 42115678, EParentesco.Madre, "6111111");
            Responsable r23 = new Responsable("Sandra", "Ramirez", 35115675, EParentesco.Madre, "7111111");
            Responsable r24 = new Responsable("Fabian", "Mendez", 45311678, EParentesco.Tio, "8111111");
            Responsable r25 = new Responsable("Ricardo", "Fernandez", 28115675, EParentesco.Padre, "9111111");
            Responsable r26 = new Responsable("Lisandra", "Barrios", 25311678, EParentesco.Madre, "1011111");
            Responsable r27 = new Responsable("Noelia", "Vallejos", 31111678, EParentesco.Madre, "1211111");
            Responsable r28 = new Responsable("Mariela", "Garciarena", 24115674, EParentesco.Madre, "1311111");
            Responsable r29 = new Responsable("Francisco", "Cortez", 55311378, EParentesco.Padre, "1411111");
            Responsable r30 = new Responsable("Ariel", "Perez", 42115671, EParentesco.Padre, "1511111");
            Responsable r31 = new Responsable("Ruben", "Benitez", 35115678, EParentesco.Madre, "1611111");
            Responsable r32 = new Responsable("Raul", "Mendez", 39115673, EParentesco.Tio, "1811111");
            Responsable r33 = new Responsable("Alberto", "Suarez", 12345682, EParentesco.Padre, "1111111");
            Responsable r34 = new Responsable("Jimena", "Velez", 223456788, EParentesco.Madre, "2111111");
            Responsable r35 = new Responsable("Angie", "Valdez", 32343331, EParentesco.Madre, "3111111");
            Responsable r36 = new Responsable("Juan", "Britos", 23343338, EParentesco.Abuelo, "4111111");
            Responsable r37 = new Responsable("Antonio", "Martinez", 13335676, EParentesco.Abuelo, "5111111");
            Responsable r38 = new Responsable("Jorgelina", "Ortiz", 42333678, EParentesco.Madre, "6111111");
            Responsable r39 = new Responsable("Amelia", "Vargas", 35555675, EParentesco.Madre, "7111111");
            Responsable r40 = new Responsable("Jose", "Quispe", 45355678, EParentesco.Tio, "8111111");
            Responsable r41 = new Responsable("Jorge", "Matos", 28322675, EParentesco.Padre, "9111111");
            Responsable r42 = new Responsable("Alicia", "Alegre", 25226678, EParentesco.Madre, "1011111");
            Responsable r43 = new Responsable("Angelica", "Balbo", 31225678, EParentesco.Madre, "1211111");
            Responsable r44 = new Responsable("Juana", "Molina", 24225674, EParentesco.Madre, "1311111");
            Responsable r45 = new Responsable("Mauro", "Olmedo", 55345378, EParentesco.Padre, "1411111");
            Responsable r46 = new Responsable("Marcelo", "Portales", 43365671, EParentesco.Padre, "1511111");
            Responsable r47 = new Responsable("Carmen", "Fusco", 35993378, EParentesco.Madre, "1611111");
            Responsable r48 = new Responsable("Javier", "Olave", 39333673, EParentesco.Tio, "1811111");
            Responsable r49 = new Responsable("Alfio", "Robledo", 12335672, EParentesco.Padre, "1111111");
            Responsable r50 = new Responsable("Jime", "Maldonado", 22333678, EParentesco.Madre, "2111111");

            alumnos.Add(new Alumno("Aron", "Gomez", 52345601, false, EColores.Amarilla, 1, 5000f, r1));
            alumnos.Add(new Alumno("Manu", "Garcia", 52345602, false, EColores.Amarilla, 2, 5000f, r2));
            alumnos.Add(new Alumno("Matias", "Ponce", 52345603, false, EColores.Amarilla, 3, 5000f, r3));
            alumnos.Add(new Alumno("Lionel", "Garcia", 52345604, false, EColores.Amarilla, 4, 5000f, r4));
            alumnos.Add(new Alumno("Azul", "Gonzalez", 52345605, true, EColores.Amarilla, 5, 5000f, r5));
            alumnos.Add(new Alumno("Ambar", "Perez", 52345606, true, EColores.Amarilla, 6, 5000f, r6));
            alumnos.Add(new Alumno("Mia", "Ramirez", 52345607, true, EColores.Amarilla, 7, 5000f, r7));
            alumnos.Add(new Alumno("Renata", "Mendez", 52345608, true, EColores.Amarilla, 8, 5000f, r8));
            alumnos.Add(new Alumno("Ariel", "Fernandez", 52345609, false, EColores.Amarilla, 9, 5000f, r9));
            alumnos.Add(new Alumno("Manuel", "Barrios", 52345610, false, EColores.Amarilla, 10, 5000f, r10));
            alumnos.Add(new Alumno("Matute", "Vallejos", 52345611, false, EColores.Amarilla, 11, 5000f, r11));
            alumnos.Add(new Alumno("Lautaro", "Garciarena", 52345612, false, EColores.Amarilla, 12, 5000f, r12));
            alumnos.Add(new Alumno("Brisa", "Cortez", 52345613, true, EColores.Amarilla, 13, 5000f, r13));
            alumnos.Add(new Alumno("Uma", "Perez", 52345614, true, EColores.Amarilla, 14, 5000f, r14));
            alumnos.Add(new Alumno("Valentina", "Benitez", 52345615, true, EColores.Amarilla, 15, 5000f, r15));
            alumnos.Add(new Alumno("Matilde", "Mendez", 52345616, true, EColores.Amarilla, 16, 5000f, r16));
            alumnos.Add(new Alumno("Joaquin", "Gomez", 52345617, false, EColores.Amarilla, 17, 5000f, r17));
            alumnos.Add(new Alumno("Thiago", "Garcia", 52345618, false, EColores.Amarilla, 18, 5000f, r18));
            alumnos.Add(new Alumno("Valentin", "Ponce", 52345619, false, EColores.Amarilla, 19, 5000f, r19));
            alumnos.Add(new Alumno("Valentino", "Garcia", 52345620, false, EColores.Amarilla, 20, 5000f, r20));

            alumnos.Add(new Alumno("Leila", "Gonzalez", 52345621, true, EColores.Naranja, 21, 5000f, r21));
            alumnos.Add(new Alumno("Franchesca", "Perez", 52345622, true, EColores.Naranja, 22, 5000f, r22));
            alumnos.Add(new Alumno("Sol", "Ramirez", 52345623, true, EColores.Naranja, 23, 5000f, r23));
            alumnos.Add(new Alumno("Luz", "Mendez", 52345624, true, EColores.Naranja, 24, 5000f, r24));
            alumnos.Add(new Alumno("Nazareno", "Fernandez", 52345625, false, EColores.Naranja, 25, 5000f, r25));
            alumnos.Add(new Alumno("Benito", "Barrios", 52345626, false, EColores.Naranja, 26, 5000f, r26));
            alumnos.Add(new Alumno("Marcos", "Vallejos", 52345627, false, EColores.Naranja, 27, 5000f, r27));
            alumnos.Add(new Alumno("Angel", "Garciarena", 52345628, false, EColores.Naranja, 28, 5000f, r28));
            alumnos.Add(new Alumno("Naza", "Cortez", 52345629, true, EColores.Naranja, 29, 5000f, r29));
            alumnos.Add(new Alumno("Nazarena", "Perez", 52345630, true, EColores.Naranja, 30, 5000f, r30));

            alumnos.Add(new Alumno("Violeta", "Benitez", 52345631, true, EColores.Roja, 31, 5000f, r31));
            alumnos.Add(new Alumno("Matilda", "Mendez", 52345632, true, EColores.Roja, 32, 5000f, r32));
            alumnos.Add(new Alumno("Enzo", "Gomez", 52345633, false, EColores.Roja, 33, 5000f, r33));
            alumnos.Add(new Alumno("Eric", "Garcia", 52345634, false, EColores.Roja, 34, 5000f, r34));
            alumnos.Add(new Alumno("Hugo", "Ponce", 52345635, false, EColores.Roja, 35, 5000f, r35));
            alumnos.Add(new Alumno("Leonel", "Garcia", 52345636, false, EColores.Roja, 36, 5000f, r36));
            alumnos.Add(new Alumno("Ana", "Gonzalez", 52345637, true, EColores.Roja, 37, 5000f, r37));
            alumnos.Add(new Alumno("Amelia", "Perez", 52345638, true, EColores.Roja, 38, 5000f, r38));
            alumnos.Add(new Alumno("Milena", "Ramirez", 52345639, true, EColores.Roja, 39, 5000f, r39));
            alumnos.Add(new Alumno("Renatta", "Mendez", 52345640, true, EColores.Roja, 40, 5000f, r40));

            alumnos.Add(new Alumno("Armando", "Fernandez", 52345641, false, EColores.Verde, 41, 5000f, r41));
            alumnos.Add(new Alumno("Bastian", "Barrios", 52345642, false, EColores.Verde, 42, 5000f, r42));
            alumnos.Add(new Alumno("Ivan", "Vallejos", 52345643, false, EColores.Verde, 43, 5000f, r43));
            alumnos.Add(new Alumno("Leo", "Garciarena", 52345644, false, EColores.Verde, 44, 5000f, r44));
            alumnos.Add(new Alumno("Adrian", "Ponce", 52345645, false, EColores.Verde, 45, 5000f, r45));
            alumnos.Add(new Alumno("Lolo", "Garcia", 52345646, false, EColores.Verde, 46, 5000f, r46));
            alumnos.Add(new Alumno("Lara", "Gonzalez", 52345647, true, EColores.Verde, 47, 5000f, r47));
            alumnos.Add(new Alumno("Catalina", "Perez", 52345648, true, EColores.Verde, 48, 5000f, r48));
            alumnos.Add(new Alumno("Mora", "Ramirez", 52345649, true, EColores.Verde, 49, 5000f, r49));
            alumnos.Add(new Alumno("Mara", "Mendez", 52345650, true, EColores.Verde, 50, 5000f, r50));
        }
    }
}

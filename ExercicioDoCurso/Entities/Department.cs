﻿

namespace ExercicioDoCurso.Entities
{
    class Department
    {
        //Auto Props
        public string Name { get; set; }

        //===============================================================================================================================================
       
        //Costrutror padrão ou auto construtor
        public Department()
        {
        }

        //===============================================================================================================================================

        //Construtor com parametro
        public Department(string name)
        {
            Name = name;
        }

        //===============================================================================================================================================
    }
}
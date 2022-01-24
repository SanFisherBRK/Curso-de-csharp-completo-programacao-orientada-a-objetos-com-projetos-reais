using System;

namespace ExercicioDoCurso.Entities
{
    class HourContract
    {
        //Data do contrato
        public DateTime Date { get; set; }

        //Valor por hora
        public double ValuePerHour { get; set; }

        //Duração em horas desse contrato
        public int Hour { get; set; }

        //===============================================================================================================================================

        //Construtor padrão
        public HourContract()
        {
        }

        //===============================================================================================================================================

        //Construtor com parametros
        public HourContract(DateTime date, double valuePerhour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerhour;
            Hour = hour;
        }

        //===============================================================================================================================================

        //Metodo que calcular o valor total das horas
        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
        //===============================================================================================================================================
    }

}

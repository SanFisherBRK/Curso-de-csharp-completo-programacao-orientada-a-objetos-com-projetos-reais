using ExercicioDoCurso.Entities.Enums;
using System.Collections.Generic;


namespace ExercicioDoCurso.Entities
{
    class Worker
    {
        //Nome do trabalhador
        public string Name { get; set; }

        //===============================================================================================================================================
        
        //Nivel do trabalhador
        public WorkerLevel Level { get; set; }

        //===============================================================================================================================================

        //Salario base do funcionário
        public double BaseSalary { get; set; }

        //===============================================================================================================================================

        //Associando a class Department (Criando uma composição de objetos)
        public Department Department { get; set; }

        //===============================================================================================================================================
        //Associando a class Worker com os contratos da class HourContract atravez de lista List<>, já instanciando
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //===============================================================================================================================================

        //Criando Costrutror padrão ou auto construtor
        public Worker ()
        {

        }
        //===============================================================================================================================================

        ////Criando Costrutror com argumentos ou parametros
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        //===============================================================================================================================================

        //Adicionando um contrato recebido dentro da lista de cotrato do trabalhador
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //===============================================================================================================================================

        //Remove um contrato recebido dentro da lista de cotrato do trabalhador
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //===============================================================================================================================================

        //Calcula o ganho do trabalhador
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            //Percorre toda a lista de contratos
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        //===============================================================================================================================================
    }
}

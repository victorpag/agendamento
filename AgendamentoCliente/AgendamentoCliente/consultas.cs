using System;
using System.Collections.Generic;
using System.Text;

namespace AgendamentoCliente
{
    class consultas
    {
        private string diaMarcar;
        private string horaMarcar;
        private int clienteCode;

        public void MarcarData()
        {
            Console.WriteLine("\nDigite o código do cliente");
            int.TryParse(Console.ReadLine(), out clienteCode);
            Console.WriteLine("\nPara qual dia quer marcar?");
            diaMarcar = Console.ReadLine();
            Console.WriteLine("\nPara qual horario quer marcar?");
            horaMarcar = Console.ReadLine();
            Console.WriteLine("\nHorario Marcado com sucesso, aperte enter para sair");
            Console.ReadKey();
            Console.Clear();
        }

    }
}

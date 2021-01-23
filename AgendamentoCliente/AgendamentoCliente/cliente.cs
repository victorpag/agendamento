using System;
using System.Collections.Generic;
using System.Text;

namespace AgendamentoCliente
{
    class cliente
    {
        private int id;
        private string nome;
        private string telefone;

        private List<int> ids = new List<int>();
        private List<string> nomes = new List<string>();
        private List<string> telefones = new List<string>();

        public void CadastroCliente()
        {
            id = ids.Count == 0 ? 0 : (ids.Count);
            Console.WriteLine("\nInforme o nome do cliente");
            nome = Console.ReadLine();
            Console.WriteLine("\nInforme o telefone do cliente");
            telefone = Console.ReadLine();

            ids.Add(id);
            nomes.Add(nome);
            telefones.Add(telefone);
            Console.WriteLine("\nCliente adicionado com sucesso,aperte enter para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void RetornarCadastros()
        {
            Console.WriteLine("\nClientes cadastrados:");
            ids.ForEach(delegate (int _id)
            {
                Console.WriteLine("\nCódigo: " + _id + " Cliente: " + nomes[_id] + " Telefone: " + telefones[_id]);
            });
            Console.WriteLine("\nAperte enter para continuar");
            Console.ReadKey();
            Console.Clear();

        }

    }
}

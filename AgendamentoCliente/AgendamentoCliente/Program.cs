using System;

namespace AgendamentoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = @" _____                           _                                  _          
(  _  )                         ( )                                ( )_        
| (_) |   __     __    ___     _| |   _ _   ___ ___     __    ___  | ,_)   _   
|  _  | /'_ `\ /'__`\/' _ `\ /'_` | /'_` )/' _ ` _ `\ /'__`\/' _ `\| |   /'_`\ 
| | | |( (_) |(  ___/| ( ) |( (_| |( (_| || ( ) ( ) |(  ___/| ( ) || |_ ( (_) )
(_) (_)`\__  |`\____)(_) (_)`\__,_)`\__,_)(_) (_) (_)`\____)(_) (_)`\__)`\___/'
       ( )_) |                                                                 
        \___/'                                                                 ";

            cliente _cliente = new cliente();
            consultas _consulta = new consultas();

            bool menu = true;
            while (menu)
            {
                Console.WriteLine(title);
                Console.WriteLine("\nO que voce gostaria de fazer?");
                Console.WriteLine("1. Cadastrar novo cliente");
                Console.WriteLine("2. Consultar clientes cadastrados");
                Console.WriteLine("3. Marcar Consulta");
                string menuREs = Console.ReadLine();
                if (int.TryParse(menuREs, out int value))
                {
                    if (value == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(title);
                        _cliente.CadastroCliente();
                    }
                    else if (value == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(title);
                        _cliente.RetornarCadastros();
                    }
                    else if (value == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(title);
                        _consulta.MarcarData();                        
                    }
                    else
                    {

                    }
                }
            }
        }

    }
}

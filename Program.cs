class Program
{
    static void Main()
    {

        Tarefas tarefas = new Tarefas();
        ExibirMenu();

       void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Gerenciador de tarefas!");
            Console.WriteLine();
            Console.WriteLine("1- Exibir tarefas");
            Console.WriteLine("2- Adicionar tarefa");
            Console.WriteLine("3- Atualizar status da tarefa");
            Console.WriteLine("4- Filtrar tarefas por status");
            Console.WriteLine("5- Ordenar tarefas por prioridade");
            Console.WriteLine("Qualquer- Sair do programa");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            var escolha  = Console.ReadLine();
            if(escolha == "1")
            {
                Console.Clear();
                ExibirTodasTarefas();
            }

            else if (escolha == "2")
            {
                Console.Clear();
                AdicionarTarefas();
            } 
            
            else if (escolha == "3")
            {
                Console.Clear();
                AtualizarTarefas();
            }
            
            else if (escolha == "4")
            {
                Console.Clear();
                FiltrarTarefas();
            }

            else if (escolha == "5")
            {
                Console.Clear();
                OrdernarTarefas();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Desligando...");
            }
        }

       void AdicionarTarefas()
        {
            string prioridade = "";
            while (prioridade != "Alta" && prioridade != "Media" && prioridade != "Baixa")
            {
                bool nomeExiste = true;
                string nome = "";
                while (nomeExiste)
                {
                    Console.WriteLine("Nome da tarefa: ");
                    nome = Console.ReadLine();
                    if (tarefas.tarefas.Any(t => t.Nome == nome))
                    {
                        nomeExiste = true;
                        Console.WriteLine($"O nome {nome} já existe!");
                    }

                    else
                    {
                        nomeExiste = false;
                    }
                }
                
                Console.WriteLine("Prioridade da tarefa(Alta, Media ou Baixa): ");
                prioridade = Console.ReadLine();
                Console.WriteLine("Dia de conclusão da tarefa: ");
                string dia = Console.ReadLine();
                if (prioridade == "Alta" || prioridade == "Media" || prioridade == "Baixa")
                {
                    Tarefa tarefa = new Tarefa();
                    tarefa.Nome = nome;
                    tarefa.Prioridade = prioridade;
                    tarefa.Dia = dia;
                    tarefa.Status = "Pendente";

                    tarefas.AdicionarTarefa(tarefa);
                    Console.ReadLine();

                    ExibirMenu();
                }
                else
                {
                    Console.WriteLine("Prioridade é diferente das alternativas válidas! ");
                    Console.WriteLine("Tente novamente! ");
                }
            }            
        } 
        
       void AtualizarTarefas()
        {            
            bool nomeExiste = false;
            string nome = "";
            while (nomeExiste == false)
            {
                Console.WriteLine("Nome da tarefa para editar: ");
                nome = Console.ReadLine();
                if (tarefas.tarefas.Any(t => t.Nome == nome))
                {
                    nomeExiste = true;                    
                }

                else
                {
                    nomeExiste = false;
                    Console.WriteLine($"Não existe a tarefa com o nome {nome}!");
                }
            }

            tarefas.AtualizarTarefa(nome);
            
            Console.WriteLine("Tarefa atualizada!");
            Console.ReadLine();
            
            ExibirMenu();
        }

       void FiltrarTarefas()
        {
            string status = "";
            while (status != "1" && status != "2")
            {
                Console.WriteLine("Escolha um status: ");
                Console.WriteLine("1- Pendente ");
                Console.WriteLine("2- Concluido ");
                status = Console.ReadLine();

                if (status == "1")
                {
                    string filtro = "Pendente";
                    tarefas.FiltrarTarefas(filtro);
                }

                else if (status == "2")
                {
                    string filtro = "Concluido";
                    tarefas.FiltrarTarefas(filtro);
                }

                else
                {
                    Console.WriteLine("Faça uma escolha válida! ");
                    Console.WriteLine("Tente novamente! ");
                }
 
            }
            Console.ReadLine();
            ExibirMenu();
        }

       void OrdernarTarefas()
        {
            string ordem = "";
            while (ordem != "1" && ordem != "2")
            {
                Console.WriteLine("Escolha um status: ");
                Console.WriteLine("1- Alta para Baixa ");
                Console.WriteLine("2- Baixa para Alta ");
                ordem = Console.ReadLine();

                if (ordem == "1")
                {
                    tarefas.OrdernarTarefas(ordem);
                }

                else if (ordem == "2")
                {
                    tarefas.OrdernarTarefas(ordem);
                }

                else
                {
                    Console.WriteLine("Faça uma escolha válida! ");
                    Console.WriteLine("Tente novamente! ");
                }

            }
            Console.ReadLine();
            ExibirMenu();
        }

       void ExibirTodasTarefas()
        {
            tarefas.ExibirTarefas();
            Console.ReadLine();
            ExibirMenu();
        }
    }
}
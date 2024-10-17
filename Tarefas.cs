class Tarefas
{
    public List<Tarefa> tarefas = new List<Tarefa>();
    
    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void AtualizarTarefa(string nome)
    {
        foreach (var tarefa in tarefas)
        {
            if (tarefa.Nome == nome)
            {
                tarefa.Status = "Concluido";

            }
        }
    }
    
    public void FiltrarTarefas(string filtro)
    {
        if (tarefas.Count() == 0)
        {
            Console.WriteLine("Não foi encontrada nenhuma tarefa!");
        }

        else
        {
            foreach (var tarefa in tarefas)
            {
                if (tarefa.Status == filtro)
                {
                    Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                    Console.WriteLine();
                }
            }
        }
        
    }

    public void OrdernarTarefas(string ordem)
    {
        if (tarefas.Count() == 0)
        {
            Console.WriteLine("Não foi encontrada nenhuma tarefa!");
        }
        else
        {
            if (ordem == "1")
            {
                foreach (var tarefa in tarefas)
                {
                    if (tarefa.Prioridade == "Alta")
                    {
                        Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                        Console.WriteLine();
                    }
                }

                foreach (var tarefa in tarefas)
                {
                    if (tarefa.Prioridade == "Media")
                    {
                        Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                        Console.WriteLine();
                    }
                }

                foreach (var tarefa in tarefas)
                {
                    if (tarefa.Prioridade == "Baixa")
                    {
                        Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                        Console.WriteLine();
                    }
                }

            }

            if (ordem == "2")
            {
                foreach (var tarefa in tarefas)
                {
                    if (tarefa.Prioridade == "Baixa")
                    {
                        Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                        Console.WriteLine();
                    }
                }

                foreach (var tarefa in tarefas)
                {
                    if (tarefa.Prioridade == "Media")
                    {
                        Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                        Console.WriteLine();
                    }
                }

                foreach (var tarefa in tarefas)
                {
                    if (tarefa.Prioridade == "Alta")
                    {
                        Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }

    public void ExibirTarefas()
    {
        if (tarefas.Count() == 0)
        {
            Console.WriteLine("Não foi encontrada nenhuma tarefa!");
        }
        else
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"Nome: {tarefa.Nome}, Prioridade: {tarefa.Prioridade}, Dia: {tarefa.Dia}, Status: {tarefa.Status}");
            }
            Console.WriteLine();
        }

    }

}


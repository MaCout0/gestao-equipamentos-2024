﻿namespace GestaoEquipamentos.ConsoleApp
{
    public class Menus
    {
        

        public void MenuItens()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Itens \nDigite 1 - Inserir novo item. \nDigite 2 - Visualizar itens. \nDigite 3 - Editar item. \nDigite 4 - Excluir item. \nDigite 5 - Para sair");
        }

        public void MenuChamado()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados \nDigite 1 - Abrir novo chamado. \nDigite 2 - Visualizar chamados. \nDigite 3 - Editar chamado. \nDigite 4 - Excluir chamado. \nDigite 5 - Para sair");
        }
    }
}
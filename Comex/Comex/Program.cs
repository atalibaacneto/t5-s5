// Screen Sound
string mensagemDeBoasVindas = "\nSeja Bem-vindo(a)!";

void ExibirLogo()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝
");
    Console.WriteLine(mensagemDeBoasVindas);
}


//Produto produto = new Produto();
//produto.Nome = "DVD";
//produto.Descricao = "DVD de Música";
//produto.Preco_unitario = 39.90;
//produto.Qtde = 23;

//Console.WriteLine($"Produto: {produto.Nome}");
//Console.WriteLine($"Descrição: {produto.Descricao}");
//Console.WriteLine($"Preço Unitário: R$ {produto.Preco_unitario}");
//Console.WriteLine($"Quantidade: {produto.Qtde}");

void MenuDeOpcoes()
{
    Console.WriteLine(ExibirLogo);
    Console.WriteLine("Digite 1 para cadastrar produtos");
    Console.WriteLine("Digite 2 para listar produtos cadastrados");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            CadastrarProduto();
            break;
        case 2:
            ListarProdutos();
            break;
        case -1:

    }
}


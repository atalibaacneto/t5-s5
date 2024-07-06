// Screen Sound
string mensagemDeBoasVindas = "\nSeja Bem-vindo(a)!";
List<string> listaDeProdutos = new List<string>();
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
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para cadastrar produtos");
    Console.WriteLine("Digite 2 para listar produtos cadastrados");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            CadastrarProduto();
            break;
        case 2:
            ListarProdutos();
            break;
        case -1: Console.WriteLine("Tchau!");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

MenuDeOpcoes();

void CadastrarProduto()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nCadastro de Produtos");
    Console.WriteLine("********************");
    Console.Write("\nDigite o Produto para cadastrar: ");
    string produtoCadastrado = Console.ReadLine()!;
    listaDeProdutos.Add(produtoCadastrado);
    Console.WriteLine($"\nO produto cadastrado foi: {produtoCadastrado}");
    Thread.Sleep(2000);
    MenuDeOpcoes();
}
void ListarProdutos()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nListar Produtos Cadastrados");
    Console.WriteLine("***************************\n");
    //for (int i = 0; i < listaDeProdutos.Count; i++)
    //{
    //    Console.WriteLine($"Produto: {listaDeProdutos[i]}");
    //}
    foreach (string produto in listaDeProdutos)
    {
        Console.WriteLine($"Produto: {produto}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Thread.Sleep(2000);
    MenuDeOpcoes();
 }
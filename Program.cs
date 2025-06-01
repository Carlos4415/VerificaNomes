List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

bool VerificaNomes(List<string> nomeDosEscolhidos, string escolhido)
{
    return nomesDosEscolhidos.Contains(escolhido);
}

if (VerificaNomes(nomesDosEscolhidos, "Carlos Vilagran"))
{
    Console.WriteLine("Nome existe na lista.");
}
else
{
    Console.WriteLine("Nome não existe na lista.");
}
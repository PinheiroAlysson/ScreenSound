﻿string boasVindas = "Boas vindas ao Screen Sound";

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(boasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite '1' para registrar uma Banda");
    Console.WriteLine("Digite '2' para exibir todas as Bandas");
    Console.WriteLine("Digite '3' para avaliar uma Banda");
    Console.WriteLine("Digite '4' para exibir a média de uma Banda");
    Console.WriteLine("Digite '0' para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0: Console.WriteLine("Tchau, até a proxima! :)");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
░█▀▀█ ░█▀▀▀ ░█▀▀█ ▀█▀ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ░█▀▀▀█ 　 ░█▀▀▄ ░█▀▀▀ 　 ░█▀▀█ ─█▀▀█ ░█▄─░█ ░█▀▀▄ ─█▀▀█ ░█▀▀▀█ 
░█▄▄▀ ░█▀▀▀ ░█─▄▄ ░█─ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█──░█ 　 ░█─░█ ░█▀▀▀ 　 ░█▀▀▄ ░█▄▄█ ░█░█░█ ░█─░█ ░█▄▄█ ─▀▀▀▄▄ 
░█─░█ ░█▄▄▄ ░█▄▄█ ▄█▄ ░█▄▄▄█ ─░█── ░█─░█ ░█▄▄▄█ 　 ░█▄▄▀ ░█▄▄▄ 　 ░█▄▄█ ░█─░█ ░█──▀█ ░█▄▄▀ ░█─░█ ░█▄▄▄█");
    Console.Write("\nDigite o nome da banda que voce deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
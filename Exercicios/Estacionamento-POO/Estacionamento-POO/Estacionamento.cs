using System;
using System.Collections.Generic;

public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    // Construtor'
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    // Adicionar veículo
    public void AdicionarVeiculo()
    {
        Console.Write("Digite a placa do veículo para estacionar: ");
        string placa = Console.ReadLine().ToUpper();

        veiculos.Add(placa);
        Console.WriteLine("Veículo adicionado com sucesso!");
    }

    // Remover veículo
    public void RemoverVeiculo()
    {
        Console.Write("Digite a placa do veículo para remover: ");
        string placa = Console.ReadLine().ToUpper();

        if (veiculos.Contains(placa))
        {
            Console.Write("Digite a quantidade de horas que o veículo permaneceu: ");
            int horas = int.Parse(Console.ReadLine());

            decimal valorTotal = precoInicial + (precoPorHora * horas);
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
        }
    }

    // Listar veículos
    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string v in veiculos)
            {
                Console.WriteLine(v);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}

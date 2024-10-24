using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using APITeste;

public class Program
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task Main(string [] args)
    {
        var characters = await GetPersonagensAsync();
        foreach (var character in characters)
        {
            Console.WriteLine($"ID: {character.Id}, Name: {character.Name}, Species: {character.Species}");
        }
    }
    private static async Task<List<Personagens>> GetPersonagensAsync()
    {
        var allCharacters = new List<Personagens>();
        var paginaAtual = 1;
        var paginaFinal = 42;

        while (paginaAtual <= paginaFinal)
        {
            var url = $"https://rickandmortyapi.com/api/character?page={paginaAtual}";
            var response = await client.GetFromJsonAsync<PersonagemResponse>(url);

            if (response != null && response.Results != null)
            {
                allCharacters.AddRange(response.Results);
            }
            paginaAtual++;
        }
        return allCharacters;
    }

}
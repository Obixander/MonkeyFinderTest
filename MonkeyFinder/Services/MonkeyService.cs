﻿using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient httpClient;
    public MonkeyService()
    {
        httpClient = new HttpClient();
    }

    List<Monkey> monkeyList = new ();
    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeyList?.Count > 1)
            return monkeyList;

        var json = "https://montemagno.com/monkeys.json";
        var response = await httpClient.GetAsync(json);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            monkeyList = content;
        }
        return monkeyList;
    }
}

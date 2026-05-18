using System;
using System.Threading.Tasks;
using MyApp2.Entities;
using Newtonsoft.Json;

namespace MyApp2;

public class HttpRequests
{
    public async static Task<List<Post>> MakePostRequest(HttpClient client,  string BASE_URL, string PATH)
    {
        try
        {
            var apiAddress = new Uri($"{BASE_URL}{PATH}");
            string response = await client.GetStringAsync(apiAddress);
            return JsonConvert.DeserializeObject<List<Post>>(response) ?? [];
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"[Post] Error: {ex.Message}");
            return [];
        }
    }

    public async static Task<List<User>> MakeUserRequest(HttpClient client, string BASE_URL, string PATH)
    {
        try
        {
            string response  = await client.GetStringAsync($"{BASE_URL}{PATH}");
            return JsonConvert.DeserializeObject<List<User>>(response) ?? [];
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"[User] Error: {ex.Message}");
            return [];
        }
    }


    public static async Task Run()
    {
        const string BASE_URL = "https://jsonplaceholder0.typicode.com/";
        const string USER_PATH = "users";
        const string POST_PATH = "posts";
        HttpClient client = new();

        Task<List<Post>> t1 = MakePostRequest(client, BASE_URL, POST_PATH);
        Task<List<User>> t2 = MakeUserRequest(client, BASE_URL, USER_PATH);

        await Task.WhenAll(t1, t2);

        // System.Console.WriteLine(t1.Result);
        // System.Console.WriteLine(t2.Result);

        List<Post> posts = await t1;
        List<User> users = await t2;

        foreach (var item in posts)
        {
            Console.WriteLine($"Id: {item.Id} Title: {item.Title}");
        }

        foreach (var item in users)
        {
            Console.WriteLine($"Id: {item.Id} Name: {item.Name}");
        }

    }
    
}


using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json;

namespace MyApp2.Collections;
public static class TypesOfCollections3
{
    private static readonly Dictionary<string, int> _statusCodes = new()
    {
        {"OK", 200 },
        {"NotFound", 404},
        {"Error", 500}
    };

    // This is better Optimisez when you dont want to do write, update, delete operation just static read u want and no re assignment needed
    private static readonly FrozenDictionary<string, int> _statusCodes2 = new Dictionary<string, int>
    {
        {"OK", 200 },
        {"NotFound", 404},
        {"Error", 500}
    }.ToFrozenDictionary<string, int>();
    public static void Run()
    {

       _statusCodes.Add("Redirect", 300);
        foreach (KeyValuePair<string, int> kv in _statusCodes)
        {
            System.Console.WriteLine(kv.Key);
            System.Console.WriteLine(kv.Value);
        }

        System.Console.WriteLine(_statusCodes2["OK"]);
    }
}

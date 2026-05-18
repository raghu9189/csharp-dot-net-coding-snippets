using Newtonsoft.Json;

namespace MyApp2.Jsonify;

public class Product
{
    public string? Name {get; set;}
    public double? Price {get; set;}
    public string? Brand {get; set;}

}

public class ObjectJson
{
    public static void Run()
    {
        
        Product product1 = new()
        {
          Name = "Gemini Tea Podwer",
          Price = 55.55D,
          Brand = "Tata Homefoods"
        };

        // Serialize JSON
        string jsonData = JsonConvert.SerializeObject(product1, Formatting.Indented);
        System.Console.WriteLine(jsonData);
        // {
        // "Name": "Gemini Tea Podwer",
        // "Price": 55.55,
        // "Brand": "Tata Homefoods"
        // }


         // Deserialize JSON
        string jsonData2 = @"{
            'Name': 'Surf Excel Podwer',
            'Price': 125.55,
            'Brand': 'ITC Products Pvt. Ltd.'
            }";
        
        Product? product2 = JsonConvert.DeserializeObject<Product>(jsonData2);

        System.Console.WriteLine(product2!.Name);
    }
}

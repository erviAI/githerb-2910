public class HerbsSeeder
{
    public static List<Herb> SeedHerbs()
    {
        // Generate 10 herbs using real herb names using json format
        var herbsJson = """
                [
                    { "Id": 1, "Name": "Basil" },
                    { "Id": 2, "Name": "Rosemary" },
                    { "Id": 3, "Name": "Thyme" },
                    { "Id": 4, "Name": "Sage" },
                    { "Id": 5, "Name": "Mint" },
                    { "Id": 6, "Name": "Parsley" },
                    { "Id": 7, "Name": "Cilantro" },
                    { "Id": 8, "Name": "Dill" },
                    { "Id": 9, "Name": "Oregano" },
                    { "Id": 10, "Name": "Chives" }
                ]
                """;

        return System.Text.Json.JsonSerializer.Deserialize<List<Herb>>(herbsJson) ?? new List<Herb>();
    }
}

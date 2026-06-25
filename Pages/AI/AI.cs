using Google.GenAI;
using Microsoft.Extensions.AI;

namespace StorageAndTrade.AI;

public class AiWorker
{
    public async Task Work(string? prompt = null)
    {
        if (string.IsNullOrEmpty(prompt))
            return;

        IChatClient chatClient = new Client(apiKey: "")
            .AsIChatClient("gemini-3.1-flash-lite")
            .AsBuilder()
            .UseFunctionInvocation()
            .Build();

        ChatOptions options = new()
        {
            Temperature = 0,
            Tools = [
                AIFunctionFactory.Create(Function.ОтриматиІдПапкиНоменклатури, name: "get_category_guid", description: "Отримує Guid папки (категорії) за її назвою"),
                AIFunctionFactory.Create(Function.ОтриматиІдПакуванняОдиниціВиміру, name: "get_unit_guid", description: "Отримує Guid одиниці виміру за її назвою (з нормалізацією скорочень)"),
                AIFunctionFactory.Create(Function.СтворитиНоменклатуру, name: "create_multiple_products", description: "Зберігає список товарів")
            ]
        };

        await foreach (var update in chatClient.GetStreamingResponseAsync(prompt, options))
        {
            Console.Write(update);
        }
    }
}


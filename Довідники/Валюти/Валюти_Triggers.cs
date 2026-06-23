
/*
    Валюти_Triggers.cs
    Тригери для довідника Валюти
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Валюти_Triggers
{
    public static async Task New(Валюти_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Валюти();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Валюти(++number)).ToString("D6");
    }

    public static Task Copying(Валюти_Object ДовідникОбєкт, Валюти_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Валюти_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Валюти_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Валюти_Object ДовідникОбєкт, bool label)
    {
        if (label)
            await BeforeDelete(ДовідникОбєкт);
    }

    public static async Task BeforeDelete(Валюти_Object ДовідникОбєкт)
    {
        //Очистити регістр КурсиВалют при видаленні валюти
        string query = $@"
DELETE FROM 
	{РегістриВідомостей.КурсиВалют_Const.TABLE} AS КурсиВалют
WHERE
    КурсиВалют.{РегістриВідомостей.КурсиВалют_Const.Валюта} = @Валюта
";

        Dictionary<string, object> paramQuery = new()
        {
            { "Валюта", ДовідникОбєкт.UniqueID.UGuid }
        };

        await Config.Kernel.DataBase.ExecuteSQL(query, paramQuery);
    }
}


/*
    Валюти_Triggers.cs
    Тригери для довідника Валюти
*/

using GeneratedCode.Константи;

namespace GeneratedCode.Довідники;

class Валюти_Triggers
{
    public static Task New(Валюти_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.Валюти_Const).ToString("D6");
        return Task.CompletedTask;
    }

    public static Task Copying(Валюти_Objest ДовідникОбєкт, Валюти_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Валюти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Валюти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Валюти_Objest ДовідникОбєкт, bool label)
    {
        if (label)
            await BeforeDelete(ДовідникОбєкт);
    }

    public static async Task BeforeDelete(Валюти_Objest ДовідникОбєкт)
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

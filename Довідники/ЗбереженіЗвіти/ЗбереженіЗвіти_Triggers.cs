
/*
    ЗбереженіЗвіти_Triggers.cs
    Тригери для довідника ЗбереженіЗвіти
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Довідники;

class ЗбереженіЗвіти_Triggers
{
    public static async Task New(ЗбереженіЗвіти_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.ЗбереженіЗвіти();
        ДовідникОбєкт.Код = (await НумераціяДовідників.ЗбереженіЗвіти(++number)).ToString("D6");
        ДовідникОбєкт.Додано = DateTime.Now;
        ДовідникОбєкт.Користувач = Program.Користувач;
    }

    public static Task Copying(ЗбереженіЗвіти_Object ДовідникОбєкт, ЗбереженіЗвіти_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗбереженіЗвіти_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗбереженіЗвіти_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗбереженіЗвіти_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗбереженіЗвіти_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}

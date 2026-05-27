
/*
    ЗбереженіЗвіти_Triggers.cs
    Тригери для довідника ЗбереженіЗвіти
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Довідники;

class ЗбереженіЗвіти_Triggers
{
    public static Task New(ЗбереженіЗвіти_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.Код = (++НумераціяДовідників.ЗбереженіЗвіти_Const).ToString("D6");
        ДовідникОбєкт.Додано = DateTime.Now;
        ДовідникОбєкт.Користувач = Program.Користувач;
        return Task.CompletedTask;
    }

    public static Task Copying(ЗбереженіЗвіти_Objest ДовідникОбєкт, ЗбереженіЗвіти_Objest Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ЗбереженіЗвіти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(ЗбереженіЗвіти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ЗбереженіЗвіти_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ЗбереженіЗвіти_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}

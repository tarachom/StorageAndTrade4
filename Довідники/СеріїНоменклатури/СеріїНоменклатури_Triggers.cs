/*
    СеріїНоменклатури_Triggers.cs
    Тригери для довідника СеріїНоменклатури
*/

using AccountingSoftware;

namespace GeneratedCode.Довідники;

class СеріїНоменклатури_Triggers
{
    public static Task New(СеріїНоменклатури_Objest ДовідникОбєкт)
    {
        ДовідникОбєкт.ДатаСтворення = DateTime.Now;
        return Task.CompletedTask;
    }

    public static Task Copying(СеріїНоменклатури_Objest ДовідникОбєкт, СеріїНоменклатури_Objest Основа)
    {
        ДовідникОбєкт.Номер = Guid.NewGuid().ToString();
        ДовідникОбєкт.Коментар = "Копія - " + Основа.Номер;

        return Task.CompletedTask;
    }

    public static async Task BeforeSave(СеріїНоменклатури_Objest ДовідникОбєкт)
    {
        СеріїНоменклатури_Select select = new();
        select.QuerySelect.Where.AddRange([
            new(СеріїНоменклатури_Const.Номер, Comparison.EQ, ДовідникОбєкт.Номер),
            new("uid", Comparison.NOT, ДовідникОбєкт.UniqueID.UGuid)
        ]);
        if (await select.SelectSingle())
        {
            ДовідникОбєкт.Коментар = $"Помилка: Серійний номер [ {ДовідникОбєкт.Номер} ] вже існує в базі даних. " + ДовідникОбєкт.Коментар;
            ДовідникОбєкт.Номер = Guid.NewGuid().ToString();
        }
    }

    public static Task AfterSave(СеріїНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СеріїНоменклатури_Objest ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СеріїНоменклатури_Objest ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
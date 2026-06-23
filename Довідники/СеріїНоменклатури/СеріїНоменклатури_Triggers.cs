/*
    СеріїНоменклатури_Triggers.cs
    Тригери для довідника СеріїНоменклатури
*/

using AccountingSoftware;

namespace GeneratedCode.Довідники;

class СеріїНоменклатури_Triggers
{
    public static Task New(СеріїНоменклатури_Object ДовідникОбєкт)
    {
        ДовідникОбєкт.ДатаСтворення = DateTime.Now;
        return Task.CompletedTask;
    }

    public static Task Copying(СеріїНоменклатури_Object ДовідникОбєкт, СеріїНоменклатури_Object Основа)
    {
        ДовідникОбєкт.Номер = Guid.NewGuid().ToString();
        ДовідникОбєкт.Коментар = "Копія - " + Основа.Номер;

        return Task.CompletedTask;
    }

    public static async Task BeforeSave(СеріїНоменклатури_Object ДовідникОбєкт)
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

    public static Task AfterSave(СеріїНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(СеріїНоменклатури_Object ДовідникОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(СеріїНоменклатури_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}


/*
        Номенклатура_Triggers.cs
        Тригери
*/


using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Довідники;

static class Номенклатура_Triggers
{
    public static async Task New(Номенклатура_Object ДовідникОбєкт)
    {
        int number = await НумераціяДовідників.Номенклатура();
        ДовідникОбєкт.Код = (await НумераціяДовідників.Номенклатура(++number)).ToString("D6");
    }

    public static Task Copying(Номенклатура_Object ДовідникОбєкт, Номенклатура_Object Основа)
    {
        ДовідникОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Номенклатура_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task AfterSave(Номенклатура_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }

    public static async Task SetDeletionLabel(Номенклатура_Object ДовідникОбєкт, bool label)
    {
        // Помітка на видалення всіх характеристик елементу номенклатури у випадку label = true
        // Якщо мітка знімається, то з характеристик мітка не має зніматися
        if (label)
        {
            ХарактеристикиНоменклатури_Select select = new();
            select.QuerySelect.Where.AddRange([
                new(ХарактеристикиНоменклатури_Const.Номенклатура, Comparison.EQ, ДовідникОбєкт.UniqueID.UGuid),
                new(ХарактеристикиНоменклатури_Const.DELETION_LABEL, Comparison.NOT, true)
            ]);

            await select.Select();
            while (select.MoveNext())
                if (select.Current != null)
                    await select.Current.SetDeletionLabel();
        }
    }

    public static Task BeforeDelete(Номенклатура_Object ДовідникОбєкт)
    {
        return Task.CompletedTask;
    }
}
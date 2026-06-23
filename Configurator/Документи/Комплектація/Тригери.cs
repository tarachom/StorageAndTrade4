

/*
        Комплектація_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class Комплектація_Triggers
{
    public static async Task New(Комплектація_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.Комплектація();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.Комплектація(++number)).ToString("D8");
                    
    }

    public static Task Copying(Комплектація_Object ДокументОбєкт, Комплектація_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(Комплектація_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{Комплектація_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(Комплектація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(Комплектація_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(Комплектація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    


/*
        ПередачаОбладнанняВМонтаж_Triggers.cs
        Тригери
*/

using GeneratedCode.Константи;
using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ПередачаОбладнанняВМонтаж_Triggers
{
    public static async Task New(ПередачаОбладнанняВМонтаж_Object ДокументОбєкт)
    {
        ДокументОбєкт.ДатаДок = DateTime.Now;
        
        int number = await НумераціяДокументів.ПередачаОбладнанняВМонтаж();
        ДокументОбєкт.НомерДок = (await НумераціяДокументів.ПередачаОбладнанняВМонтаж(++number)).ToString("D8");
                    
    }

    public static Task Copying(ПередачаОбладнанняВМонтаж_Object ДокументОбєкт, ПередачаОбладнанняВМонтаж_Object Основа)
    {
        ДокументОбєкт.Назва += " - Копія";
        return Task.CompletedTask;
    }

    public static Task BeforeSave(ПередачаОбладнанняВМонтаж_Object ДокументОбєкт)
    {
        ДокументОбєкт.Назва = $"{ПередачаОбладнанняВМонтаж_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
        return Task.CompletedTask;
    }

    public static Task AfterSave(ПередачаОбладнанняВМонтаж_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }

    public static Task SetDeletionLabel(ПередачаОбладнанняВМонтаж_Object ДокументОбєкт, bool label)
    {
        return Task.CompletedTask;
    }

    public static Task BeforeDelete(ПередачаОбладнанняВМонтаж_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    
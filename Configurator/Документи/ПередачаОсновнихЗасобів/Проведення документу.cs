

/*
        ПередачаОсновнихЗасобів_SpendTheDocument.cs
        Модуль проведення документу
*/

using AccountingSoftware;
using StorageAndTrade;
using GeneratedCode;

using GeneratedCode.Довідники;
using GeneratedCode.РегістриНакопичення;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

static class ПередачаОсновнихЗасобів_SpendTheDocument
{
    public static async Task<bool> Spend(ПередачаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        try
        {
            // Проведення документу
            // ...

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static Task Clear(ПередачаОсновнихЗасобів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    
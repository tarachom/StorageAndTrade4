

/*
        ПереміщенняНематеріальнихАктивів_SpendTheDocument.cs
        Модуль проведення документу
*/

using AccountingSoftware;
using StorageAndTrade;
using GeneratedCode;

using GeneratedCode.Довідники;
using GeneratedCode.РегістриНакопичення;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

static class ПереміщенняНематеріальнихАктивів_SpendTheDocument
{
    public static async Task<bool> Spend(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт)
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

    public static Task Clear(ПереміщенняНематеріальнихАктивів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    


/*
        КоригуванняНезавершеногоВиробництва_SpendTheDocument.cs
        Модуль проведення документу
*/

using AccountingSoftware;
using StorageAndTrade;
using GeneratedCode;

using GeneratedCode.Довідники;
using GeneratedCode.РегістриНакопичення;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

static class КоригуванняНезавершеногоВиробництва_SpendTheDocument
{
    public static async Task<bool> Spend(КоригуванняНезавершеногоВиробництва_Object ДокументОбєкт)
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

    public static Task Clear(КоригуванняНезавершеногоВиробництва_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
    


/*
        АвансовийЗвіт_SpendTheDocument.cs
        Модуль проведення документу
*/

using AccountingSoftware;
using StorageAndTrade;
using GeneratedCode;

using GeneratedCode.Довідники;
using GeneratedCode.РегістриНакопичення;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

static class АвансовийЗвіт_SpendTheDocument
{
    public static async Task<bool> Spend(АвансовийЗвіт_Object ДокументОбєкт)
    {
        try
        {
            #region Бух

            await ФункціїДляДокументів.ПровестиДокументБухгалтерськаОперація(ДокументОбєкт.ДокументБухгалтерськаОперація);

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static async Task Clear(АвансовийЗвіт_Object ДокументОбєкт)
    {
        #region Бух

        await ФункціїДляДокументів.ВідмінитиПроведенняДокументуБухгалтерськаОперація(ДокументОбєкт.ДокументБухгалтерськаОперація);

        #endregion
    }
}

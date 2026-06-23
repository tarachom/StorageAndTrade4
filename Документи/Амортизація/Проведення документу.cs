

/*
        Амортизація_SpendTheDocument.cs
        Модуль проведення документу
*/

using AccountingSoftware;
using StorageAndTrade;
using GeneratedCode;

using GeneratedCode.Довідники;
using GeneratedCode.РегістриНакопичення;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

static class Амортизація_SpendTheDocument
{
    public static async Task<bool> Spend(Амортизація_Object ДокументОбєкт)
    {
        try
        {
            #region Бух

            if (!ДокументОбєкт.ДокументБухгалтерськаОперація.IsEmpty())
            {
                var БухОперація = await ДокументОбєкт.ДокументБухгалтерськаОперація.GetDocumentObject(true);
                if (БухОперація != null)
                {
                    if (!await БухОперація.SpendTheDocument(БухОперація.ДатаДок))
                        throw new Exception($"Не вдалось провести бухгалтерський документ {БухОперація.Назва}");
                }
                else
                    throw new Exception($"Не вдалось прочитати бухгалтерський документ {ДокументОбєкт.ДокументБухгалтерськаОперація}");
            }

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static async Task Clear(Амортизація_Object ДокументОбєкт)
    {
        if (!ДокументОбєкт.ДокументБухгалтерськаОперація.IsEmpty())
            await ДокументОбєкт.ДокументБухгалтерськаОперація.ClearSpendTheDocument();
    }
}

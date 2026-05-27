

/*
    Модуль проведення документу
*/

using StorageAndTrade;
using GeneratedCode.Довідники;

namespace GeneratedCode.Документи;

class ПерерахунокТоварів_SpendTheDocument
{
    public static async Task<bool> Spend(ПерерахунокТоварів_Objest ДокументОбєкт)
    {
        try
        {
            #region Підготовка

            Dictionary<int, Номенклатура_Objest> СписокНоменклатури = new Dictionary<int, Номенклатура_Objest>(); //?
            Dictionary<int, decimal> ЗалишокНоменклатури = [];
            Dictionary<int, decimal> РезервНоменклатури = [];

            foreach (ПерерахунокТоварів_Товари_TablePart.Record ТовариРядок in ДокументОбєкт.Товари_TablePart.Records)
            {
                if (ТовариРядок.Номенклатура.IsEmpty())
                    throw new Exception($"Рядок {ТовариРядок.НомерРядка}. Не заповнене поле Номенклатура");

                // if (!(ТовариРядок.Кількість > 0))
                //     throw new Exception($"Рядок {ТовариРядок.НомерРядка}. Кількість має бути більшою 0");

                СписокНоменклатури.Add(ТовариРядок.НомерРядка, (await ТовариРядок.Номенклатура.GetDirectoryObject())!);
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

    public static Task ClearSpend(ПерерахунокТоварів_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}

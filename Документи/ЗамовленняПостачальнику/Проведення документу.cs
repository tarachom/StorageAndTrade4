

/*
    Модуль проведення документу
*/

using StorageAndTrade;
using GeneratedCode.Довідники;
using GeneratedCode.РегістриНакопичення;

namespace GeneratedCode.Документи;

class ЗамовленняПостачальнику_SpendTheDocument
{
    public static async Task<bool> Spend(ЗамовленняПостачальнику_Objest ДокументОбєкт)
    {
        try
        {
            #region Підготовка

            Dictionary<int, Номенклатура_Objest> СписокНоменклатури = [];

            foreach (ЗамовленняПостачальнику_Товари_TablePart.Record ТовариРядок in ДокументОбєкт.Товари_TablePart.Records)
            {
                if (ТовариРядок.Номенклатура.IsEmpty())
                    throw new Exception($"Рядок {ТовариРядок.НомерРядка}. Не заповнене поле Номенклатура");

                if (!(ТовариРядок.КількістьУпаковок > 0))
                    throw new Exception($"Рядок {ТовариРядок.НомерРядка}. Коєфіціент має бути 1 або більше");

                if (!(ТовариРядок.Кількість > 0))
                    throw new Exception($"Рядок {ТовариРядок.НомерРядка}. Кількість має бути більшою 0");

                СписокНоменклатури.Add(ТовариРядок.НомерРядка, (await ТовариРядок.Номенклатура.GetDirectoryObject())!);
            }

            #endregion

            #region Замовлення постачальникам

            ЗамовленняПостачальникам_RecordsSet замовленняПостачальникам_RecordsSet = new();

            foreach (ЗамовленняПостачальнику_Товари_TablePart.Record ТовариРядок in ДокументОбєкт.Товари_TablePart.Records)
            {
                if (СписокНоменклатури[ТовариРядок.НомерРядка].ТипНоменклатури == Перелічення.ТипиНоменклатури.Товар)
                {
                    ЗамовленняПостачальникам_RecordsSet.Record record = new()
                    {
                        Income = true,
                        OwnerLineNum = ТовариРядок.НомерРядка,

                        ЗамовленняПостачальнику = ДокументОбєкт.GetDocumentPointer(),
                        Номенклатура = ТовариРядок.Номенклатура,
                        ХарактеристикаНоменклатури = ТовариРядок.ХарактеристикаНоменклатури,
                        Склад = ДокументОбєкт.Склад,
                        Замовлено = ТовариРядок.Кількість * ТовариРядок.КількістьУпаковок
                    };

                    замовленняПостачальникам_RecordsSet.Records.Add(record);
                }
            }

            await замовленняПостачальникам_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static Task ClearSpend(ЗамовленняПостачальнику_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}
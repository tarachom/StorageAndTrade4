

/*
    Модуль проведення документу
*/

using StorageAndTrade;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

class ВстановленняЦінНоменклатури_SpendTheDocument
{
    public static async Task<bool> Spend(ВстановленняЦінНоменклатури_Objest ДокументОбєкт)
    {
        try
        {
            #region Рух по регістрах

            ЦіниНоменклатури_RecordsSet ціниНоменклатури_RecordsSet = new();

            foreach (ВстановленняЦінНоменклатури_Товари_TablePart.Record Товари_Record in ДокументОбєкт.Товари_TablePart.Records)
            {
                if (Товари_Record.Ціна > 0)
                {
                    ЦіниНоменклатури_RecordsSet.Record record = new()
                    {
                        Номенклатура = Товари_Record.Номенклатура,
                        ХарактеристикаНоменклатури = Товари_Record.ХарактеристикаНоменклатури,
                        ВидЦіни = Товари_Record.ВидЦіни,
                        Ціна = Товари_Record.Ціна,
                        Пакування = Товари_Record.Пакування,
                        Валюта = ДокументОбєкт.Валюта
                    };

                    ціниНоменклатури_RecordsSet.Records.Add(record);
                }
            }

            await ціниНоменклатури_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static async Task ClearSpend(ВстановленняЦінНоменклатури_Objest ДокументОбєкт)
    {
        //Очистка
        await new ЦіниНоменклатури_RecordsSet().Delete(ДокументОбєкт.UniqueID.UGuid);
    }
}
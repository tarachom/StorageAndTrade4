

/*
    Модуль проведення документу
*/

using StorageAndTrade;
using GeneratedCode.РегістриВідомостей;

namespace GeneratedCode.Документи;

class РозміщенняНоменклатуриПоКоміркам_SpendTheDocument
{
    public static async Task<bool> Spend(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт)
    {
        try
        {
            #region Рух по регістрах

            РозміщенняНоменклатуриПоКоміркамНаСкладі_RecordsSet розміщенняНоменклатуриПоКоміркамНаСкладі_RecordsSet = new();

            foreach (РозміщенняНоменклатуриПоКоміркам_Товари_TablePart.Record Товари_Record in ДокументОбєкт.Товари_TablePart.Records)
            {
                РозміщенняНоменклатуриПоКоміркамНаСкладі_RecordsSet.Record record = new()
                {
                    Номенклатура = Товари_Record.Номенклатура,
                    //Склад = Товари_Record.Склад,
                    //Приміщення = Товари_Record.Приміщення,
                    Комірка = Товари_Record.Комірка,
                };

                розміщенняНоменклатуриПоКоміркамНаСкладі_RecordsSet.Records.Add(record);
            }

            await розміщенняНоменклатуриПоКоміркамНаСкладі_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static async Task ClearSpend(РозміщенняНоменклатуриПоКоміркам_Objest ДокументОбєкт)
    {
        //Очистка
        await new РозміщенняНоменклатуриПоКоміркамНаСкладі_RecordsSet().Delete(ДокументОбєкт.UniqueID.UGuid);
    }
}
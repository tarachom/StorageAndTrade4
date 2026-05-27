

/*
    Модуль проведення документу
*/

using StorageAndTrade;
using GeneratedCode.РегістриНакопичення;

namespace GeneratedCode.Документи;

class КорегуванняБоргу_SpendTheDocument
{
    public static async Task<bool> Spend(КорегуванняБоргу_Objest ДокументОбєкт)
    {
        try
        {
            #region РозрахункиЗКлієнтами та РозрахункиЗПостачальниками

            РозрахункиЗКлієнтами_RecordsSet розрахункиЗКлієнтами_RecordsSet = new();
            РозрахункиЗПостачальниками_RecordsSet розрахункиЗПостачальниками_RecordsSet = new();

            foreach (КорегуванняБоргу_РозрахункиЗКонтрагентами_TablePart.Record РозрахункиЗКонтрагентами_Record in ДокументОбєкт.РозрахункиЗКонтрагентами_TablePart.Records)
            {
                if (РозрахункиЗКонтрагентами_Record.ТипКонтрагента == Перелічення.ТипиКонтрагентів.Клієнт)
                {
                    РозрахункиЗКлієнтами_RecordsSet.Record record_Клієнт = new()
                    {
                        Income = false,
                        OwnerLineNum = РозрахункиЗКонтрагентами_Record.НомерРядка,

                        Контрагент = РозрахункиЗКонтрагентами_Record.Контрагент,
                        Валюта = РозрахункиЗКонтрагентами_Record.Валюта,
                        Сума = РозрахункиЗКонтрагентами_Record.Сума
                    };

                    розрахункиЗКлієнтами_RecordsSet.Records.Add(record_Клієнт);
                }

                if (РозрахункиЗКонтрагентами_Record.ТипКонтрагента == Перелічення.ТипиКонтрагентів.Постачальник)
                {
                    РозрахункиЗПостачальниками_RecordsSet.Record record_Постачальник = new()
                    {
                        Income = true,
                        OwnerLineNum = РозрахункиЗКонтрагентами_Record.НомерРядка,

                        Контрагент = РозрахункиЗКонтрагентами_Record.Контрагент,
                        Валюта = РозрахункиЗКонтрагентами_Record.Валюта,
                        Сума = РозрахункиЗКонтрагентами_Record.Сума,
                    };

                    розрахункиЗПостачальниками_RecordsSet.Records.Add(record_Постачальник);
                }
            }

            await розрахункиЗКлієнтами_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());
            await розрахункиЗПостачальниками_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static Task ClearSpend(КорегуванняБоргу_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}

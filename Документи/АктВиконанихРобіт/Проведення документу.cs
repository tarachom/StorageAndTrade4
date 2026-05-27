

/*
    Модуль проведення документу
*/

using GeneratedCode.РегістриНакопичення;

namespace GeneratedCode.Документи;

static class АктВиконанихРобіт_SpendTheDocument
{
    public static async Task<bool> Spend(АктВиконанихРобіт_Objest ДокументОбєкт)
    {
        try
        {
            #region Підготовка

            foreach (АктВиконанихРобіт_Послуги_TablePart.Record ПослугиРядок in ДокументОбєкт.Послуги_TablePart.Records)
            {
                if (ПослугиРядок.Номенклатура.IsEmpty())
                    throw new Exception($"Рядок {ПослугиРядок.НомерРядка}. Не заповнене поле Номенклатура");

                if (!(ПослугиРядок.Кількість > 0))
                    throw new Exception($"Рядок {ПослугиРядок.НомерРядка}. Кількість має бути більшою 0");
            }

            #endregion

            #region РозрахункиЗКлієнтами

            РозрахункиЗКлієнтами_RecordsSet розрахункиЗКлієнтами_RecordsSet = new();
            РозрахункиЗКлієнтами_RecordsSet.Record розрахункиЗКлієнтами_Record = new()
            {
                Income = true,

                Контрагент = ДокументОбєкт.Контрагент,
                Валюта = ДокументОбєкт.Валюта,
                Сума = ДокументОбєкт.СумаДокументу,

            };

            розрахункиЗКлієнтами_RecordsSet.Records.Add(розрахункиЗКлієнтами_Record);
            await розрахункиЗКлієнтами_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());

            #endregion

            #region Продажі

            Продажі_RecordsSet продажі_RecordsSet = new();
            foreach (АктВиконанихРобіт_Послуги_TablePart.Record ТовариРядок in ДокументОбєкт.Послуги_TablePart.Records)
            {
                Продажі_RecordsSet.Record record = new()
                {
                    OwnerLineNum = ТовариРядок.НомерРядка,

                    Організація = ДокументОбєкт.Організація,
                    Контрагент = ДокументОбєкт.Контрагент,
                    Договір = ДокументОбєкт.Договір,
                    Номенклатура = ТовариРядок.Номенклатура,
                    ХарактеристикаНоменклатури = ТовариРядок.ХарактеристикаНоменклатури,
                    Кількість = ТовариРядок.Кількість,
                    Сума = ТовариРядок.Сума,
                    Дохід = ТовариРядок.Сума
                };

                продажі_RecordsSet.Records.Add(record);
            }
            await продажі_RecordsSet.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static Task ClearSpend(АктВиконанихРобіт_Objest ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}

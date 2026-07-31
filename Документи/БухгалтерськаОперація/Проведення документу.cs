

/*
    Модуль проведення документу
*/

using StorageAndTrade;
using GeneratedCode.РегістриНакопичення;

namespace GeneratedCode.Документи;

static class БухгалтерськаОперація_SpendTheDocument
{
    public static async Task<bool> Spend(БухгалтерськаОперація_Object ДокументОбєкт)
    {
        try
        {
            //Операції
            {
                БухгалтерськіОперації_RecordsSet БухгалтерськіОперації = new();

                foreach (var record in ДокументОбєкт.Операції_TablePart.Records)
                {
                    БухгалтерськіОперації.Records.Add(new()
                    {
                        OwnerLineNum = record.НомерРядка,

                        //Виміри
                        Рахунок = record.Рахунок,
                        ВидПроводки = record.ВидПроводки,
                        Аналітика1 = record.Аналітика1,
                        Аналітика2 = record.Аналітика2,
                        Аналітика3 = record.Аналітика3,
                        Валюта = record.Валюта,
                        КореспондуючийРахунок = record.КореспондуючийРахунок,
                        КорАналітика1 = record.КорАналітика1,
                        КорАналітика2 = record.КорАналітика2,
                        КорАналітика3 = record.КорАналітика3,
                        Податок = record.Податок,
                        Журнал = record.Журнал,
                        ТипБухОперації = record.ТипБухОперації,

                        //Ресурси
                        Сума = record.Сума,
                        Кількість = record.Кількість,
                        СумаВВалюті = record.СумаВВалюті,
                        СумаПО = record.СумаПО,
                        СумаПодатку = record.СумаПодатку,
                        КурсВалюти = record.КурсВалюти,

                        //Поля
                        Коментар = record.Коментар,
                        Автор = ДокументОбєкт.Автор,
                        Організація = ДокументОбєкт.Організація
                    });
                }

                await БухгалтерськіОперації.Save(ДокументОбєкт.ДатаДок, ДокументОбєкт.GetBasis());
            }

            return true;
        }
        catch (Exception ex)
        {
            await ПроведенняДокументів.ДокументНеПроводиться(ДокументОбєкт, ДокументОбєкт.Назва, ex.Message);
            return false;
        }
    }

    public static Task Clear(БухгалтерськаОперація_Object ДокументОбєкт)
    {
        return Task.CompletedTask;
    }
}

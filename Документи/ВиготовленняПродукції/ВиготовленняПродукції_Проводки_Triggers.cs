

/*
        ВиготовленняПродукції_Проводки_Triggers.cs
        Тригери табличної частини Проводки
*/

using AccountingSoftware;

namespace GeneratedCode.Документи;

static class ВиготовленняПродукції_Проводки_Triggers
{
    public static Task BeforeSave(ВиготовленняПродукції_Object ДокументОбєкт, ВиготовленняПродукції_Проводки_TablePart ТабличнаЧастина)
    {
        return Task.CompletedTask;
    }

    public static async Task AfterSave(ВиготовленняПродукції_Object ДокументОбєкт, ВиготовленняПродукції_Проводки_TablePart ТабличнаЧастина)
    {
        if (!ДокументОбєкт.ДокументБухгалтерськаОперація.IsEmpty())
        {
            var БухОперація = await ДокументОбєкт.ДокументБухгалтерськаОперація.GetDocumentObject();
            if (БухОперація != null)
            {
                foreach (var record in ТабличнаЧастина.Records)
                    БухОперація.Операції_TablePart.Records.Add(new()
                    {
                        Рахунок = record.Рахунок,
                        ВидПроводки = record.ВидПроводки,
                        Аналітика1 = record.Аналітика1,
                        Аналітика2 = record.Аналітика2,
                        Аналітика3 = record.Аналітика3,
                        Сума = record.Сума,
                        Кількість = record.Кількість,
                        Податок = record.Податки,
                        КореспондуючийРахунок = record.КореспондуючийРахунок,
                        КорАналітика1 = record.КорАналітика1,
                        КорАналітика2 = record.КорАналітика2,
                        КорАналітика3 = record.КорАналітика3,
                        Валюта = ДокументОбєкт.Валюта
                    });

                await БухОперація.Операції_TablePart.Save(true);
            }
        }
    }
}

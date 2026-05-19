
/*
    
*/

using NPOI.SS.UserModel;

namespace StorageAndTrade;

static class ФункціїДляЕксель
{
    /// <summary>
    /// Обчислення максимального значення рядка в якому є значення без розриву і пропусків
    /// </summary>
    /// <param name="sheet">Лист</param>
    /// <param name="startDataRow">Початок даних</param>
    /// <param name="column">Номер колонки по якій відбувається аналіз</param>
    /// <returns>Кількість рядків в листі</returns>
    public static int ОбчислитиКількістьРядків(ISheet sheet, int startDataRow, int column)
    {
        int maxRow = startDataRow;

        int counter = 0;
        const int maxCounter = 1_000_000; //Максимальна кількість можливих рядків, щоб не було зациклення

        while (counter < maxCounter)
        {
            IRow row = sheet.GetRow(maxRow);
            if (row == null) break;

            ICell cell = row.GetCell(column);
            if (string.IsNullOrEmpty(cell?.ToString()?.Trim())) break;

            maxRow++;
            counter++;
        }

        return maxRow;
    }
}
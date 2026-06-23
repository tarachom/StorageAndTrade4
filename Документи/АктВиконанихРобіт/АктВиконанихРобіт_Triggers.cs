
/*
    АктВиконанихРобіт_Triggers.cs
    Тригери для документу АктВиконанихРобіт
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class АктВиконанихРобіт_Triggers
{
   public static async Task New(АктВиконанихРобіт_Object ДокументОбєкт)
   {
      int number = await НумераціяДокументів.АктВиконанихРобіт();
      await НумераціяДокументів.АктВиконанихРобіт(++number);

      ДокументОбєкт.НомерДок = number.ToString("D8");
      ДокументОбєкт.ДатаДок = DateTime.Now;
      ДокументОбєкт.Автор = Program.Користувач;
      ДокументОбєкт.Менеджер = Program.Користувач;
   }

   public static Task Copying(АктВиконанихРобіт_Object ДокументОбєкт, АктВиконанихРобіт_Object Основа)
   {
      ДокументОбєкт.Назва += " - Копія";
      ДокументОбєкт.ДокументБухгалтерськаОперація = new();
      return Task.CompletedTask;
   }

   public static async Task BeforeSave(АктВиконанихРобіт_Object ДокументОбєкт)
   {
      ДокументОбєкт.Назва = $"{АктВиконанихРобіт_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";

      if (ДокументОбєкт.ВідобразитиВБухгалтерськомуОбліку)
         ДокументОбєкт.ДокументБухгалтерськаОперація =
             await ФункціїДляДокументів.СтворитиДокументБухгалтерськаОперація(ДокументОбєкт.ДокументБухгалтерськаОперація, new()
             {
                ДатаДок = ДокументОбєкт.ДатаДок,
                Організація = ДокументОбєкт.Організація,
                Основа = ДокументОбєкт.GetBasis()
             });
      else if (!ДокументОбєкт.ДокументБухгалтерськаОперація.IsEmpty())
      {
         await ДокументОбєкт.ДокументБухгалтерськаОперація.SetDeletionLabel(true);
         ДокументОбєкт.ДокументБухгалтерськаОперація = new();
      }
   }

   public static Task AfterSave(АктВиконанихРобіт_Object ДокументОбєкт)
   {
      return Task.CompletedTask;
   }

   public static Task SetDeletionLabel(АктВиконанихРобіт_Object ДокументОбєкт, bool label)
   {
      return Task.CompletedTask;
   }

   public static Task BeforeDelete(АктВиконанихРобіт_Object ДокументОбєкт)
   {
      return Task.CompletedTask;
   }
}

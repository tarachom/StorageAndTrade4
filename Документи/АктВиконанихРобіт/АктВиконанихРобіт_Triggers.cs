
/*
    АктВиконанихРобіт_Triggers.cs
    Тригери для документу АктВиконанихРобіт
*/

using GeneratedCode.Константи;
using StorageAndTrade;

namespace GeneratedCode.Документи;

class АктВиконанихРобіт_Triggers
{
   public static Task New(АктВиконанихРобіт_Objest ДокументОбєкт)
   {
      ДокументОбєкт.НомерДок = (++НумераціяДокументів.АктВиконанихРобіт_Const).ToString("D8");
      ДокументОбєкт.ДатаДок = DateTime.Now;
      ДокументОбєкт.Автор = Program.Користувач;
      ДокументОбєкт.Менеджер = Program.Користувач;

      return Task.CompletedTask;
   }

   public static Task Copying(АктВиконанихРобіт_Objest ДокументОбєкт, АктВиконанихРобіт_Objest Основа)
   {
      ДокументОбєкт.Назва += " - Копія";
      return Task.CompletedTask;
   }

   public static Task BeforeSave(АктВиконанихРобіт_Objest ДокументОбєкт)
   {
      ДокументОбєкт.Назва = $"{АктВиконанихРобіт_Const.FULLNAME} №{ДокументОбєкт.НомерДок} від {ДокументОбєкт.ДатаДок.ToString("dd.MM.yyyy")}";
      return Task.CompletedTask;
   }

   public static Task AfterSave(АктВиконанихРобіт_Objest ДокументОбєкт)
   {
      return Task.CompletedTask;
   }

   public static Task SetDeletionLabel(АктВиконанихРобіт_Objest ДокументОбєкт, bool label)
   {
      return Task.CompletedTask;
   }

   public static Task BeforeDelete(АктВиконанихРобіт_Objest ДокументОбєкт)
   {
      return Task.CompletedTask;
   }
}

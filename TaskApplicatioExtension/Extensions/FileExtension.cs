using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskApplicatioLinq.Enums;

// 3.Создать перечисление содержащая кода файлов PDF = 1, TXT = 2 и тд. Написать метод
// расширения, который в зависимости от значения перечисления будет возвращать
// результат следующего вида: “Выбран файл с расширением *.pdf”, если такого значения нет
// в перечислении бросать ошибку с сообщением “Неверный формат файла”

// 4. Написать метод расширения возвращающий имя файла из пути.
// “С:/ text / text / file - name.pdf” -> “file - name” 

namespace TaskApplicatioLinq.Extensions
{
    public static class FileExtension
    {
        public static string FileTypeMessage(this FileTypes x)
        {
            if (Enum.IsDefined(x))
            {
                return $"Выбран файл с расширением *{x}";
            }
            throw new Exception("нет такого формата");
        }
        public static string FileNameInExplorer(this string routefile)
        {
            if (string.IsNullOrEmpty(routefile)) return null;
            string[] route = routefile.Split("/");
            string[] fileType = route[route.Length - 1].Split(".");
            object format = fileType[fileType.Length - 1].Remove(0);
            if (Enum.IsDefined(typeof(FileTypes), format))
            {

                return $"{route[route.Length - 1]}";
            }
            throw new Exception("нет такого формата");
        }
    }
}

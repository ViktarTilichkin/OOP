using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string FileNameInExplorer(this FileTypes routefile)
        {
            if (Enum.IsDefined(routefile))
            {

                return $"имя файла";
            }
            throw new Exception("нет такого формата");
        }
    }
}

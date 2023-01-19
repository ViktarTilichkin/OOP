namespace Abstract;
using System.Text.RegularExpressions;
// Реализовать класс Validation который содержит методы IsValidId, IsValidEmail,
// IsValidPwd.
// Реализовать класс наследник Data который полностью переопределяет все
// методы своего суперкласса.
// Ваша задача написать функционал для всех трёх методов.
// Где, основная задача первого метода проверить является ли входное значение
// принимаемые в параметры функции числом.
// Основная задача второго метода проверить является ли входная строка почтой:
// то есть содержит ли знак «@» а также оканчивается ли на .by, .com
// Говоря о последнем методе то он принимает две строки: пароль и
// подтверждения пароля. Необходимо проверить совпадают ли данный пароли.
// Результат каждой из функций должен возвращать true или false в зависимости от
// условий

public class Data : Validation
{
    public override bool IsValidId(object input)
    {
        if (input is int)
        {
            return true;
        }
        return false;
    }
    public override bool IsValidEmail(string input)
    {
        string pattern = @"(\b[a-z,A-Z,0-9]\w+\@+[a-z,A-Z,0-9]\w+\.+[a-z,A-Z]\w)";
        if (Regex.IsMatch(input, pattern))
        {
            return true;
        }
        return false;
    }
    public override bool IsValidPwd(string input)
    {
        string pattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])";
        if (Regex.IsMatch(input, pattern))
        {
            return true;
        }
        return false;
    }
}
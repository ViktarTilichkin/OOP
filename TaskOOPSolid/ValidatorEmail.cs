// 2. Реализуйте класс ValidatorEmail. Класс содержит 1 метод валидации, называемый
// Middleware, в котором происходит проверка на почту. Вывести true, если провека
// успешна
namespace ValidatorEmail;

public class ValEmail
{
    public bool ValidEmail(string text)
    {
        text.Trim();
        string[] result = text.Split("@");
        if (result.Length == 2)
        {
            string[] result1 = result[1].Split(".");
            if (result1.Length == 2 && result1[1] != string.Empty)
            {
                return true;
            }
        }
        return false;

    }
}
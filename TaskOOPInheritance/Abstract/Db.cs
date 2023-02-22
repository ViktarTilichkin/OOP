namespace Abstract.Db;
// 3. Существует родительский класс Db. Класс содержит в себе поле из массива
// пользовательских данных включающий: имя, фамилия, почту, пароль. Также
// существует дочерний класс Server. Дочерний класс наследует поле массива из
// своего родительского класса. Реализовать метод в классе Server CreateUser,
// принимающий в параметрах: имя и фамилию, почту, пароль и добавляющий в
// конец массива Db переданные данные

public class Db : User
{

    public Db()
    {

    }
    public Db(int id, string name, string surName, string pwd)
    {
        UserId = id;
        Name = name;
        Surname = surName;
        Pwd = pwd;
    }

}
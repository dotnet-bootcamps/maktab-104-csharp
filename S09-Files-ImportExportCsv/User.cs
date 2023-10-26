namespace S08_Files_ImportExportCsv;

public class User
{ public User()
    {
        _id = _userId;
        _userId++;
    }


    #region Fields
    public string _name;
    public string _lastName;
    public int _age;
    public int _id;
    public DateTime _registerTime;
    #endregion

    public static int _userId = 1;
    

}
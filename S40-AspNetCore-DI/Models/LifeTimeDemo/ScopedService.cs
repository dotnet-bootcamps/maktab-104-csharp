namespace S40_AspNetCore_DI.Models.LifeTimeDemo;

public class ScopedService : IScopedService
{
    private string _id;
    public string GetId()
    {
        if (string.IsNullOrEmpty(_id))
            _id = Guid.NewGuid().ToString();

        return _id;
    }
}
public class user1
{
    public string email { get; set; }
    public string password { get; set; }
    public bool isLoggedIn { get; set; } = false;

    public void SetUser(string e, string p)
    {
        email = e;
        password = p;
        isLoggedIn = true;
    }

    public void Clear()
    {
        email = string.Empty;
        password = string.Empty;
        isLoggedIn = false;
    }
}
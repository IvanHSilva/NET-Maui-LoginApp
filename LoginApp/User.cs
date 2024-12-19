namespace LoginApp; 

public class User {

    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public User() {}

    public User(string name, string password) {
        Name = name;
        Password = password;
    }
}

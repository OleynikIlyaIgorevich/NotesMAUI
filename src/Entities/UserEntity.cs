using NotesMAUI.Entities.Base;

namespace NotesMAUI.Entities;

public class UserEntity : BaseEntity
{
    public string SecondName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }

    public List<NoteEntity> Notes { get; set; } = [];

    public UserEntity(
        string secondName,
        string firstName,
        string middleName,
        string username,
        string password)
    {
        SecondName = secondName;
        FirstName = firstName;
        MiddleName = middleName;
        Username = username;
        Password = password;
    }

    public UserEntity() {  }
}

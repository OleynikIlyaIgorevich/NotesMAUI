using NotesMAUI.Entities.Base;

namespace NotesMAUI.Entities;

public class NoteEntity : BaseEntity
{
    public int UserId { get; set; }
    public int CategoryId { get; set; }

    public string Title { get; set; }
    public string Content { get; set; }

    public UserEntity User { get; set; }
    public CategoryEntity Category { get; set; }

    public NoteEntity(
        int userId,
        string title,
        string content)
    {
        UserId = userId;
        Title = title;
        Content = content;
    }

    public NoteEntity() { }

}

using NotesMAUI.Entities.Base;

namespace NotesMAUI.Entities;

public class CategoryEntity : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }


    public List<NoteEntity> Notes { get; set; } = [];

    public CategoryEntity(
        string title,
        string description)
    {
        Title = title;
        Description = description;
    }

    public CategoryEntity() { }

}

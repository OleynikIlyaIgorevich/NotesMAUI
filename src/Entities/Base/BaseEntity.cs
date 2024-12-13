namespace NotesMAUI.Entities.Base;

public abstract class BaseEntity
{
    public int Id { get; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    protected BaseEntity()
    {
        CreatedAt = DateTime.Now;
    }

}

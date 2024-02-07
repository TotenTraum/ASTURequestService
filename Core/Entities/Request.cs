namespace Core.Entities;

public class Request
{
    public Guid Id { get; set; }
    
    public Guid TemplateId { get; set; }

    /// TODO ПОЛЯ В ФОРМЕ JSON
    
    /// <summary>
    /// Дата подачи заявки
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Пользователь, который подал заявление
    /// </summary>
    public Guid UserId { get; set; }
}
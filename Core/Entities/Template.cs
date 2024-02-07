namespace Core.Entities;

public class Template
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public List<Requirement> Requirements { get; set; }

    /// <summary>
    /// Отдел, который обработает заявку
    /// </summary>
    public Guid DepartmentId { get; set; }
}
namespace Core.Entities;

public class Requirement
{
    public Guid Id { get; set; }

    public Guid TemplateId { get; set; }

    public Guid RequirementTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsMandatory { get; set; }
}
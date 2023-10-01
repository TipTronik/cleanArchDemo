using Common.BaseEntity;
using Demo.Entities.DemoContext.Enums;

namespace Demo.Entities.DemoContext.Entites;

/// <summary>
/// ДОМЕННАЯ СУЩНОСТЬ
/// </summary>
public class Car : IEntity<string>
{
    public string Id { get; set; }
    
    public EngineType EngineType { get; set; }
    
    public string Number { get; set; }

    public async Task Move()
    {
        //do something
    }
}
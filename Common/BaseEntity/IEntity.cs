using System.ComponentModel.DataAnnotations;

namespace Common.BaseEntity;

/// <summary>
/// БАЗОВАЯ СУЩНОСТЬ
/// </summary>
/// <typeparam name="T">ТИП КЛЮЧА</typeparam>
public interface IEntity<T>
{
    [Key]
    T Id { get; set; }
}
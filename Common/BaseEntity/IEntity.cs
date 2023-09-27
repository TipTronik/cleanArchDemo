using System.ComponentModel.DataAnnotations;

namespace Common.BaseEntity;

public interface IEntity<T>
{
    [Key]
    T Id { get; set; }
}
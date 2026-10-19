using Stride.Engine;

namespace AngelEngine;

/// <summary>
/// Fachada inicial para entidades. Internamente usa Entity do Stride.
/// A API pode evoluir sem obrigar os jogos Angel a conhecer todos os detalhes
/// do runtime subjacente.
/// </summary>
public sealed class AngelEntity
{
    public AngelEntity(string name)
    {
        Name = string.IsNullOrWhiteSpace(name)
            ? throw new ArgumentException("A entidade precisa de um nome.", nameof(name))
            : name;
        RuntimeEntity = new Entity(name);
    }

    public string Name { get; }

    /// <summary>Entidade do runtime Stride associada a esta entidade Angel.</summary>
    public Entity RuntimeEntity { get; }

    public AngelEntity Add(Component component)
    {
        ArgumentNullException.ThrowIfNull(component);
        RuntimeEntity.Add(component);
        return this;
    }
}

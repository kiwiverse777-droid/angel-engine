using Stride.Engine;

namespace AngelEngine;

/// <summary>
/// Ponto de entrada da camada de cena da Angel Engine.
/// Cada cena Angel é um script Stride, para aproveitar o runtime 3D existente
/// sem esconder que ele é uma dependência de terceiros.
/// </summary>
public abstract class AngelScene : SyncScript
{
    /// <summary>Nome legível da cena atual.</summary>
    public virtual string SceneName => GetType().Name;

    /// <summary>Executado uma vez quando a cena começa.</summary>
    public override void Start()
    {
        OnAngelStart();
    }

    /// <summary>Atualização de alto nível chamada a cada frame.</summary>
    public sealed override void Update()
    {
        OnAngelUpdate(Game.UpdateTime.Elapsed.TotalSeconds);
    }

    protected virtual void OnAngelStart() { }

    protected virtual void OnAngelUpdate(double deltaSeconds) { }
}

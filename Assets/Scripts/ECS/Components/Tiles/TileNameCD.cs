using Unity.Collections;
using Unity.Entities;

/// <summary>
/// Le nom à afficher pour cette case
/// </summary>
public struct TileNameCD : ISharedComponentData
{
    /// <summary>
    /// Le nom à afficher pour cette case
    /// </summary>
    public FixedString128Bytes Value;
}

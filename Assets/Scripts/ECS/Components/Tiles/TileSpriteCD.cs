using Unity.Entities;
using UnityEngine;

/// <summary>
/// Le sprite à afficher pour cette case
/// </summary>
public struct TileSpriteCD : ISharedComponentData
{
    /// <summary>
    /// Le sprite à afficher pour cette case
    /// </summary>
    public UnityObjectRef<Sprite> Value;
}

using Unity.Entities;
using Unity.Mathematics;

namespace Assets.Scripts.ECS.Components.Tiles
{
    /// <summary>
    /// La position de la case sur la carte
    /// </summary>
    public struct TilePositionCD : IComponentData
    {
        /// <summary>
        /// La position de la case sur la carte
        /// </summary>
        public int2 Value;
    }
}
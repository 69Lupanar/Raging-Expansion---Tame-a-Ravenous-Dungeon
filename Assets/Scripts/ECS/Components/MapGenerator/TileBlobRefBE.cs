using Assets.Scripts.ECS.Blobs;
using Unity.Entities;

namespace Assets.Scripts.ECS.Components.MapGenerator
{
    /// <summary>
    /// Le blob associé à cette case
    /// </summary>
    public struct TileBlobRefBE : IBufferElementData
    {
        /// <summary>
        /// Le blob associé à cette case
        /// </summary>
        public BlobAssetReference<TileBlob> Value;
    }
}
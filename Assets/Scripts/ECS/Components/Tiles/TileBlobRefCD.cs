using Assets.Scripts.ECS.Blobs;
using Unity.Entities;

namespace Assets.Scripts.ECS.Components.Tiles
{
    /// <summary>
    /// Le blob associé à cette case
    /// </summary>
    public struct TileBlobRefCD : ISharedComponentData
    {
        /// <summary>
        /// Le blob associé à cette case
        /// </summary>
        public BlobAssetReference<TileBlob> Value;
    }
}
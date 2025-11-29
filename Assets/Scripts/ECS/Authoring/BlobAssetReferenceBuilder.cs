using Assets.Scripts.ECS.Blobs;
using Assets.Scripts.Models.SOs;
using Unity.Collections;
using Unity.Entities;

namespace Assets.Scripts.ECS.Authoring
{
    /// <summary>
    /// Constructeur de BlobAssets
    /// </summary>
    internal struct BlobAssetReferenceBuilder
    {
        /// <summary>
        /// Crée un blobAsset répliquant les données de la source
        /// </summary>
        /// <param name="builder">Le BlobBuilder</param>
        /// <param name="source">La source</param>
        /// <returns>Une référence au BlobAsset créé</returns>
        internal static BlobAssetReference<MapSettingsBlob> CreateMapSettingsBlob(ref BlobBuilder builder, MapSettingsSO source)
        {
            // Construct the root object for the blob asset. Notice the use of `ref`.
            ref MapSettingsBlob mapSettings = ref builder.ConstructRoot<MapSettingsBlob>();

            mapSettings.MinMaxDimensions = source.MinMaxDimensions;

            // Now copy the data from the builder into its final place, which will
            // use the persistent allocator
            BlobAssetReference<MapSettingsBlob> result = builder.CreateBlobAssetReference<MapSettingsBlob>(Allocator.Persistent);

            return result;
        }

        /// <summary>
        /// Crée un blobAsset répliquant les données de la source
        /// </summary>
        /// <param name="builder">Le BlobBuilder</param>
        /// <param name="source">La source</param>
        /// <returns>Une référence au BlobAsset créé</returns>
        internal static BlobAssetReference<TileBlob> CreateTileBlob(ref BlobBuilder builder, TileSO source)
        {
            // Construct the root object for the blob asset. Notice the use of `ref`.
            ref TileBlob tile = ref builder.ConstructRoot<TileBlob>();

            tile.Name = source.Name;
            tile.Sprite = source.Sprite;

            // Now copy the data from the builder into its final place, which will
            // use the persistent allocator
            BlobAssetReference<TileBlob> result = builder.CreateBlobAssetReference<TileBlob>(Allocator.Persistent);

            return result;
        }
    }
}
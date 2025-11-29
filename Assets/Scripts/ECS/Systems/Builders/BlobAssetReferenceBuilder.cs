using Assets.Scripts.Models.SOs;
using Unity.Collections;
using Unity.Entities;

/// <summary>
/// Constructeur de BlobAssets
/// </summary>
internal struct BlobAssetReferenceBuilder
{
    /// <summary>
    /// Crée un blobAsset des paramètres de la carte à créer
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
}

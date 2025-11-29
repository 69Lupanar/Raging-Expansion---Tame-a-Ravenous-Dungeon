using Assets.Scripts.ECS.Blobs;
using Unity.Entities;

namespace Assets.Scripts.ECS.Components.MapGenerator
{
    /// <summary>
    /// Les paramètres possibles pour générer une carte
    /// </summary>
    public struct MapSettingsBlobRefCD : IComponentData
    {
        /// <summary>
        /// Les paramètres possibles pour générer une carte
        /// </summary>
        public BlobAssetReference<MapSettingsBlob> Value;
    }
}
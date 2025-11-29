using Assets.Scripts.ECS.Blobs;
using Assets.Scripts.ECS.Components.MapGenerator;
using Assets.Scripts.Models.SOs;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.ECS.Authoring
{
    /// <summary>
    /// Représente les données du générateur de niveau
    /// </summary>
    public class MapGeneratorAuthoring : MonoBehaviour
    {
        #region Variables d'instance

        /// <summary>
        /// Les paramètres possibles pour générer une carte
        /// </summary>
        [field: SerializeField]
        public MapSettingsSO MapSettingsSO { get; private set; }

        /// <summary>
        /// La liste des cases possibles
        /// </summary>
        [field: SerializeField]
        public TileSO[] TileSOs { get; private set; }

        #endregion
    }

    /// <summary>
    /// Convertit le component en entité
    /// </summary>
    public class MapGeneratorBaker : Baker<MapGeneratorAuthoring>
    {
        /// <summary>
        /// Convertit le component en entité
        /// </summary>
        /// <param name="authoring">Le component à convertir</param>
        public override void Bake(MapGeneratorAuthoring authoring)
        {
            DependsOn(authoring.MapSettingsSO);

            if (authoring.MapSettingsSO == null)
                return;

            if (authoring.TileSOs == null || authoring.TileSOs.Length == 0)
                return;

            Entity entity = GetEntity(TransformUsageFlags.None);
            BlobBuilder builder = new(Allocator.Temp);

            BlobAssetReference<MapSettingsBlob> reference = BlobAssetReferenceBuilder.CreateMapSettingsBlob(ref builder, authoring.MapSettingsSO);
            AddComponent(entity, new MapSettingsBlobRefCD() { Value = reference });
            DynamicBuffer<TileBlobRefBE> tileBlobs = AddBuffer<TileBlobRefBE>(entity);

            foreach (TileSO tile in authoring.TileSOs)
            {
                if (tile != null)
                {
                    tileBlobs.Add(new TileBlobRefBE() { Value = BlobAssetReferenceBuilder.CreateTileBlob(ref builder, tile) });
                }
            }

            builder.Dispose();
        }
    }
}
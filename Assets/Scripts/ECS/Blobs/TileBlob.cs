using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.ECS.Blobs
{
    /// <summary>
    /// Les données d'une case
    /// </summary>
    public struct TileBlob
    {
        #region Propriétés

        /// <summary>
        /// Le nom de la case
        /// </summary>
        [field: SerializeField]
        public FixedString128Bytes Name { get; set; }

        /// <summary>
        /// Le Sprite de la case
        /// </summary>
        [field: SerializeField]
        public UnityObjectRef<Sprite> Sprite { get; set; }

        #endregion
    }
}
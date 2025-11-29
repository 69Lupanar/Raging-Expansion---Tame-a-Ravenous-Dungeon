using Unity.Collections;
using UnityEngine;

namespace Assets.Scripts.Models.SOs
{
    /// <summary>
    /// Représente une case à afficher à l'écran
    /// </summary>
    [CreateAssetMenu(fileName = "New Tile", menuName = "Scriptable Objects/Tiles/Tile", order = 0)]
    public class TileSO : ScriptableObject
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
        public Sprite Sprite { get; set; }

        #endregion
    }
}
using Unity.Mathematics;
using UnityEngine;

namespace Assets.Scripts.Models.SOs
{
    /// <summary>
    /// Les paramètres de la carte à générer
    /// </summary>
    [CreateAssetMenu(fileName = "New Map Settings", menuName = "Scriptable Objects/Map Generation/Map Settings", order = 0)]
    public class MapSettingsSO : ScriptableObject
    {
        #region Propriétés

        /// <summary>
        /// Les dimensions de la carte
        /// </summary>
        [field: SerializeField]
        public int2 MinMaxDimensions { get; set; }

        #endregion
    }
}
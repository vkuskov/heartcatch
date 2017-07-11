﻿using UnityEngine;

namespace Heartcatch.Models
{
    [CreateAssetMenu(menuName = "Heartcatch/Game Config")]
    public sealed class GameConfigModel : ScriptableObject, IGameConfigModel
    {
        [SerializeField] private string assetBundleUrl;

        [SerializeField] private string firstSceneBundle;

        [SerializeField] private bool isDevelopmentMode;

        public bool IsDevelopmentMode => isDevelopmentMode;

        public string AssetBundleUrl => assetBundleUrl;

        public string FirstSceneBundle => firstSceneBundle;
    }
}
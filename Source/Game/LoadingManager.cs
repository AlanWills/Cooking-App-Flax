using System;
using System.Collections.Generic;
using Celeste.Events;
using FlaxEngine;

namespace Game
{
    public class LoadingManager : Script
    {
        [Serialize, ShowInEditor, AssetReference(typeof(VoidEvent))] private JsonAsset loadBootstrapSceneEvent;
        [Serialize, ShowInEditor] private SceneReference bootstrapScene;
        
        /// <inheritdoc/>
        public override void OnEnable()
        {
            ((VoidEvent)loadBootstrapSceneEvent.Instance).AddCallback(OnLoadBootstrapScene);
        }

        /// <inheritdoc/>
        public override void OnDisable()
        {
            ((VoidEvent)loadBootstrapSceneEvent.Instance).RemoveCallback(OnLoadBootstrapScene);
        }

        /// <inheritdoc/>
        public override void OnUpdate()
        {
            // Here you can add code that needs to be called every frame
        }

        #region Callbacks

        private void OnLoadBootstrapScene()
        {
            Level.ChangeSceneAsync(bootstrapScene);
        }

        #endregion
    }
}

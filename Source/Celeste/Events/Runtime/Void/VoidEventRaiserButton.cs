using FlaxEngine;
using FlaxEngine.GUI;

namespace Celeste.Events
{
    public class VoidEventRaiserButton : Script
    {
        #region Properties and Fields

        [Serialize, ShowInEditor] private UIControl button;
        [Serialize, ShowInEditor, AssetReference(typeof(VoidEvent))] private JsonAsset eventToInvoke;

        #endregion

        public override void OnEnable()
        {
            base.OnEnable();

            button.Get<Button>().Clicked += VoidEventRaiserButton_Clicked;
        }

        public override void OnDisable()
        {
            button.Get<Button>().Clicked -= VoidEventRaiserButton_Clicked;

            base.OnDisable();
        }

        private void VoidEventRaiserButton_Clicked()
        {
            ((VoidEvent)eventToInvoke.Instance).Invoke();
        }
    }
}
using FlaxEditor;
using FlaxEditor.GUI;
using FlaxEditor.GUI.ContextMenu;
using FlaxEngine;

namespace CelesteEditor.Project
{
    public class CelesteProjectPlugin : EditorPlugin
    {
        private ContextMenuButton _button;

        /// <inheritdoc />
        public override void InitializeEditor()
        {
            base.InitializeEditor();

            _button = Editor.UI.AddMenuButton("Celeste/Code Generation", "Add Module", OnMenuItemPressed);
        }

        /// <inheritdoc />
        public override void DeinitializeEditor()
        {
            if (_button != null)
            {
                _button.Dispose();
                _button = null;
            }

            base.DeinitializeEditor();
        }

        private void OnMenuItemPressed()
        {
            MessageBox.Show("Button clicked!");
        }
    }
}

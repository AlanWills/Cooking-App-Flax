using FlaxEditor.Modules;
using FlaxEngine;
using System.IO;

namespace CelesteEditor.Project
{
    public struct ModuleInfo
    {
        public string ModuleDirectoryPath;
        public string ModuleBuildScriptClassName;
        public string ModuleName;
        public bool IsEditorModule;
        public bool ShouldModuleBuildNativeCode;
    }

    public struct CreateModuleArguments
    {
        public ModuleInfo RuntimeModuleInfo => new ModuleInfo()
        {
            IsEditorModule = false,
            ModuleName = RuntimeModuleName,
            ModuleBuildScriptClassName = RuntimeModuleBuildScriptClassName,
            ModuleDirectoryPath = Path.Combine(ParentDirectory, DirectoryName, "Runtime"),
            ShouldModuleBuildNativeCode = ShouldRuntimeModuleBuildNativeCode
        };

        public ModuleInfo EditorModuleInfo => new ModuleInfo()
        {
            IsEditorModule = true,
            ModuleName = EditorModuleName,
            ModuleBuildScriptClassName = EditorModuleBuildScriptClassName,
            ModuleDirectoryPath = Path.Combine(ParentDirectory, DirectoryName, "Editor"),
            ShouldModuleBuildNativeCode = ShouldEditorModuleBuildNativeCode
        };

        [Tooltip("The full path of the directory that the module's directory will be created in")] public string ParentDirectory;
        [Tooltip("The name of the module's directory that sub directories and files will be created in")] public string DirectoryName;

        [Header("Runtime")]
        [Tooltip("If true, a runtime module for code used by the game when it runs will be created")] public bool HasRuntimeModule;
        [Tooltip("The name of the class that will contain the build script information for the runtime class"), VisibleIf(nameof(HasRuntimeModule))] public string RuntimeModuleBuildScriptClassName;
        [Tooltip("The name of the runtime binary and the runtime project created by the build system in your IDE"), VisibleIf(nameof(HasRuntimeModule))] public string RuntimeModuleName;
        [Tooltip("A flag to determine if the module should include and build C++ files"), VisibleIf(nameof(HasRuntimeModule))] public bool ShouldRuntimeModuleBuildNativeCode;

        [Header("Editor")]
        [Tooltip("If true, an editor module for code used by the editor will be created")] public bool HasEditorModule;
        [Tooltip("The name of the class that will contain the build script information for the runtime class"), VisibleIf(nameof(HasEditorModule))] public string EditorModuleBuildScriptClassName;
        [Tooltip("The name of the editor binary and the editor project created by the build system in your IDE"), VisibleIf(nameof(HasEditorModule))] public string EditorModuleName;
        [Tooltip("A flag to determine if the module should include and build C++ files"), VisibleIf(nameof(HasEditorModule))] public bool ShouldEditorModuleBuildNativeCode;

        public void SetDefaultValues()
        {
            HasRuntimeModule = true;
            HasEditorModule = true;
            ShouldRuntimeModuleBuildNativeCode = false;
            ShouldEditorModuleBuildNativeCode = false;
        }
    }
}

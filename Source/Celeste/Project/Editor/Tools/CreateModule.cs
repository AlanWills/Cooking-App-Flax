using System.IO;

namespace CelesteEditor.Project
{
    public static class CreateModule
    {
        public static void Create(CreateModuleArguments arguments)
        {
            if (arguments.HasRuntimeModule)
            {
                CreateAssembly(arguments.RuntimeModuleInfo);
            }

            if (arguments.HasEditorModule)
            {
                CreateAssembly(arguments.EditorModuleInfo);
            }
        }

        public static void CreateAssembly(ModuleInfo moduleInfo)
        {
            Directory.CreateDirectory(moduleInfo.ModuleDirectoryPath);

            string formattedBuildFile = string.Format(
                CreateModuleConstants.MODULE_DEFINITION,
                moduleInfo.ModuleBuildScriptClassName,
                moduleInfo.IsEditorModule ? "GameEditorModule" : "GameModule",
                moduleInfo.ModuleName,
                moduleInfo.ShouldModuleBuildNativeCode);

            string buildFilePath = Path.Combine(moduleInfo.ModuleDirectoryPath, $"{moduleInfo.ModuleName}.Build.cs");
            File.WriteAllText(buildFilePath, formattedBuildFile);
        }
    }
}

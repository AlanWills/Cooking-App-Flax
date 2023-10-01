using System.Collections.Generic;
using System.IO;

namespace CelesteEditor.Project
{
    public static class CreateModule
    {
        public static void Create(CreateModuleArguments arguments)
        {

        }

        public static string CreateAssembly(ModuleInfo moduleInfo)
        {
            string directoryPath = !string.IsNullOrEmpty(parentDirectoryPath) ? Path.Combine(parentDirectoryPath, directoryName) : directoryName;
            AssetUtility.CreateFolder(Path.Combine(directoryPath, "Scripts"));

            AsmDef assemblyDef = new AsmDef();
            assemblyDef.autoReferenced = true;
            assemblyDef.rootNamespace = assemblyNamespace;
            assemblyDef.name = assemblyName;
            assemblyDef.references = references != null ? references.ToArray() : null;
            assemblyDef.includePlatforms = includePlatforms != null ? includePlatforms.ToArray() : null;

            string scriptsDirectory = Path.Combine(directoryPath, "Scripts");
            File.WriteAllText(Path.Combine(scriptsDirectory, $"{assemblyName}.asmdef"), JsonUtility.ToJson(assemblyDef, true));
            File.WriteAllText(Path.Combine(scriptsDirectory, PLACEHOLDER_SCRIPT_NAME), "");

            return scriptsDirectory;
        }
    }
}

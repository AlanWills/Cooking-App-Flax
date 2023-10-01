using Flax.Build;
using Flax.Build.NativeCpp;
using System.IO;

public class Lua : GameModule
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // C#-only scripting
        BinaryModuleName = "Lua";
        BuildNativeCode = true;
    }

    /// <inheritdoc />
    public override void Setup(BuildOptions options)
    {
        base.Setup(options);

        // I found a repo online where someone had done a cmake project of Lua 5.4.6 and that was enough to get a static lib
        // Linking against that with the /std:c++17 option for sol was enough!
        options.CompileEnv.CppVersion = CppVersion.Cpp17;
        options.CompileEnv.CustomArgs.Add("/std:c++17");
        options.PrivateIncludePaths.Add(Path.Combine(FolderPath, "C++", "Include"));
        options.PrivateIncludePaths.Add(Path.Combine(FolderPath, "C++", "Include", "lua"));
        options.LinkEnv.InputLibraries.Add(Path.Combine(FolderPath, "C++", "Lib", "x64", "lua_static.lib"));
        options.ScriptingAPI.IgnoreMissingDocumentationWarnings = true;
    }
}

using Flax.Build;
using Flax.Build.NativeCpp;
using System.IO;

public class CelesteEvents : GameModule
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        Name = "Celeste.Events";
        BinaryModuleName = "Celeste.Events";
        BuildNativeCode = false;
    }

    /// <inheritdoc />
    public override void Setup(BuildOptions options)
    {
        base.Setup(options);

        options.ScriptingAPI.IgnoreMissingDocumentationWarnings = true;
    }
}

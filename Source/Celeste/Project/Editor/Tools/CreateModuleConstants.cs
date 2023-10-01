namespace CelesteEditor.Project
{
    public static class CreateModuleConstants
    {
        public const string MODULE_DEFINITION = 
"using Flax.Build;\n" +
"using Flax.Build.NativeCpp;\n" +
"\n" +
"public class {0} : {1}\n" +
"{\n" +
"    public override void Init()\n" +
"    {\n" +
"        base.Init();\n" +
"\n" +
"        Name = {3};\n" +
"        BinaryModuleName = {3}\n;" +
"        BuildNativeCode = {2};\n" +
"    }\n" +
"\n" +
"    public override void Setup(BuildOptions options)\n" +
"    {\n" +
"        base.Setup(options);\n" +
"    \n" +
"        options.ScriptingAPI.IgnoreMissingDocumentationWarnings = true;\n" +
"    }\n" +
"}\n";
    }
}

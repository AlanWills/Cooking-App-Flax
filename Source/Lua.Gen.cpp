// This code was auto-generated. Do not modify it.

#include "Engine/Scripting/BinaryModule.h"
#include "Lua.Gen.h"

StaticallyLinkedBinaryModuleInitializer StaticallyLinkedBinaryModuleLua(GetBinaryModuleLua);

extern "C" BinaryModule* GetBinaryModuleLua()
{
    static NativeBinaryModule module("Lua");
    return &module;
}

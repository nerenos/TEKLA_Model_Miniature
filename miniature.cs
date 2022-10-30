﻿#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace UserMacros {
    public sealed class Macro {
        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]
        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime) {
            Tekla.Macros.Akit.IAkitScriptHost akit = runtime.Get<Tekla.Macros.Akit.IAkitScriptHost>();
            akit.Callback("diaDisplaySnapshotDialog", "", "main_frame");
            akit.FileSelection("D:\\TeklaStructuresModels\\Charpente\\thumbnail");
            akit.PushButton("browse", "snapshot_dialog");
            akit.PushButton("take_snapshot", "snapshot_dialog");
        }
    }
}

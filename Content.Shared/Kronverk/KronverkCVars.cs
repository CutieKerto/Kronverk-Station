using Robust.Shared.Configuration;

namespace Content.Shared.Kronverk;

[CVarDefs]
public sealed class KronverkCVars
{
    /*
    * Antispam
    */

    public static readonly CVarDef<bool> ChatAntispam =
        CVarDef.Create("ic.antispam", true, CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    public static readonly CVarDef<int> AntispamMinLength =
        CVarDef.Create("ic.antispam_min_length", 7, CVar.SERVERONLY);

    public static readonly CVarDef<double> AntispamIntervalSeconds =
        CVarDef.Create("ic.antispam_interval_seconds", 3d, CVar.SERVERONLY);
}

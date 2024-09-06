using LmpCommon;
using LmpCommon.Message.Data.Flag;

namespace LmpClient.Systems.Flag
{
    public class ExtendedFlagInfo : FlagInfo
    {
        public string ShaSum => LmpCommon.Common.CalculateSha256Hash(FlagData);
        public bool Loaded { get; set; }

        public ExtendedFlagInfo(FlagInfo flagInfo)
        {
            FlagData = LmpCommon.Common.TrimArray(flagInfo.FlagData, flagInfo.NumBytes);
            Owner = flagInfo.Owner;
            FlagName = flagInfo.FlagName;
        }
    }
}
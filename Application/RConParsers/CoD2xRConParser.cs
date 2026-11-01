using System.Globalization;
using IW4MAdmin.Application.Misc;
using Microsoft.Extensions.Logging;
using SharedLibraryCore;
using static SharedLibraryCore.Server;
using SharedLibraryCore.Interfaces;

namespace IW4MAdmin.Application.RConParsers
{
    /// <summary>
    /// RCON parser for CoD2x servers that report client GUIDs as signed decimal values.
    /// </summary>
    public sealed class CoD2xRConParser : BaseRConParser
    {
        public CoD2xRConParser(ILogger<BaseRConParser> logger, IParserRegexFactory parserRegexFactory)
            : base(logger, parserRegexFactory)
        {
            Name = "CoD2x";
            Version = "CoD2x";
            GameName = Game.COD;
            Configuration.GuidNumberStyle = NumberStyles.Integer;

            // CoD2x uses its own kick and ban commands.
            Configuration.CommandPrefixes.Kick = "clientkick {0}";
            Configuration.CommandPrefixes.Ban = "banClient {0}";
            Configuration.CommandPrefixes.TempBan = "tempBanClient {0}";


            // CoD2x status rows can contain signed decimal GUIDs, e.g. -1342227394.
            // Keep the base parser's column layout and mappings, changing only the GUID field.
            Configuration.Status.Pattern =
                @"^ *([0-9]+) +-?([0-9]+) +((?:[A-Z]+|[0-9]+)) +(-?[0-9]{1,20}|(?:[a-z]|[0-9]){8,32}|bot[0-9]+) *(.{0,32}) +([0-9]+) +(\d+\.\d+\.\d+\.\d+:-*\d{1,5}|0+\.0+:-*\d{1,5}|loopback|unknown) +(-*[0-9]+) +([0-9]+) *$";
        }
    }
}

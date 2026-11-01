using System.Globalization;
using IW4MAdmin.Plugins.Stats.Events;
using Microsoft.Extensions.Logging;
using SharedLibraryCore.Configuration;
using SharedLibraryCore.Interfaces;
using SharedLibraryCore.Interfaces.Events;

namespace IW4MAdmin.Application.EventParsers
{
    /// <summary>
    /// CoD2x uses signed decimal client identifiers in its J/Q/K log events.
    /// The base Call of Duty event patterns already understand the event layout;
    /// this parser changes the identifier conversion from hexadecimal to decimal.
    /// </summary>
    public sealed class CoD2xEventParser : BaseEventParser
    {
        public CoD2xEventParser(IParserRegexFactory parserRegexFactory, Microsoft.Extensions.Logging.ILogger logger,
            ApplicationConfiguration appConfig, IGameScriptEventFactory gameScriptEventFactory)
            : base(parserRegexFactory, logger, appConfig, gameScriptEventFactory)
        {
            Name = "CoD2x";
            Version = "CoD2x";

            Configuration.GuidNumberStyle = NumberStyles.Integer;
        }
    }
}

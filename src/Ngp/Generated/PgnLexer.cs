//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/AEVO-EZEQUIEL/Documents/projetos/Ngp/src/Ngp/Pgn.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Ngp.Generated {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class PgnLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WS=1, EVENT=2, SITE=3, DATE=4, ROUND=5, WHITE=6, BLACK=7, WHITEELO=8, 
		BLACKELO=9, WHITETITLE=10, BLACKTITLE=11, RESULT=12, GAMEID=13, VARIANT=14, 
		TIMECONTROL=15, ECO=16, OPENING=17, TERMINATION=18, ANNOTATOR=19, WHITEFIDEID=20, 
		BLACKFIDEID=21, STUDYNAME=22, CHAPTERNAME=23, UTCDATE=24, UTCTIME=25, 
		GAMEURL=26, LBRACE=27, RBRACE=28, STRING_VALUE=29, ANALYSIS=30, MOVES=31;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WS", "EVENT", "SITE", "DATE", "ROUND", "WHITE", "BLACK", "WHITEELO", 
		"BLACKELO", "WHITETITLE", "BLACKTITLE", "RESULT", "GAMEID", "VARIANT", 
		"TIMECONTROL", "ECO", "OPENING", "TERMINATION", "ANNOTATOR", "WHITEFIDEID", 
		"BLACKFIDEID", "STUDYNAME", "CHAPTERNAME", "UTCDATE", "UTCTIME", "GAMEURL", 
		"LBRACE", "RBRACE", "STRING_VALUE", "ANALYSIS", "MOVES"
	};


	public PgnLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public PgnLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'Event'", "'Site'", "'Date'", "'Round'", "'White'", "'Black'", 
		"'WhiteElo'", "'BlackElo'", "'WhiteTitle'", "'BlackTitle'", "'Result'", 
		"'GameId'", "'Variant'", "'TimeControl'", "'ECO'", "'Opening'", "'Termination'", 
		"'Annotator'", "'WhiteFideId'", "'BlackFideId'", "'StudyName'", "'ChapterName'", 
		"'UTCDate'", "'UTCTime'", "'GameURL'", "'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "EVENT", "SITE", "DATE", "ROUND", "WHITE", "BLACK", "WHITEELO", 
		"BLACKELO", "WHITETITLE", "BLACKTITLE", "RESULT", "GAMEID", "VARIANT", 
		"TIMECONTROL", "ECO", "OPENING", "TERMINATION", "ANNOTATOR", "WHITEFIDEID", 
		"BLACKFIDEID", "STUDYNAME", "CHAPTERNAME", "UTCDATE", "UTCTIME", "GAMEURL", 
		"LBRACE", "RBRACE", "STRING_VALUE", "ANALYSIS", "MOVES"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Pgn.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static PgnLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,31,333,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,1,0,4,0,65,8,0,11,0,12,0,66,1,0,1,0,1,1,1,1,1,
		1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,
		1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,
		7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,
		1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,10,
		1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,
		1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,
		1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,16,
		1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,17,1,17,
		1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,
		1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,
		1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,21,1,21,1,21,
		1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,1,22,
		1,22,1,22,1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,23,1,23,1,23,1,23,1,24,
		1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,25,1,25,
		1,25,1,26,1,26,1,27,1,27,1,28,1,28,1,28,1,28,5,28,291,8,28,10,28,12,28,
		294,9,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,29,1,30,4,30,305,8,30,11,
		30,12,30,306,1,30,1,30,5,30,311,8,30,10,30,12,30,314,9,30,1,30,1,30,1,
		30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,3,30,330,8,30,
		1,30,1,30,1,312,0,31,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,
		11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,
		23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,1,0,4,3,0,9,10,13,13,
		32,32,2,0,34,34,92,92,1,0,46,46,1,0,48,57,340,0,1,1,0,0,0,0,3,1,0,0,0,
		0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,
		0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,
		27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,
		0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,
		0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,
		1,0,0,0,0,61,1,0,0,0,1,64,1,0,0,0,3,70,1,0,0,0,5,76,1,0,0,0,7,81,1,0,0,
		0,9,86,1,0,0,0,11,92,1,0,0,0,13,98,1,0,0,0,15,104,1,0,0,0,17,113,1,0,0,
		0,19,122,1,0,0,0,21,133,1,0,0,0,23,144,1,0,0,0,25,151,1,0,0,0,27,158,1,
		0,0,0,29,166,1,0,0,0,31,178,1,0,0,0,33,182,1,0,0,0,35,190,1,0,0,0,37,202,
		1,0,0,0,39,212,1,0,0,0,41,224,1,0,0,0,43,236,1,0,0,0,45,246,1,0,0,0,47,
		258,1,0,0,0,49,266,1,0,0,0,51,274,1,0,0,0,53,282,1,0,0,0,55,284,1,0,0,
		0,57,286,1,0,0,0,59,297,1,0,0,0,61,304,1,0,0,0,63,65,7,0,0,0,64,63,1,0,
		0,0,65,66,1,0,0,0,66,64,1,0,0,0,66,67,1,0,0,0,67,68,1,0,0,0,68,69,6,0,
		0,0,69,2,1,0,0,0,70,71,5,69,0,0,71,72,5,118,0,0,72,73,5,101,0,0,73,74,
		5,110,0,0,74,75,5,116,0,0,75,4,1,0,0,0,76,77,5,83,0,0,77,78,5,105,0,0,
		78,79,5,116,0,0,79,80,5,101,0,0,80,6,1,0,0,0,81,82,5,68,0,0,82,83,5,97,
		0,0,83,84,5,116,0,0,84,85,5,101,0,0,85,8,1,0,0,0,86,87,5,82,0,0,87,88,
		5,111,0,0,88,89,5,117,0,0,89,90,5,110,0,0,90,91,5,100,0,0,91,10,1,0,0,
		0,92,93,5,87,0,0,93,94,5,104,0,0,94,95,5,105,0,0,95,96,5,116,0,0,96,97,
		5,101,0,0,97,12,1,0,0,0,98,99,5,66,0,0,99,100,5,108,0,0,100,101,5,97,0,
		0,101,102,5,99,0,0,102,103,5,107,0,0,103,14,1,0,0,0,104,105,5,87,0,0,105,
		106,5,104,0,0,106,107,5,105,0,0,107,108,5,116,0,0,108,109,5,101,0,0,109,
		110,5,69,0,0,110,111,5,108,0,0,111,112,5,111,0,0,112,16,1,0,0,0,113,114,
		5,66,0,0,114,115,5,108,0,0,115,116,5,97,0,0,116,117,5,99,0,0,117,118,5,
		107,0,0,118,119,5,69,0,0,119,120,5,108,0,0,120,121,5,111,0,0,121,18,1,
		0,0,0,122,123,5,87,0,0,123,124,5,104,0,0,124,125,5,105,0,0,125,126,5,116,
		0,0,126,127,5,101,0,0,127,128,5,84,0,0,128,129,5,105,0,0,129,130,5,116,
		0,0,130,131,5,108,0,0,131,132,5,101,0,0,132,20,1,0,0,0,133,134,5,66,0,
		0,134,135,5,108,0,0,135,136,5,97,0,0,136,137,5,99,0,0,137,138,5,107,0,
		0,138,139,5,84,0,0,139,140,5,105,0,0,140,141,5,116,0,0,141,142,5,108,0,
		0,142,143,5,101,0,0,143,22,1,0,0,0,144,145,5,82,0,0,145,146,5,101,0,0,
		146,147,5,115,0,0,147,148,5,117,0,0,148,149,5,108,0,0,149,150,5,116,0,
		0,150,24,1,0,0,0,151,152,5,71,0,0,152,153,5,97,0,0,153,154,5,109,0,0,154,
		155,5,101,0,0,155,156,5,73,0,0,156,157,5,100,0,0,157,26,1,0,0,0,158,159,
		5,86,0,0,159,160,5,97,0,0,160,161,5,114,0,0,161,162,5,105,0,0,162,163,
		5,97,0,0,163,164,5,110,0,0,164,165,5,116,0,0,165,28,1,0,0,0,166,167,5,
		84,0,0,167,168,5,105,0,0,168,169,5,109,0,0,169,170,5,101,0,0,170,171,5,
		67,0,0,171,172,5,111,0,0,172,173,5,110,0,0,173,174,5,116,0,0,174,175,5,
		114,0,0,175,176,5,111,0,0,176,177,5,108,0,0,177,30,1,0,0,0,178,179,5,69,
		0,0,179,180,5,67,0,0,180,181,5,79,0,0,181,32,1,0,0,0,182,183,5,79,0,0,
		183,184,5,112,0,0,184,185,5,101,0,0,185,186,5,110,0,0,186,187,5,105,0,
		0,187,188,5,110,0,0,188,189,5,103,0,0,189,34,1,0,0,0,190,191,5,84,0,0,
		191,192,5,101,0,0,192,193,5,114,0,0,193,194,5,109,0,0,194,195,5,105,0,
		0,195,196,5,110,0,0,196,197,5,97,0,0,197,198,5,116,0,0,198,199,5,105,0,
		0,199,200,5,111,0,0,200,201,5,110,0,0,201,36,1,0,0,0,202,203,5,65,0,0,
		203,204,5,110,0,0,204,205,5,110,0,0,205,206,5,111,0,0,206,207,5,116,0,
		0,207,208,5,97,0,0,208,209,5,116,0,0,209,210,5,111,0,0,210,211,5,114,0,
		0,211,38,1,0,0,0,212,213,5,87,0,0,213,214,5,104,0,0,214,215,5,105,0,0,
		215,216,5,116,0,0,216,217,5,101,0,0,217,218,5,70,0,0,218,219,5,105,0,0,
		219,220,5,100,0,0,220,221,5,101,0,0,221,222,5,73,0,0,222,223,5,100,0,0,
		223,40,1,0,0,0,224,225,5,66,0,0,225,226,5,108,0,0,226,227,5,97,0,0,227,
		228,5,99,0,0,228,229,5,107,0,0,229,230,5,70,0,0,230,231,5,105,0,0,231,
		232,5,100,0,0,232,233,5,101,0,0,233,234,5,73,0,0,234,235,5,100,0,0,235,
		42,1,0,0,0,236,237,5,83,0,0,237,238,5,116,0,0,238,239,5,117,0,0,239,240,
		5,100,0,0,240,241,5,121,0,0,241,242,5,78,0,0,242,243,5,97,0,0,243,244,
		5,109,0,0,244,245,5,101,0,0,245,44,1,0,0,0,246,247,5,67,0,0,247,248,5,
		104,0,0,248,249,5,97,0,0,249,250,5,112,0,0,250,251,5,116,0,0,251,252,5,
		101,0,0,252,253,5,114,0,0,253,254,5,78,0,0,254,255,5,97,0,0,255,256,5,
		109,0,0,256,257,5,101,0,0,257,46,1,0,0,0,258,259,5,85,0,0,259,260,5,84,
		0,0,260,261,5,67,0,0,261,262,5,68,0,0,262,263,5,97,0,0,263,264,5,116,0,
		0,264,265,5,101,0,0,265,48,1,0,0,0,266,267,5,85,0,0,267,268,5,84,0,0,268,
		269,5,67,0,0,269,270,5,84,0,0,270,271,5,105,0,0,271,272,5,109,0,0,272,
		273,5,101,0,0,273,50,1,0,0,0,274,275,5,71,0,0,275,276,5,97,0,0,276,277,
		5,109,0,0,277,278,5,101,0,0,278,279,5,85,0,0,279,280,5,82,0,0,280,281,
		5,76,0,0,281,52,1,0,0,0,282,283,5,91,0,0,283,54,1,0,0,0,284,285,5,93,0,
		0,285,56,1,0,0,0,286,292,5,34,0,0,287,291,8,1,0,0,288,289,5,92,0,0,289,
		291,9,0,0,0,290,287,1,0,0,0,290,288,1,0,0,0,291,294,1,0,0,0,292,290,1,
		0,0,0,292,293,1,0,0,0,293,295,1,0,0,0,294,292,1,0,0,0,295,296,5,34,0,0,
		296,58,1,0,0,0,297,298,5,123,0,0,298,299,7,2,0,0,299,300,5,125,0,0,300,
		301,1,0,0,0,301,302,6,29,0,0,302,60,1,0,0,0,303,305,7,3,0,0,304,303,1,
		0,0,0,305,306,1,0,0,0,306,304,1,0,0,0,306,307,1,0,0,0,307,308,1,0,0,0,
		308,312,5,46,0,0,309,311,9,0,0,0,310,309,1,0,0,0,311,314,1,0,0,0,312,313,
		1,0,0,0,312,310,1,0,0,0,313,329,1,0,0,0,314,312,1,0,0,0,315,316,5,49,0,
		0,316,317,5,45,0,0,317,330,5,48,0,0,318,319,5,48,0,0,319,320,5,45,0,0,
		320,330,5,49,0,0,321,322,5,49,0,0,322,323,5,47,0,0,323,324,5,50,0,0,324,
		325,5,45,0,0,325,326,5,49,0,0,326,327,5,47,0,0,327,330,5,50,0,0,328,330,
		5,42,0,0,329,315,1,0,0,0,329,318,1,0,0,0,329,321,1,0,0,0,329,328,1,0,0,
		0,330,331,1,0,0,0,331,332,6,30,0,0,332,62,1,0,0,0,7,0,66,290,292,306,312,
		329,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Ngp.Generated

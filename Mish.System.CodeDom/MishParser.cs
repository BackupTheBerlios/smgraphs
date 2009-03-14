// $ANTLR 3.1.2 Mish.g 2009-03-14 14:49:58

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class MishParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"SINGLE_LINE_COMMENT_START", 
		"NEWLINE", 
		"SINGLE_LINE_COMMENT", 
		"WS"
    };

    public const int SINGLE_LINE_COMMENT = 6;
    public const int WS = 7;
    public const int NEWLINE = 5;
    public const int EOF = -1;
    public const int SINGLE_LINE_COMMENT_START = 4;

    // delegates
    // delegators



        public MishParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MishParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return MishParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Mish.g"; }
    }



    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

}

// $ANTLR 3.1.2 Mish.g 2009-03-15 23:39:13

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class MishLexer : Lexer {
    public const int MULTI_LINE_COMMENT_START = 6;
    public const int WS = 10;
    public const int SINGLE_LINE_COMMENT = 4;
    public const int MULTI_LINE_COMMENT_END = 7;
    public const int NEWLINE = 9;
    public const int SINGLE_LINE_COMMENT_START = 8;
    public const int EOF = -1;
    public const int MULTI_LINE_COMMENT = 5;

    // delegates
    // delegators

    public MishLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MishLexer(ICharStream input)
		: this(input, null) {
    }
    public MishLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Mish.g";} 
    }

    // $ANTLR start "MULTI_LINE_COMMENT"
    public void mMULTI_LINE_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTI_LINE_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:26:2: ( MULTI_LINE_COMMENT_START ( options {greedy=false; } : . )* MULTI_LINE_COMMENT_END )
            // Mish.g:27:2: MULTI_LINE_COMMENT_START ( options {greedy=false; } : . )* MULTI_LINE_COMMENT_END
            {
            	mMULTI_LINE_COMMENT_START(); 
            	// Mish.g:28:2: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '*') )
            	    {
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == '/') )
            	        {
            	            alt1 = 2;
            	        }
            	        else if ( ((LA1_1 >= '\u0000' && LA1_1 <= '.') || (LA1_1 >= '0' && LA1_1 <= '\uFFFF')) )
            	        {
            	            alt1 = 1;
            	        }


            	    }
            	    else if ( ((LA1_0 >= '\u0000' && LA1_0 <= ')') || (LA1_0 >= '+' && LA1_0 <= '\uFFFF')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Mish.g:28:31: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	mMULTI_LINE_COMMENT_END(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTI_LINE_COMMENT"

    // $ANTLR start "SINGLE_LINE_COMMENT"
    public void mSINGLE_LINE_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SINGLE_LINE_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:32:2: ( SINGLE_LINE_COMMENT_START ( . )* NEWLINE )
            // Mish.g:33:3: SINGLE_LINE_COMMENT_START ( . )* NEWLINE
            {
            	mSINGLE_LINE_COMMENT_START(); 
            	// Mish.g:34:3: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '\r') )
            	    {
            	        alt2 = 2;
            	    }
            	    else if ( (LA2_0 == '\n') )
            	    {
            	        alt2 = 2;
            	    }
            	    else if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\t') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Mish.g:34:3: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	mNEWLINE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SINGLE_LINE_COMMENT"

    // $ANTLR start "MULTI_LINE_COMMENT_START"
    public void mMULTI_LINE_COMMENT_START() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTI_LINE_COMMENT_START;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:40:2: ( '/*' )
            // Mish.g:41:2: '/*'
            {
            	Match("/*"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTI_LINE_COMMENT_START"

    // $ANTLR start "MULTI_LINE_COMMENT_END"
    public void mMULTI_LINE_COMMENT_END() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTI_LINE_COMMENT_END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:44:2: ( '*/' )
            // Mish.g:45:2: '*/'
            {
            	Match("*/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTI_LINE_COMMENT_END"

    // $ANTLR start "SINGLE_LINE_COMMENT_START"
    public void mSINGLE_LINE_COMMENT_START() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SINGLE_LINE_COMMENT_START;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:48:27: ( '//' )
            // Mish.g:48:29: '//'
            {
            	Match("//"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SINGLE_LINE_COMMENT_START"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:50:9: ( ( '\\r' )? '\\n' )
            // Mish.g:50:11: ( '\\r' )? '\\n'
            {
            	// Mish.g:50:11: ( '\\r' )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == '\r') )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Mish.g:50:11: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:52:4: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Mish.g:52:6: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Mish.g:52:6: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '\t' && LA4_0 <= '\n') || LA4_0 == '\r' || LA4_0 == ' ') )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // Mish.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements

            	 _channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // Mish.g:1:8: ( MULTI_LINE_COMMENT | SINGLE_LINE_COMMENT | MULTI_LINE_COMMENT_START | MULTI_LINE_COMMENT_END | SINGLE_LINE_COMMENT_START | NEWLINE | WS )
        int alt5 = 7;
        alt5 = dfa5.Predict(input);
        switch (alt5) 
        {
            case 1 :
                // Mish.g:1:10: MULTI_LINE_COMMENT
                {
                	mMULTI_LINE_COMMENT(); 

                }
                break;
            case 2 :
                // Mish.g:1:29: SINGLE_LINE_COMMENT
                {
                	mSINGLE_LINE_COMMENT(); 

                }
                break;
            case 3 :
                // Mish.g:1:49: MULTI_LINE_COMMENT_START
                {
                	mMULTI_LINE_COMMENT_START(); 

                }
                break;
            case 4 :
                // Mish.g:1:74: MULTI_LINE_COMMENT_END
                {
                	mMULTI_LINE_COMMENT_END(); 

                }
                break;
            case 5 :
                // Mish.g:1:97: SINGLE_LINE_COMMENT_START
                {
                	mSINGLE_LINE_COMMENT_START(); 

                }
                break;
            case 6 :
                // Mish.g:1:123: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 7 :
                // Mish.g:1:131: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA5 dfa5;
	private void InitializeCyclicDFAs()
	{
	    this.dfa5 = new DFA5(this);
	    this.dfa5.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA5_SpecialStateTransition);
	}

    const string DFA5_eotS =
        "\x03\uffff\x01\x05\x01\x08\x01\uffff\x01\x09\x01\x0b\x05\uffff";
    const string DFA5_eofS =
        "\x0d\uffff";
    const string DFA5_minS =
        "\x01\x09\x01\x2a\x01\uffff\x01\x0a\x01\x09\x01\uffff\x02\x00\x05"+
        "\uffff";
    const string DFA5_maxS =
        "\x02\x2f\x01\uffff\x01\x0a\x01\x20\x01\uffff\x02\uffff\x05\uffff";
    const string DFA5_acceptS =
        "\x02\uffff\x01\x04\x02\uffff\x01\x07\x02\uffff\x01\x06\x01\x03"+
        "\x01\x01\x01\x05\x01\x02";
    const string DFA5_specialS =
        "\x06\uffff\x01\x00\x01\x01\x05\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x05\x01\x04\x02\uffff\x01\x03\x12\uffff\x01\x05\x09\uffff"+
            "\x01\x02\x04\uffff\x01\x01",
            "\x01\x06\x04\uffff\x01\x07",
            "",
            "\x01\x04",
            "\x02\x05\x02\uffff\x01\x05\x12\uffff\x01\x05",
            "",
            "\x00\x0a",
            "\x00\x0c",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( MULTI_LINE_COMMENT | SINGLE_LINE_COMMENT | MULTI_LINE_COMMENT_START | MULTI_LINE_COMMENT_END | SINGLE_LINE_COMMENT_START | NEWLINE | WS );"; }
        }

    }


    protected internal int DFA5_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA5_6 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_6 >= '\u0000' && LA5_6 <= '\uFFFF')) ) { s = 10; }

                   	else s = 9;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA5_7 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_7 >= '\u0000' && LA5_7 <= '\uFFFF')) ) { s = 12; }

                   	else s = 11;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae5 =
            new NoViableAltException(dfa.Description, 5, _s, input);
        dfa.Error(nvae5);
        throw nvae5;
    }
 
    
}

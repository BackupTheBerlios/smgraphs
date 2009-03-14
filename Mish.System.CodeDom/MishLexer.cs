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


public partial class MishLexer : Lexer {
    public const int SINGLE_LINE_COMMENT = 6;
    public const int WS = 7;
    public const int NEWLINE = 5;
    public const int EOF = -1;
    public const int SINGLE_LINE_COMMENT_START = 4;

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

    // $ANTLR start "SINGLE_LINE_COMMENT"
    public void mSINGLE_LINE_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SINGLE_LINE_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:8:21: ( SINGLE_LINE_COMMENT_START ( . )* NEWLINE )
            // Mish.g:9:2: SINGLE_LINE_COMMENT_START ( . )* NEWLINE
            {
            	mSINGLE_LINE_COMMENT_START(); 
            	// Mish.g:10:2: ( . )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '\r') )
            	    {
            	        alt1 = 2;
            	    }
            	    else if ( (LA1_0 == '\n') )
            	    {
            	        alt1 = 2;
            	    }
            	    else if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t') || (LA1_0 >= '\u000B' && LA1_0 <= '\f') || (LA1_0 >= '\u000E' && LA1_0 <= '\uFFFF')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Mish.g:10:2: .
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

    // $ANTLR start "SINGLE_LINE_COMMENT_START"
    public void mSINGLE_LINE_COMMENT_START() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SINGLE_LINE_COMMENT_START;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Mish.g:13:27: ( '//' )
            // Mish.g:13:29: '//'
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
            // Mish.g:14:9: ( ( '\\r' )? '\\n' )
            // Mish.g:14:11: ( '\\r' )? '\\n'
            {
            	// Mish.g:14:11: ( '\\r' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '\r') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // Mish.g:14:11: '\\r'
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
            // Mish.g:15:4: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Mish.g:15:6: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Mish.g:15:6: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
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
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whinging that label 'loop3' has no statements

            	skip();

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
        // Mish.g:1:8: ( SINGLE_LINE_COMMENT | SINGLE_LINE_COMMENT_START | NEWLINE | WS )
        int alt4 = 4;
        switch ( input.LA(1) ) 
        {
        case '/':
        	{
            int LA4_1 = input.LA(2);

            if ( (LA4_1 == '/') )
            {
                int LA4_5 = input.LA(3);

                if ( ((LA4_5 >= '\u0000' && LA4_5 <= '\uFFFF')) )
                {
                    alt4 = 1;
                }
                else 
                {
                    alt4 = 2;}
            }
            else 
            {
                NoViableAltException nvae_d4s1 =
                    new NoViableAltException("", 4, 1, input);

                throw nvae_d4s1;
            }
            }
            break;
        case '\r':
        	{
            int LA4_2 = input.LA(2);

            if ( (LA4_2 == '\n') )
            {
                int LA4_3 = input.LA(3);

                if ( ((LA4_3 >= '\t' && LA4_3 <= '\n') || LA4_3 == '\r' || LA4_3 == ' ') )
                {
                    alt4 = 4;
                }
                else 
                {
                    alt4 = 3;}
            }
            else 
            {
                alt4 = 4;}
            }
            break;
        case '\n':
        	{
            int LA4_3 = input.LA(2);

            if ( ((LA4_3 >= '\t' && LA4_3 <= '\n') || LA4_3 == '\r' || LA4_3 == ' ') )
            {
                alt4 = 4;
            }
            else 
            {
                alt4 = 3;}
            }
            break;
        case '\t':
        case ' ':
        	{
            alt4 = 4;
            }
            break;
        	default:
        	    NoViableAltException nvae_d4s0 =
        	        new NoViableAltException("", 4, 0, input);

        	    throw nvae_d4s0;
        }

        switch (alt4) 
        {
            case 1 :
                // Mish.g:1:10: SINGLE_LINE_COMMENT
                {
                	mSINGLE_LINE_COMMENT(); 

                }
                break;
            case 2 :
                // Mish.g:1:30: SINGLE_LINE_COMMENT_START
                {
                	mSINGLE_LINE_COMMENT_START(); 

                }
                break;
            case 3 :
                // Mish.g:1:56: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 4 :
                // Mish.g:1:64: WS
                {
                	mWS(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}

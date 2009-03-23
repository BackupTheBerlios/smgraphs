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



using Antlr.Runtime.Tree;

public partial class MishParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"SINGLE_LINE_COMMENT", 
		"MULTI_LINE_COMMENT", 
		"MULTI_LINE_COMMENT_START", 
		"MULTI_LINE_COMMENT_END", 
		"SINGLE_LINE_COMMENT_START", 
		"NEWLINE", 
		"WS"
    };

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



        public MishParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MishParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return MishParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Mish.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // Mish.g:10:1: program : ( statement )+ ;
    public MishParser.program_return program() // throws RecognitionException [1]
    {   
        MishParser.program_return retval = new MishParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MishParser.statement_return statement1 = default(MishParser.statement_return);



        try 
    	{
            // Mish.g:11:2: ( ( statement )+ )
            // Mish.g:12:3: ( statement )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Mish.g:12:3: ( statement )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= SINGLE_LINE_COMMENT && LA1_0 <= MULTI_LINE_COMMENT)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Mish.g:12:3: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_program43);
            			    	statement1 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement1.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // Mish.g:15:1: statement : ( comment )+ ;
    public MishParser.statement_return statement() // throws RecognitionException [1]
    {   
        MishParser.statement_return retval = new MishParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MishParser.comment_return comment2 = default(MishParser.comment_return);



        try 
    	{
            // Mish.g:16:2: ( ( comment )+ )
            // Mish.g:17:3: ( comment )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Mish.g:17:3: ( comment )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= SINGLE_LINE_COMMENT && LA2_0 <= MULTI_LINE_COMMENT)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Mish.g:17:3: comment
            			    {
            			    	PushFollow(FOLLOW_comment_in_statement57);
            			    	comment2 = comment();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, comment2.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class comment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "comment"
    // Mish.g:20:1: comment : ( SINGLE_LINE_COMMENT | MULTI_LINE_COMMENT );
    public MishParser.comment_return comment() // throws RecognitionException [1]
    {   
        MishParser.comment_return retval = new MishParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set3 = null;

        object set3_tree=null;

        try 
    	{
            // Mish.g:21:2: ( SINGLE_LINE_COMMENT | MULTI_LINE_COMMENT )
            // Mish.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set3 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= SINGLE_LINE_COMMENT && input.LA(1) <= MULTI_LINE_COMMENT) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set3));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "comment"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_statement_in_program43 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_comment_in_statement57 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_set_in_comment0 = new BitSet(new ulong[]{0x0000000000000002UL});

}

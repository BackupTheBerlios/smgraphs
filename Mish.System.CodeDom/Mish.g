
grammar Mish;

options
{
    language=CSharp2;
}
SINGLE_LINE_COMMENT : 
	SINGLE_LINE_COMMENT_START  
	.*
	NEWLINE
	;
SINGLE_LINE_COMMENT_START : '//';
NEWLINE : '\r'?'\n' ;
WS : (' '|'\t'|'\n'|'\r')+ {skip();} ;

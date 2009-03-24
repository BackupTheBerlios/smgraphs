grammar Mish;
 
options
{
    //language=CSharp2;
    language=Java;
    output=AST;
}
tokens{
	COMMENT_DATA;
}
comment 	:
		(
		LINE_COMMENT  -> ^( COMMENT_DATA LINE_COMMENT)
	        | COMMENT  -> ^(  COMMENT_DATA COMMENT)
	        )+
	       		
	;
statement
	:
		 //LINE_COMMENT
	;
WS  :  (' '|'\r'|'\t'|'\u000C'|'\n') {$channel=HIDDEN;}
    ;

COMMENT
    :   '/*' ( options {greedy=false;} : . )* '*/' //{$channel=HIDDEN;}
    ;

LINE_COMMENT
    : 
    '//' 
    ~('\n'|'\r')*
    (ENDLINE | EOF) //{$channel=HIDDEN;}
    ;

ENDLINE	:	'\r'?'\n'
	;


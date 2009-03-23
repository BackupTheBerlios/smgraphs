grammar Mish;
 
options
{
    //language=CSharp2;
    language=Java;
    output=AST;
}
comment 	:
		(LINE_COMMENT | COMMENT)+		
	;
statement
	:
		 //LINE_COMMENT
	;
WS  :  (' '|'\r'|'\t'|'\u000C'|'\n') //{$channel=HIDDEN;}
    ;

COMMENT
    :   '/*' ( options {greedy=false;} : . )* '*/' //{$channel=HIDDEN;}
    ;

LINE_COMMENT
    : 
    '//' 
    ~('\n'|'\r')*
    ('\r'?'\n' | EOF) //{$channel=HIDDEN;}
    ;

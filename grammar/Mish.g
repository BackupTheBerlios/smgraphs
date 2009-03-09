grammar Mish;

options {
    language=CSharp2;
}

NEWLINE : '\r'?'\n' ;
WS : (' '|'\t'|'\n'|'\r')+ {skip();} ;

grammar pgn;

// PARSER

pgn_info:
    (info)*
;

info:
    LBRACE attrs STRING_VALUE RBRACE
;

attrs:
    EVENT | SITE | DATE | ROUND
    | WHITE | BLACK | WHITEELO | BLACKELO | WHITETITLE | BLACKTITLE
    | RESULT | GAMEID | VARIANT | TIMECONTROL | ECO | OPENING | TERMINATION | ANNOTATOR
;

// LEXER

EVENT : 'Event' ;
SITE : 'Site' ;
DATE : 'Date' ;
ROUND : 'Round' ;

WHITE : 'White' ;
BLACK : 'Black' ;
WHITEELO : 'WhiteElo' ;
BLACKELO : 'BlackElo' ;
WHITETITLE : 'WhiteTitle' ;
BLACKTITLE : 'BlackTitle' ;

RESULT : 'Result' ;
GAMEID : 'GameId' ;
VARIANT : 'Variant' ;
TIMECONTROL : 'TimeControl' ;
ECO : 'ECO' ;
OPENING : 'Opening' ;

TERMINATION : 'Termination' ;
ANNOTATOR : 'Annotator' ;

LBRACE : '[' ;
RBRACE : ']' ;

STRING_VALUE : '"' (~["\\] | '\\' .)* '"' ;

ANALYSIS : '{' [.] '}' -> skip ;

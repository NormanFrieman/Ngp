grammar Pgn;

// PARSER

pgn_info:
    (info)*
;

info:
    LBRACE attrs STRING_VALUE RBRACE
;

attrs:
    EVENT
    | SITE
    | DATE
    | ROUND
    | WHITE
    | BLACK
    | WHITEELO
    | BLACKELO
    | WHITETITLE
    | BLACKTITLE
    | RESULT
    | GAMEID
    | VARIANT
    | TIMECONTROL
    | ECO
    | OPENING
    | TERMINATION
    | ANNOTATOR
    | WHITEFIDEID
    | BLACKFIDEID
    | STUDYNAME
    | CHAPTERNAME
    | UTCDATE
    | UTCTIME
    | GAMEURL
;

// LEXER

WS : [ \t\r\n]+ -> skip ;

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

WHITEFIDEID : 'WhiteFideId' ;
BLACKFIDEID : 'BlackFideId' ;

STUDYNAME : 'StudyName' ;
CHAPTERNAME : 'ChapterName' ;

UTCDATE : 'UTCDate' ;
UTCTIME : 'UTCTime' ;
GAMEURL : 'GameURL' ;

LBRACE : '[' ;
RBRACE : ']' ;

STRING_VALUE : '"' (~["\\] | '\\' .)* '"' ;

ANALYSIS : '{' [.] '}' -> skip ;

MOVES : [0-9]+ '.' .*? ( '1-0' | '0-1' | '1/2-1/2' | '*' ) -> skip ;

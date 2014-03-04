\ base64.fs
\ Copyright 2014 David J. Goehrig
 
: b64-cypher s" ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=" ;

0 value b64-source
0 value b64-length
0 value b64-offset
0 value b64-mask

: b64-more b64-offset b64-length < ;
: b64-pad 64 ;

: b64-mod0 b64-length 3 mod 0= b64-length b64-offset > or ;
: b64-mod1 b64-length 3 mod 1 = b64-length b64-offset = and ;
: b64-mod2 b64-length 3 mod 2 = b64-length b64-offset = and ;

: b64-current ( -- c c ) b64-more if b64-source b64-offset dup 1+ to b64-offset + c@ dup else 0 0 then ;

: b64-c0 b64-current 3 and 4 lshift to b64-mask $FC and 2 rshift ;

: b64-c1 b64-current $0F and 2 lshift >R $F0 and 4 rshift b64-mask or R> to b64-mask ;

: b64-c2 b64-mod1 if b64-pad else b64-current $3F and >R $C0 and 6 rshift b64-mask or R> to b64-mask then ;

: b64-c3 b64-mod0 if b64-mask else b64-pad then ;

: base64 ( a n --) to b64-length to b64-source 0 to b64-offset 0 to b64-mask ;

: b64-emit b64-cypher drop + c@ emit ;

: b64# b64-c0 b64-emit b64-c1 b64-emit b64-c2 b64-emit b64-c3 b64-emit  ;

: encode b64-length 2 + 3 / 1 max 0 do b64# loop ;

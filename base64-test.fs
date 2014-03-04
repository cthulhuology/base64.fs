include base64.fs

: test0-str s"  " ;		: test0-code ." IA==" ;
: test1-str s" a" ;		: test1-code ." YQ==" ;
: test2-str s" ab" ;		: test2-code ." YWI=" ;
: test3-str s" abc" ;		: test3-code ." YWJj" ;
: test4-str s" abcd" ;		: test4-code ." YWJjZA==" ;
: test5-str s" abcde" ;		: test5-code ." YWJjZGU=" ;
: test6-str s" abcdef" ;	: test6-code ." YWJjZGVm" ;

: test0 test0-str base64 encode ."  " test0-code ;
: test1 test1-str base64 encode ."  " test1-code ;
: test2 test2-str base64 encode ."  " test2-code ;
: test3 test3-str base64 encode ."  " test3-code ;
: test4 test4-str base64 encode ."  " test4-code ;
: test5 test5-str base64 encode ."  " test5-code ;
: test6 test6-str base64 encode ."  " test6-code ;
	

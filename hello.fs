\ Hello World in Forth
\ This implementation uses standard Forth words for maximum compatibility

: HELLO   ( -- )
    ." Hello, World!" CR ;  \ Print message and add carriage return

HELLO  \ Execute the word when the program runs
BYE    \ Exit the Forth system

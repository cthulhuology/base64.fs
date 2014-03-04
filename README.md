base64.fs
-----------

A Portable Base64 encoder implementation in Forth


Getting Started
---------------

To add to your gforth project

	include base64.fs
	s" abc" base64 encode

Which will print out the base64 encoded string.  

About
-----

This implementation is based on 

	http://tools.ietf.org/html/rfc1521.html#page-21

Little effort has been put into optimizing the forth, and even less for speed.

Complaints & Bug Fixed
----------------------

Please send any complaints or patches to:

	David Goehrig <dave@dloh.org>

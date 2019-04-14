# CosmosDB Query App for Windows

Simple Windows Forms app for running CosmosDB queries (I haven't done much client side work in a decade - WinForms is what I know - don't h8)

Load in Visual Studio, press F5, enter the connection info and query away. It doesn't handle paging or continuation or updates, just simple queries.

It only runs one query at a time, so submit separately (it executes the selected text, so you can have multiple queries in the query window)

Cross partition is on by default and max docs is set to 2000. Configurable parametes would be nice ...

Bugs and contributions welcome (it does what I need it to do, so probably won't spend much time on it)

## Security Notice

If you choose to save your credentials, they are currently saved in PLAIN TEXT in your c:\users\userName\coquery.dat file

I plan to add the concept of "login profiles" and encrypt the data on disk, but currently, it's plain text.


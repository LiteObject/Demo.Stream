# Streams in C#
* **Stream** is the abstract base class of all streams. 
* A stream is an abstraction over a sequence of bytes.
* Streams are classified as either __byte streams__ or __character streams__.
* Streams involve three fundamental operations:
  - **You can read from streams.** Reading is the transfer of data from a stream into a data structure, such as an array of bytes.
  - **You can write to streams.** Writing is the transfer of data from a data structure into a stream.	
  - **Streams can support seeking.** Seeking refers to querying and modifying the current position within a stream. 
## Some of the classes
* Byte streams
  - FileStream
  - MemoryStream
  - BufferedStream
* Character streams
  - TextReader
  - TextWriter
  - StreamReader
  - StreamWriter

## What is a buffer?
>A buffer represents a block of bytes in memory where you can temporarily store transient data. 

>A buffer helps in minimizing the number of calls your application makes to read and write data from and to the file system.

## MemoryStream vs BufferedStream

__BufferedStream__  is a class that provides buffering functionality to improve the 
performance of read and write operations on other streams.

__MemoryStream__ is a class that represents a stream backed by a block of memory, 
allowing you to read from or write to the memory as if it were a stream.

---
## Links
* [Stream Class](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-7.0)

TemplateCS
==========

This repository contains boilerplate C# code for various algorithmic programming
competitions. Right now, [Google Code Jam](https://code.google.com/codejam) and
[Codeforces](http://codeforces.com/) are the intended use cases, though the
Codeforces mode should be suitable for many other competitions as well.

The boilerplate code mainly helps with these things:

1. Input and Output. There are functions for reading input in various forms
with minimal pain. For Google Code Jam, the handling of input and output files
is done so that only a single test case has to be considered by the programmer
at any point.

2. Rapid brute force. Numerous methods and extension methods are provided that
enable quickly iterating over the problem space of a given task. These include
simple functions such as generating all combinations and permutations of a
collection but also slightly more advanced operations such as a rather versatile
method for generating cartesian products.

3. Common patterns. Some rather common patterns which can be factored out, such
as memoization, have been put into respective functions.

The point of this template code is that using this code together with LINQ
should enable a programmer to directly express their ideas and algorithms
in code without having to think about details like how to generate all subsets
of a set. Especially brute force solutions can usually be implemented using
this code in just one or two lines of code that generate all possible states
combined with a short verification function, which can all be chained together
using LINQ.

The code requires a compiler/environment which can handle C# 6, such as Visual
Studio 2015.

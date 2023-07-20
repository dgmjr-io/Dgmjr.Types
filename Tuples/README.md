---
authors:
  - dgmjr
date: 2023-07-20T07:59:29.564Z
description: This package contains a couple of tuple values which I may or may not use in the future.
keywords:
  - data-types
  - tuples
  - types
lastmod: 2023-07-20T08:03:54.083Z
license: MIT
project: types
slug: tuples
title: Tuples
type: readme
version: 0.0.1
---

# Tuples

This package contains a couple of tuple values which I may or may not use in the future. 

## [UriDescriptionTuple](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Tuples/UriDescriptionTuple.cs)

The UriDescriptionTuple class is a tuple that represents a URI and a description of the URI. It inherits from the UriStringTuple class, which represents a URI and a value.

The UriDescriptionTuple class has two constructors:

* A constructor that takes a URI and a description as parameters.
* A constructor that takes a UriStringTuple as a parameter.

The UriDescriptionTuple class also has two properties:

* A property that gets the URI.
* A property that gets the description.

The UriDescriptionTuple class also implements the Equals and GetHashCode methods.

## [UriStringTuple](https://github.com/dgmjr-io/Dgmjr.Types/blob/main/Tuples/UriStringTuple.cs)

The UriStringTuple class is a tuple that represents a URI and a value. It has two constructors:

* A constructor that takes a URI and a value as parameters.
* A constructor that takes a UriStringTuple as a parameter.

The UriStringTuple class also has two properties:

* A property that gets the URI.
* A property that gets the value.

The UriStringTuple class also implements the Equals and GetHashCode methods.

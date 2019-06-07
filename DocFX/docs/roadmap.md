# Roadmap
Slipe is currently in alpha stage. This means that we have implemented (almost) all MTA classes, elements, functions and events but we cannot guarantee that there are no issues in the code. Using Slipe and submitting issues on GitHub helps us tremendusly in moving from the alpha phase. 

## Current plans
Our current plans are to expand the slipe core library in order to cover all current MTA functions in a nice and object oriented way. 

## Modules
We are eager to build some first-party modules for Slipe. Anyone can build their own modules and distribute it as they wish. We have a few ideas for modules we are interested in providing:

 - An Object Relation Model (ORM) for Slipe; Map your database tables to classes and don't worry about SQL queries anymore.
 - WPF to CEGUI & CEF converter. Build both CEGUI and CEF windows in WPF using Visual Studio and increase the speed at which you build user interfaces due to WYSIWYG.
 - A runtime class inspector. As a debug helper we want to provide functionality to browse through your class trees and check their properties during runtime.
 - Async/await based RPC's.
 - Server RPC based wrappers for client.

## Examples
We are also working on adding more examples of Slipe to inspire more people to use it. One of these examples we're working on is a [Race gamemode](https://github.com/mta-slipe/Slipe-race)
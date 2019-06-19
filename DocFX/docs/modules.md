# Modules

## What is a module?
The term "Module" in Slipe is a collection of code which can be easily shared with other Slipe users, much like NuGet packages.  

## Using a module
In order to add a Module to your project you can use the `slipe import-module` command. You can specify either a filepath to a .zip file containing the module, or a url to a download for said zip file.  
This should create a directory with the module in `Modules/{moduleName}` (unless otherwise specified using `-directory`).  
When you compile the project the code from this module will run as well.  

### Using a module's C# classes in a project
In order to use any C# classes/methods defined in the Module you will need to add the .dll file as reference to the project in Visual Studio.  
- Right click project
- Add > Reference
- Click "Browse" at the bottom of the window
- Navigate to the module's DLL folder
- Select all applicable DLLs and click ok
- Make sure the applicable DLLs are checked and click ok

## Creating a module
If you wish to create a module you can do this simply be using the `slipe create-module {name}` command. This will create a new directory in the `Modules/{name}` directory.

## Publishing a module

## Writing a module
Besides writing C# classes for others to use you can also write Lua in your modules. 

### C#
The C# classes written in your Module behave just like they normally do. Any `public` classes will be accesible to the consumers of your module.

### System components
System components are implementations of C# Classes and methods. Slipe already supports a relatively large number of these, but a module can define more of them. In order to do so you create only the Lua implementation of these classes. Examples of system components can be found [on github](https://github.com/mta-slipe/Slipe-Core/tree/master/Slipe/Core/Lua/SystemComponents).

### Backing Lua
Besides writing Lua for existing C# classes you can also write Lua code manually for your own C# classes. This is usually done when you want to expose native Lua (or MTA Lua) functions to C#. This requires you to define the classes and methods in C#, but these can be empty (or `throw new NotImplementedException()`). You will then need to manually implement these classes in Lua.  
An example of this is the [Database class](https://github.com/mta-slipe/Slipe-Core/blob/master/Slipe/Core/Source/SlipeSql/Database.cs) ([Lua implementation](https://github.com/mta-slipe/Slipe-Core/blob/master/Slipe/Core/Lua/Backing/SlipeSql/Database.lua))

## .slipe file
When using System components or backing Lua in your module you need to manually add these files to the appropriate part in the `.slipe` file. The `.slipe` file is a json file so you can modify this with any text editor. The order of these files in the `.slipe` file is the order they will be placed in the meta.xml, and loaded. So it is important for dependecies to be loaded before dependents. 


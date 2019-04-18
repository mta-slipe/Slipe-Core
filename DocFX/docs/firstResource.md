# Creating your first resource

## Prerequisites
You will need to have installed the Slipe CLI in order to compile your resources. If you have not done so please follow the instructions in [Getting started](/docs/installation.html)

## Creating a resource
After installing the CLI tool in the previous step you are now ready to start working on your first resource.

- Navigate to your `resources` folder in your MTA server directory
- Open a command prompt
- Run `slipe new <resourceName>`

Afterwards a directory with the name you entered will be created.  
This directory will contain a Visual Studio Solution (`.sln` file). Once you open this file you will encounter two projects, `ServerSide` and `ClientSide`. These are compiled to server scripts and client scripts respectively. 

## Compiling a resource
A resource can be compiled in one of several ways, if you're not using Visual Studio this will require using the command line.

#### Visual Studio
When you open your solution (`.sln` file) in Visual Studio it contains 2 projects. `ServerSide` and `ClientSide`, both of these projects will compile to Lua when you build them using Visual Studio's build action.  
Furthermore starting the project will attempt to restart the resource on your MTA server (if it is already running)

#### Commandline
In order to compile from the command line, use the `slipe compile` command.

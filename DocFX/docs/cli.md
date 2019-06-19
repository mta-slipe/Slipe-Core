# Slipe CLI

## What is Slipe CLI?
The Slipe CLI is the command line interface tool you can use to manage and compile your project. If you have not yet installed it please follow the instructions in [Installation](/docs/installation.html).

The CLI has various tasks, like managing your project, but also compiling it and generating your `meta.xml` file

## How to use
In order to use the CLI you have to open a command prompt or terminal, from there you can use the `slipe` command.  

## General commands
The following commands can be executed anywhere on your system  

- **Create a project**  
In order to create a new slipe resource use the `slipe new` command, this command is best executed in the `resources` directory of your mta server.  
Syntax: `slipe new {project-name}`  
Example: `slipe new testProject`
- **Update the CLI**  
In order to update the CLi run the `slipe update` command.  
Syntax: `slipe update`
- **Run build webhook**  
For more information on the build webhook visit [the webhook docs](/docs/webhook.html)

## Resource specific commands
The following commands need to be run in a slipe resource directory. (A directory created with `slipe new`)

### General commands

- **Compile your project**  
In order to compile your project's C# code to Lua use the `slipe compile` command. This command also runs the `meta-generate` command.  
Syntax: `slipe compile [-server-only] [-client-only] [-module moduleName] [-exports]`  
Example: `slipe compile -server-only -exports`  
When using the `-exports` option the entire project will be scanned for any exported functions.

- **Build your project for deployment**  
In order to build your project for deployment on a live server use the `slipe build` command. This will generate a built version of the resource without any of the unnecesary files to run the resource on MTA. (Like the DLLs and C# source code). You can also optionally compile the Lua code using luac.mtasa.com by using the `luac` option  
Syntax: `slipe build [-luac] [-directory {directory}]`  
Example: `slipe build -luac`

- **Generate your meta.xml**  
In order to generate your meta.xml from your existing code use `slipe meta-generate`.   
Syntax: `slipe meta-generate`  

- **Restart your resource**  
**NOTE: This command only works on windows**  
In order to restart your resource on the MTA server use `slipe restart-resource`. This command is used in the default project setup to restart the resource when running the project from Visual Studio.  
Syntax: `slipe restart-resource`  

- **Update slipe core**  
In order to update the Slipe core module (all of Slipe's wrapper classes) use the `slipe update-core` command.  
Syntax: `slipe update-core`

### Project commands
The following commands are used to manage the projects in your resource.

- **Create a new C# Project in your resource**  
In order to create another C# project in the current resource use the `slipe create-project` command.  
Syntax: `slipe create-project {project-name} [-server] [-client] [-module moduleName]`  
Example: `slipe create-project SharedProjectSample -server -client`  

- **Delete an existing C# project from your resource**  
In order to delete a C# project use the `slipe delete-project` command  
Syntax: `slipe delete-project {project-name} [-server] [-client] [-module moduleName]`  
Example: `slipe delete-project SharedProjectSample -server -client`  

### Asset commands
The following commands are used to manage the asset directories in your resource. Asset directories are directories of which the files will be added to the `meta.xml` as `<file>` tags when running `slipe meta-generate`.

- **Add an asset directory**  
In order to add an asset directory use `slipe add-assets`  
Syntax: `slipe add-assets {directory-path} [-no-download] [-module moduleName]`  
Example: `slipe add-assets Assets -no-download`  
The `no-download` option will mark the `<file>` elements in the `meta.xml` as `download=false`

- **Remove an asset directory**
In order to remove an asset directory use `slipe remove-assets`   
Syntax: `slipe remove-assets {directory-path} [-module moduleName]`   
Example: `slipe remove-assets Assets`

### Module commands
The following commands are used to manage the modules in your resource. Modules are a set of C# projects which are compiled seperately from your main resource, these can be individually compiled.  

- **Creating a module**  
In order to create a new module use the `slipe create-module` command.  
Syntax: `slipe create-module {module-name} [-directory {directory}]`  
Example: `slipe create-module TestModule`  
The `directory` option allows you to specify a specific directory, by default the directory will be `Modules/{module-name}`

- **Deleting a module**
In order to delete a module use the `slipe delete-module` command. **This will delete the files** 
This command will ask for confirmation, if you wish to skip this use the `-y` option  
Syntax: `slipe delete-module {module-name} [-y]`  
Example `slipe delete-module TestModule`  

- **Remove a module**
In order to remove a module from your project but not delete the files use the `slipe remove-module` command.  
Syntax: `slipe remove-module {module-name}`  
Example: `slipe remove-module TestModule`

- **Export a module**  
In order to export a module you have created in order to share it with the world use the `slipe export-module` command.  
Syntax: `slipe export-module {module-name} [-directory {directory}] [-zip]`  
Example: `slipe export-module TestModule -zip`

- **Import a module**  
In order to import a module from a .zip file use the `slipe import-module` command.  
Syntax: `slipe import-module {filepath / url} [-directory {directory}]`  
Example: `slipe import-module ./TestModule.zip`  
Example: `slipe import-module https://mta-slipe.com/TestModule.zip`

- **Update a module**  
In order to update a module use the `slipe update-module` command.  
Syntax: `slipe update-module {filepath / url}`  
Example: `slipe update-module ./TestModule.zip`  
Example: `slipe update-module https://mta-slipe.com/TestModule.zip`

## Running development builds
By default the `slipe update` and `slipe update-core` commands will update to the latest release build of Slipe.
If you however wish to use a current work in progress development build you can use the `-dev` option with either of these commands.  
Do note that you could run into issues in development builds which are not present in release builds.
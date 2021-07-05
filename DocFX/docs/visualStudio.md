# Visual Studio
Visual Studio is Microsoft's IDE, suitable for many frameworks and programming languages. We recommend using Visual Studio for your slipe project.

If you want to use Visual Studio for slipe you will need the 2019 version, the community edition is available for free at [visualstudio.microsoft.com](https://visualstudio.microsoft.com/downloads/).

## Opening the resource
When you've created a slipe resource using the CLI the resource directory will contains a `.sln` file, open this file in Visual Studio.
You should now see a 'solution explorer' window on your screen which looks like this:
<img src="/images/visualStudio/solutionExplorer.png"/>

## Projects
The Solution explorer contains two projects by default, `ServerSide` and `ClientSide` these represent the code that's run on your server and the game clients respectively.

### Creating projects

You can add more projects using the `slipe create-project` command as described in the [CLI docs page](/docs/cli.html#general-commands). When running the command: `slipe create-project ServerLib -server` your solution explorer window should look like this:  
<img src="/images/visualStudio/solutionLibrary.png">

### Referencing projects

You can start writing code in this newly created project, however in order to use classes from `ServerLib` in `ServerSide` you need to reference it.

In order to do so right click on `Dependencies` in the `ServerSide` project, and choose `Add reference`.  
<img src="/images/visualStudio/addReference.png">

On the left make sure to select `Project`, and then tick the checkbox for the `ServerLib` project.  
<img src="/images/visualStudio/referenceManager.png">

You should now be able to use classes from the `ServerLib` project in `ServerSide` as long as the class is marked as `public`.

## Building
There are several ways to build a project, you can right click the project in the soltion explorer, and click `Build`.  
<img src="/images/visualStudio/buildContext.png">

You could also use the `Build` menu at the top of the window. The build shortcuts will also be displayed here. The available options in this menu will change depending on which file you have open.  
<img src="/images/visualStudio/buildMenu.png">

When you build the `ServerSide` or `ClientSide` projects Visual Studio will automatically trigger the `slipe compile` command for you, and compile the C# code to Lua. This also will generate your `meta.xml` file.

## Running
At the top of the window there will be a green play button.   
<img src="/images/visualStudio/debug.png">

Clicking this button will build your project, and attempt to restart the resource on your server. This is done by typing `restart {directory-name}` in the server console. This means if the resource is not running, or slipe can't find the server console this will fail. If this fails you can still manually restart the resource on your server.

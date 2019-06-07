# Slipe Webhook

## What is the Slipe webhook ?
The slipe webhook is a way to automatically compile and build a slipe resource in response to a web request. You could use this to automatically deploy your code on a server when you commit to a git(hub) repo for example.  

The hook is primarily built for use with GitHub's push webhooks. But they can be used with anything that calls a web request.

## Prerequisites
* In order to use the webhook it is required that the git repo is cloned on the system.
* Slipe CLI has to be installed
* .net core 2.0 has to be installed (in addition to the 3.0 preview)    
    (This is done by default if you have Visual Studio, but in the case of a deployment server you likely will not have Visual Studio installed)

## How to use
The Slipe webhook can be started by using the `slipe hook` command.  
Syntax: `slipe hook [-sourceDirectory {path}] [-targetDirectory {path}] [-domain {domain}] [-port {port}] [-repo {repo name}] [-branch {branch ref}] [-luac] [-no-github] [-no-pull] [-no-queue] [-postbuild {command}] [-failbuild {command}]`  
The options represent the following:  
* `-sourceDirectory {path}`  
    the root directory of the slipe project to build  
    Default: `./`
* `-targetDirectory {path}`  
    the directory the built project is placed in
* `-domain {domain}`  
    the domain name or IP the hook is to be accessed by   
    Default: `127.0.0.1`
* `-port {port}`  
    the port the hook is to be accessed on  
    Default: `80`
* `-repo {repo name}`  
    name of the git repo pushes that trigger the build (When using GitHub)
* `-branch {branch}`  
    branch ref of the git repo pushes that trigger the build (when using github)  
    Default: `/refs/heads/master`
* `-luac`  
    Compiles the built project using luac.mtasa.com
* `-no-github`  
    Ignores the payload of the HTTP request (-`repo` and `-branch` are also ignored)
* `-no-pull`  
    Does not perform a `git pull` in the source directory when called (Useful in case you already have a system that pulls the latest version of the source code)
* `-no-queue`  
    Does not start a new build if one is requested whilst build is in progress
* `-postbuild {command}`  
    Runs the specified command when a build successfully runs.
* `-failbuild {command}`   
    Runs the specified command when a build fails to run.

Example: `slipe hook -domain 127.0.0.1 -port 666 -sourceDirectory /var/mta/repos/Slipe-Race/ -outputDirectory /var/mta/server/mods/deathmatch/resources/Slipe-Race -repo Slipe-Race -branch refs/heads/master`

## Queueing    
There can only be one build running per hook at once. If a build is already in progress when a new build is requested, then the new build is queued for when the current build is finished. If the `-no-queue` option is used this is ignored and no new build will be started.

## Result HTTP status codes
Here's a run down of all HTTP status codes the hook can possibly return:
* `201 Created`   
    A 201 status code is returned when the build has been queued
* `202 Accepted`  
    A 202 status code is returned when the build has started
* `204 No content`  
    A 204 status code is returned when the branch or repo do not match
* `429 Too many requests`   
    A 429 status code is returned when `-no-queue` is used and there is already a build in progress
* `500 Internal server error`   
    A 500 status code is returned when an unexpected exception is thrown. This either means a malformed JSON or a bug.

## Multiple projects
The webhook can only handle a single project, however you can run multiple hooks on different ports in order to compile different projects.

### On one port
If you wish to run multiple webhooks on the same port one way to do so would be using a "reverse proxy".   
An example of software which can be used to run a reverse proxy is nginx. You can set up Nginx to proxy calls on a certain domain or url to the slipe hook server.

The following is a sample configuration for how you could do this in nginx:
```
server {
    listen 80;

    server_name domain.com;

    location / {
        proxy_pass http://127.0.0.1:666;
    }
}
```
In this case you would set the `-domain` option to `127.0.0.1` and `-port` to 666



---
title: Welcome to DocFX website!
documentType: index
---
<div class="hero">
  <div class="wrap">
    <div class="col-lg-offset-2 col-lg-4 col-sm-offset-1 col-sm-4 col-xs-12">
      <img class="hero-image" src="images/logo_large.png">
    </div>
    <div class="media-icons col-lg-4 col-sm-6 col-xs-12">
        <a href="https://github.com/mta-slipe" target="_blank"><i class="fab fa-github"></i></a>
        <a href="http://discord.gg/T4gkRFV" target="_blank"><i class="fab fa-discord"></i></a>
        <a href="https://trello.com/b/EK50dT1g/slipe" target="_blank"><i class="fab fa-trello"></i></a>
    </div>
    <div class="col-lg-4 col-sm-6 col-sm-12 col-xs-12">
      <h1 class="title main-title">Slipe</h1>
      <h3 class="title sub-title">Sharpen your MTA development experience</h3>
      <div class="buttons-unit">
          <a href="tutorial/gettingStarted.html" class="button b-1"><i class="glyphicon glyphicon-chevron-right"></i>Getting Started</a>
          <a href="https://github.com/mta-slipe/Slipe-CLI/releases" target="_blank" class="button b-2"><i class="glyphicon glyphicon-download-alt"></i>Download Latest</a>
      </div>
    </div>
  </div>
</div>

<div class="container">
  <div class="wrap row main-info">
      <div class="col-md-4 col-md-offset-0 col-xs-offset-1 col-xs-10">
        <h3>Slipe-CLI</h3>
        <p>
          A command line interface to streamline your project and directory management. Enables you to create, compile and build your projects with just a few keystrokes.
        </p>
        <p>
          The CLI takes care of invoking the proper compilation commands and it also automatically rebuilds your meta. If you want to build your project for development, it can also compile the Lua code further using <a href="https://luac.mtasa.com/" target="_blank">MTA .Luac</a>!
        </p>
      </div>
      <div class="col-md-4 col-md-offset-0 col-xs-offset-1 col-xs-10">
        <h3>Slipe-Core</h3>
        <p>
          The framework enables you to write scripts for <a href="https://mtasa.com/" target="_blank">MTA San Andreas</a> in C# instead of Lua, wrapping all MTA elements and classes. It also includes some <a href="https://dotnet.microsoft.com/" target="_blank">.NET Core</a> namespaces.
        </p>
        <p>
          Slipe enables you to make use of the full power of C#. This includes but is not limited to: type safety, inheritance, async/await and method overloading
        </p>
        <p>
          Build your projects in <a href="https://visualstudio.microsoft.com/" target="_blank">Visual Studio</a>, and let <a href="https://visualstudio.microsoft.com/services/intellicode/" target="_blank">IntelliSense</a> increase your productivity even more!
        </p>
      </div>
      <div class="col-md-4 col-md-offset-0 col-xs-offset-1 col-xs-10">
        <h3>Slipe Modules</h3>
        <p>
          Export your project as a module to enable it for use in other projects as well. Zip your project or put it in a repository to autimatically import it in any project with a CLI command.
        </p>
        <p>
          Also take a look at the available slipe modules!
        </p>
      </div>
  </div>
</div>

<section class="example-section">
  <div class="container">
    <div class="example-block-container">
        <div class="row">
          <div class="col-md-8">
            <pre>
            <code class="lang-csharp">
// A vehicle with super powers
public class <i id="e1" onmouseenter="document.getElementById('i1').className = 'forceHover';" onmouseleave="document.getElementById('i1').className = '';">SuperVehicle : Vehicle</i>
{
    // The team that this vehicle is locked to
    <i id="e2" onmouseenter="document.getElementById('i2').className = 'forceHover';" onmouseleave="document.getElementById('i2').className = '';">public <span class="hljs-title">Team</span> Team { get; }</i>
    <span></span>
    // Create a new super vehicle locked to a team
    <i id="e3" onmouseenter="document.getElementById('i3').className = 'forceHover';" onmouseleave="document.getElementById('i3').className = '';">public SuperVehicle</i>(<span class="hljs-title">VehicleModel</span> <span class="hljs-variable">model</span>, <span class="hljs-struct">Vector3</span> <span class="hljs-variable">position</span>, <span class="hljs-title">Team</span> <span class="hljs-variable">team</span>) 
      : base(<span class="hljs-variable">model</span>, <span class="hljs-variable">position</span>)
    {
        Team = <span class="hljs-variable">team</span>;
        DamageProof = true;
        <i id="e4" onmouseenter="document.getElementById('i4').className = 'forceHover';" onmouseleave="document.getElementById('i4').className = '';">Handling.MaxVelocity = <span class="hljs-number">300f</span></i>;
        <span></span>
        // If a player wants to enter the driver seat. 
        // He should be of the right team.
        <i id="e5" onmouseenter="document.getElementById('i5').className = 'forceHover';" onmouseleave="document.getElementById('i5').className = '';">OnStartEnter += (<span class="hljs-title">Player</span> <span class="hljs-variable">player</span>, <span class="hljs-enum">Seat</span> <span class="hljs-variable">seat</span>, <span class="hljs-title">Player</span> <span class="hljs-variable">jacked</span>, <span class="hljs-enum">Door</span> <span class="hljs-variable">door</span>) =></i>
        {
            if (<span class="hljs-variable">seat</span> == <i id="e6" onmouseenter="document.getElementById('i6').className = 'forceHover';" onmouseleave="document.getElementById('i6').className = '';"><span class="hljs-enum">Seat</span>.FrontLeft</i> && <span class="hljs-variable">player</span>.Team != <span class="hljs-variable">team</span>)
            <span class="hljs-title">Event</span>.<span class="hljs-method">Cancel</span>();
        };
    }
    <span></span>
    // Have an AK-47 drop on the ground 3 units behind this vehicle
    public void <i id="e7" onmouseenter="document.getElementById('i7').className = 'forceHover';" onmouseleave="document.getElementById('i7').className = '';"><span class="hljs-method">DropWeapon</span>()</i>
    {
      <i id="e8" onmouseenter="document.getElementById('i8').className = 'forceHover';" onmouseleave="document.getElementById('i8').className = '';"><span class="hljs-struct">Vector3</span> <span class="hljs-variable">position</span> = Position <span class="hljs-method">+</span> ForwardVector <span class="hljs-method">*</span> <span class="hljs-number">-3</span></i>;
      new <span class="hljs-title">Pickup</span>(<span class="hljs-variable">position</span>, <span class="hljs-title">SharedWeaponModel</span>.Ak47);
    }
}
              </code>
            </pre>
          </div>
          <div class="col-md-4">
            <h3>Take advantage of C#!</h3>
            <p class="side-info">Slipe core is a complete wrapper of all the native MTA functions. The benefits of using C# in combination with Visual Studio are innumerable. Everything that works in C# works in Slipe. Take a look:</p>
            <ul class="side-info">
              <li id="i1" onmouseenter="document.getElementById('e1').className = 'forceHover';" onmouseleave="document.getElementById('e1').className = '';">Inheritance from base MTA classes</li>
              <li id="i2" onmouseenter="document.getElementById('e2').className = 'forceHover';" onmouseleave="document.getElementById('e2').className = '';">Manage access with properties</li>
              <li id="i3" onmouseenter="document.getElementById('e3').className = 'forceHover';" onmouseleave="document.getElementById('e3').className = '';">Typesafe constructors, methods and properties</li>
              <li id="i4" onmouseenter="document.getElementById('e4').className = 'forceHover';" onmouseleave="document.getElementById('e4').className = '';">Numerous data wrappers</li>
              <li id="i5" onmouseenter="document.getElementById('e5').className = 'forceHover';" onmouseleave="document.getElementById('e5').className = '';">Both lambda event handlers and delegates</li>
              <li id="i6" onmouseenter="document.getElementById('e6').className = 'forceHover';" onmouseleave="document.getElementById('e6').className = '';">Complete integration of all constants as enums</li>
              <li id="i7" onmouseenter="document.getElementById('e7').className = 'forceHover';" onmouseleave="document.getElementById('e7').className = '';">Method overloading</li>
              <li id="i8" onmouseenter="document.getElementById('e8').className = 'forceHover';" onmouseleave="document.getElementById('e8').className = '';">Use System.Numerics and other powerful .NET libraries</li>
            </ul>
          </div>
        </div>
    </div>
  </div>
</section>

<section class="section-contributions">
  <div class="container">
    <div class="col-md-4">
      <h3>CSharp.lua</h3>
      <p>
        Slipe wouldn't exist without <a href="https://github.com/yanghuan/CSharp.lua" target="_blank">CSharp.lua</a>, the compiler that parses C# into Lua. CSharp.lua is built by <a href="https://github.com/yanghuan" target="_blank">Yang Huan</a> and he has been and still is a massive help during the development of Slipe, resolving issues within a matter of hours or overhauling his entire project by our request.
      </p>
      <p>
        Give <a href="https://github.com/yanghuan/CSharp.lua" target="_blank">CSharp.lua</a> a star if you can!
      </p>
    </div>
    <div class="col-md-8">
      <h3>Community</h3>
      <p>
        We are incredibly grateful for everyone who puts energy in making Slipe a bit better every day. This applies to our <a href="https://github.com/mta-slipe/Slipe-Core/graphs/contributors">GitHub contributors</a> but also everyone who is involved with the project on <a href="http://discord.gg/T4gkRFV" target="_blank">Discord</a>. Join the Slipe community and sharpen your MTA development experience!
      </p>
      <div class="col-sm-6 col-xs-12">
        <h4>Project Collaborators</h4>
          <ul>
            <li>Bob van Hooff - <a href="https://github.com/NanoBob" target="_blank">Nanobob</a></li>
            <li>Mathijs Sonnemans - <a href="https://github.com/DezZolation" target="_blank">DezZolation</a></li>
          </ul>
        <h4>Project Contributors</h4>
        <ul>
          <li><a href="https://github.com/4O4" target="_blank">404</a></li>
          <li><a href="https://github.com/Citizen01" target="_blank">Citizen</a></li>
        </ul>
      </div>
      <div class="col-sm-6 col-xs-12">
          <a href="https://github.com/mta-slipe" target="_blank"><i class="fab fa-github"></i></a>
          <a href="http://discord.gg/T4gkRFV" target="_blank"><i class="fab fa-discord"></i></a>
          <a href="https://trello.com/b/EK50dT1g/slipe" target="_blank"><i class="fab fa-trello"></i></a>
      </div>
    </div>
  </div>
</section>
<style type="text/css">
  footer{
    position: relative;
  }
</style>
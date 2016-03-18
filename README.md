# Unity3D DOTween Toolkit
This is a tiny series of elements to work with DOTween in Unity3d as commands.

##What are commands?
Commands are a design pattern introduced in the GoF book(Design Patterns - Elements of Reusable Object-Oriented Software).

As said in the book, a command object:
> Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and supportundoable operations.

##What is this toolkit?
These are some code I wrote for a project of mine, and specialized for Unity3d, and DOTween plugin for animations. 

There is an interface INBCommand, which is the base interface, and then there is an INBAnimationCommand interface, derived from INBCommand, to use for animation commands. and then there is an abstract class, Nb_Animation, implementing basic methods. Every animation command is a subclass of this class.

In Animations folder, there are animation commands, tiny pieces of code for different common animation commands usually needed in a project.

##Attention
This toolkit was written for a 2D app, so if you wanna use them in 3D, you have to change animation constructors to accept z element az well.

##So what is "NB" used in the name of files, anyway?
It's an abbr for the project I'm working on, and I'd be really happy if you change it in your code depending on your own project's name.

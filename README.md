This is an experimental ASP.NET MVC project used to demonstrate and experiment
with the concept of query objects as an alternative to the Repository pattern
and typical BLL/BOL/DAL architecture found in all too many .net projects.

The aim here is to demonstrate that you can have an architecture for your
project that is lightweight, adaptable and testable at the same time, while
avoiding most of the problems that the Repository pattern introduces, such as
Open/Closed Principle violations, `select n+1` bugs, and anaemic business
layer classes.

The Entity Framework DbContext is injected directly into your controllers using
StructureMap and query objects are instantiated automatically by the ASP.NET MVC
model binder.

For further information, see:

 * http://jamesmckay.net/2014/08/query-objects-a-better-approach-than-your-bllrepository/

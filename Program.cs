using EFCorePractice.Data;
using EFCorePractice.Entities;

using DataContext context = new DataContext();


// create

//try
//{
//    var actorOne = new Actor()
//    {
//        ActorName = "Walter White",
//        ActorGender = "male",
//    };


//    var actorTwo = new Actor()
//    {
//        ActorName = "Gustavo Fring",
//        ActorGender = "male",

//    };

//    var actorThree = new Actor()
//    {
//        ActorName = "Jesse Pinkman",
//        ActorGender = "male",

//    };

//    var actorFour = new Actor()
//    {
//        ActorName = "Tuko Salamanka",
//        ActorGender = "male",

//    };

//    var actorFive = new Actor()
//    {
//        ActorName = "Saul Goodman",
//        ActorGender = "male",

//    };


//    context.Actors.Add(actorOne);
//    context.Actors.Add(actorTwo);
//    context.Actors.Add(actorThree);
//    context.Actors.Add(actorFour);
//    context.Actors.Add(actorFive);
//    context.SaveChanges();

//    Console.WriteLine("Actors saved successfully");

//}

//catch (Exception e) {

//    Console.WriteLine(e.InnerException.Message);
//}

// read

try
{
    var actors = from actor in context.Actors
                 where actor.ActorId > 2
                 select actor;  
    foreach (var actor in actors) {
        Console.WriteLine($"{actor.ActorName}: {actor.ActorGender}");
    }
    Console.WriteLine("success");
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}
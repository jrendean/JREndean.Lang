

namespace JREndean.Lang.ConsoleSample
{
    using System;
    using System.IO;

    using JREndean.Lang;
    using JREndean.Lang.Extensions;

    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello there. What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
            Console.WriteLine("Would you like to play a game?");
            var answer = Console.ReadLine();
            if (answer == "yes")
            {
                RunGame();
            }
            else
            {
                Console.WriteLine("Ok, maybe next time. Good bye.");
            }




            
            Write.Text("Hello there. What is your name?").To.Screen();
            var usersName = Read.Text.From.Screen();
            Write.Text("Nice to meet you " + usersName.Results).To.Screen();
            Write.Text("Would you like to play a game?").To.Screen();
            var usersAnswer = Read.Text.From.Screen();
            If.Value(usersAnswer.Results).Equals("yes")
                .Then(i => RunGame())
                .Else(i => Write.Text("Ok, maybe next time. Good bye.").To.Screen());








            // big additions
            // Split.Text.On("")
            // Join.Text.With("");
            // Rename.File("").To("")
            // Move.File("").To("")
            // While.This(()=>{}).Is.[Not].True()
            // While.This(()=>{}).Is.[Not].False()
            // Copy...
            // Move...
            // Connect...
            


            //var wellKnowFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            //var wellKnownWebsiteRead = "http://www.microsoft.com";
            //var wellKnownWebsiteWrite = "";


            //var createTempFile = Path.GetTempFileName();
            //var createTempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            //// CREATE
            //Create.File(createTempFile);
            //Create.Folder(createTempFolder);

            //Create.File(createTempFile).Write("hello");
            //Create.File(createTempFile).Write(() => { return "world"; });
            //Create.File(createTempFile).Read(c => Console.WriteLine(c));

            //// DELETE
            //Delete.File(createTempFile);
            //Delete.Folder(createTempFolder);

            //Open.Twitter("");

            //// OPEN
            //// Open.
            //var openTempFile = Path.GetTempFileName();
            //Open.File(openTempFile).Read(c => Console.WriteLine(c));
            //Open.Website(wellKnownWebsiteRead).Read(c => Console.WriteLine(c));

            //Open.File(openTempFile).Write("hello");
            //Open.File(openTempFile).Write(() => { return "world"; });
            //Open.File(openTempFile).Read(c => Console.WriteLine(c));

            //// READ
            //var r1a = Read.Text.From.File("temp.txt").Results;
            //var r1b = Read.Text.From.File("temp.txt").Error((c, e) => { return "exception: " + e.Message; }).Results;
            //var r2 = Read.Text.From.Screen().Error((c, e) => { return "exception: " + e.Message; }).Results;
            //var r3 = Read.Text.From.Website(wellKnownWebsiteRead).Error((c, e) => { return "exception: " + e.Message; }).Results;
            //var r4 = Read.Key.From.Screen().Error((c, e) => { return "exception: " + e.Message; }).Results;

            //// WRITE
            //Write.Text("foo").To.File("temp.txt").Error(e => Console.WriteLine("exception: " + e.Message));
            //Write.Text("foo").To.Screen().Error(e => Console.WriteLine("exception: " + e.Message));
            //Write.Text("foo").To.Website(wellKnownWebsiteWrite).Error(e => Console.WriteLine("exception: " + e.Message));
            //Write.Text(() => { return "foo"; }).To.Screen().Error(e => Console.WriteLine("exception: " + e.Message));


            //// DO
            ////Do.This(...).5.Times()
            //Do.This(() => { }).Times(5);
            ////Do.This(...).While.This(...).Is.True
            ////Do.This(...).While.IsTrue(...)
            //Do.This(() => { }).While.True(() => { return true; });
            //Do.This(() => { }).While.False(() => { return false; });


            //// IF
            //If.Value("").Is.Empty().Then(value => { }).Else(value => { }).Error((v, e) => { });
            //If.Value("").Is.Not.Empty();
            //If.Value("").Is.Null();
            //If.Value("").Is.Not.Null();

            //If.Value(1).Is.GreaterThan(5);
            //If.Value(1).Is.GreaterThanOrEqual(5);
            //If.Value(1).Is.LessThan(5);
            //If.Value(1).Is.LessThanOrEqual(5);

            //If.Value("").Does.Contain("");
            //If.Value("").Does.Not.Contain("");

            //If.Value("").Is.Null().Throw(new ArgumentNullException());
            //If.Value("").Is.Null().Throw<ArgumentNullException>();

            //If.Argument("").Is.Empty().Then(value => { }).Else(value => { }).Error((v, e) => { });
            //If.This("").Is.Empty().Then(value => { }).Else(value => { }).Error((v, e) => { });

            //If.Value(() => { return ""; }).Is.Empty();



            //// FIND
            //// TODO: change .From() to .In()
            //var f1a = Find.Files.From(wellKnowFolder).Results;
            //var f1b = Find.Files.From(wellKnowFolder).Matching("*.txt").Results;
            //var f2a = Find.Folders.From(wellKnowFolder).Results;
            //var f2b = Find.Folders.From(wellKnowFolder).Matching("tmp").Results;

            //// LIST
            //var l1a = List.Files.From(wellKnowFolder).Results;
            //var l1b = List.Files.From(wellKnowFolder).Matching("*.txt").Results;
            //var l2a = List.Folders.From(wellKnowFolder).Results;
            //var l2b = List.Folders.From(wellKnowFolder).Matching("tmp").Results;



            //// PICK
            //// TODO: rethink this
            //// Pick.OneOf.From([]).When(...)
            //// Pick.SomeOf.From([]).When(...)
            //var p1 = Pick.From(new[] { "foo", "bar", "baz" }).When("foo");
            //var p2 = Pick.From(new[] { "foo", "bar", "baz" }).Where("foo");

            //var p3 = Pick.From<Foo>().When(Foo.Bar);
            //var p4 = Pick.From<Foo>().Where(Foo.Bar);


        }

        public enum Foo
        {
            Foo,

            Bar,

            Baz
        }


        private static void RunGame()
        {
            
        }
    }
}

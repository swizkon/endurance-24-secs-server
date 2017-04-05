namespace NancyApplication
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello World");
            
            Get("/about", _ => "This is the about page...");
        }
    }
}

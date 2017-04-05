namespace NancyApplication
{
    using Nancy;

    using Nancy.ModelBinding;

    using Endurance.Domain;
    using Endurance.Domain.Model;

    public class CircuitModule : NancyModule
    {
        public CircuitModule() : base("circuits")
        {
            Get("/list", args =>
            {
                var model = Repository.All();
                return Response.AsJson(model);
            });

            Get("/about", _ => "This is the about page...");

            Post("/create", args =>
            {
                var model = this.Bind<Circuit>();
                Repository.Add(model);
                return Response.AsJson(model);
            });
        }
    }
}

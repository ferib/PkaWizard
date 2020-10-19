using Nancy;
using Nancy.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PkaWizard
{
    public class NancyStuff : NancyModule
    {
        public NancyStuff()
        {
            Get("/", args =>
            {
                return View["Public/html/index.html"];
            });

            Get("/view", args =>
            {
                return View["Public/html/view.html"];
            });
        }
    }

    // Booststrap
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            nancyConventions.StaticContentsConventions.Clear();

            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("css", "/Public/css"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("img", "/Public/img"));

        }
    }
}

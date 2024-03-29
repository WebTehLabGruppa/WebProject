﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/fontawesome/css").Include(
                      "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/owlCarousel/css").Include(
                      "~/Vendor/OwlCarousel2-2.2.1/owl.carousel.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/owlCarouselTheme/css").Include(
                      "~/Vendor/OwlCarousel2-2.2.1/owl.theme.default.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/owlCarouselAnimate/css").Include(
                      "~/Vendor/OwlCarousel2-2.2.1/animate.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/mainstyles/css").Include(
                      "~/Vendor/main_styles.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/responsive/css").Include(
                      "~/Vendor/responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/videojs/css").Include(
                    "~/Vendor/video-js/video-js.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/blog/css").Include(
                   "~/Vendor/blog.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/blogresponsive/css").Include(
                   "~/Vendor/blog_responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/courses/css").Include(
                 "~/Vendor/courses.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/coursesresponsive/css").Include(
                 "~/Vendor/courses_responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/course/css").Include(
                "~/Vendor/course.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/courseresponsive/css").Include(
                 "~/Vendor/course_responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/blogsingle/css").Include(
                 "~/Vendor/blog_single.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/blogsingleresponsive/css").Include(
                 "~/Vendor/blog_single_responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/contact/css").Include(
                 "~/Vendor/contact.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/contactresponsive/css").Include(
                 "~/Vendor/contact_responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/instructors/css").Include(
                 "~/Vendor/instructors.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/instructorsresponsive/css").Include(
                 "~/Vendor/instructors_responsive.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/loginform/css").Include(
                 "~/Vendor/loginform.css", new CssRewriteUrlTransform()));




            bundles.Add(new Bundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new Bundle("~/bundles/jquery/js").Include("~/Scripts/jquery-3.7.0.min.js"));

            bundles.Add(new Bundle("~/bundles/owlcarousel/js").Include("~/Scripts/owl.carousel.js"));

            bundles.Add(new Bundle("~/bundles/custom/js").Include("~/Vendor/custom.js"));

            bundles.Add(new Bundle("~/bundles/easing/js").Include("~/Vendor/easing.js"));

            bundles.Add(new Bundle("~/bundles/popper/js").Include("~/Vendor/bootstrap4/popper.js"));

            bundles.Add(new Bundle("~/bundles/parallax/js").Include("~/Vendor/parallax-js-master/parallax.min.js"));

            bundles.Add(new Bundle("~/bundles/blog/js").Include("~/Vendor/blog.js"));

            bundles.Add(new Bundle("~/bundles/courses/js").Include("~/Vendor/courses.js"));

            bundles.Add(new Bundle("~/bundles/course/js").Include("~/Vendor/course.js"));

            bundles.Add(new Bundle("~/bundles/blogsingle/js").Include("~/Vendor/blog_single.js"));

            bundles.Add(new Bundle("~/bundles/contact/js").Include("~/Vendor/contact.js"));

            bundles.Add(new Bundle("~/bundles/contact/js").Include("~/Vendor/instructors.js"));

            bundles.Add(new Bundle("~/bundles/progressbar/js").Include("~/Vendor/progressbar/progressbar.min.js"));





        }
        public class Global: HttpApplication
        {
            void Application_Start(object sender, EventArgs e)
            {
                AreaRegistration.RegisterAllAreas();
                RouteConfig.RegisterRoutes(RouteTable.Routes);

                BundleConfig.RegisterBundles(BundleTable.Bundles);
            }
        }
    }
}
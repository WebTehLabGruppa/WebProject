using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.App_Start
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




            bundles.Add(new Bundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new Bundle("~/bundles/jquery/js").Include("~/Scripts/jquery-3.6.4.min.js"));

            bundles.Add(new Bundle("~/bundles/owlcarousel/js").Include("~/Scripts/owl.carousel.js"));

            bundles.Add(new Bundle("~/bundles/custom/js").Include("~/Vendor/custom.js"));

            bundles.Add(new Bundle("~/bundles/easing/js").Include("~/Vendor/easing.js"));

            bundles.Add(new Bundle("~/bundles/popper/js").Include("~/Vendor/popper.js"));

            bundles.Add(new Bundle("~/bundles/parallax/js").Include("~/Vendor/parallax-js-master/parallax.min.js"));

            bundles.Add(new Bundle("~/bundles/blog/js").Include("~/Vendor/blog.js"));

            bundles.Add(new Bundle("~/bundles/courses/js").Include("~/Vendor/courses.js"));

            bundles.Add(new Bundle("~/bundles/course/js").Include("~/Vendor/course.js"));






        }
    }
}
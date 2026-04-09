using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sensor.Mantratec
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //---------------------------AuthenticationScanner----------------------------          

            //routes.MapRoute("Products", "Products", new { controller = "Products", action = "Index" });

            routes.MapRoute("OpticalScanners", "Optical-Scanners", new { controller = "Products", action = "OpticalScanners" });
            routes.MapRoute("MELO31", "Optical-Scanners/MELO31", new { controller = "Products", action = "MELO31" });
            routes.MapRoute("MFS500", "Optical-Scanners/MFS500", new { controller = "Products", action = "MFS500" });
            routes.MapRoute("MFS110", "Optical-Scanners/MFS110", new { controller = "Products", action = "MFS110" });
            routes.MapRoute("MFS210", "Optical-Scanners/MFS210", new { controller = "Products", action = "MFS210" });
            routes.MapRoute("MELO31Modules", "Optical-Scanners/MELO31-Modules", new { controller = "Products", action = "MELO31Modules" });
            routes.MapRoute("MFS500Modules", "Optical-Scanners/MFS500-Modules", new { controller = "Products", action = "MFS500Modules" });

            routes.MapRoute("CapacitiveScanners", "Capacitive-Scanners", new { controller = "Products", action = "CapacitiveScanners" });
            routes.MapRoute("MARC10", "Capacitive-Scanners/MARC10", new { controller = "Products", action = "MARC10" });
            routes.MapRoute("MARC11", "Capacitive-Scanners/MARC11", new { controller = "Products", action = "MARC11" });
            routes.MapRoute("MARC10Modules", "Capacitive-Scanners/MARC10-Modules", new { controller = "Products", action = "MARC10Modules" });
            routes.MapRoute("MARC11Modules", "Capacitive-Scanners/MARC11-Modules", new { controller = "Products", action = "MARC11Modules" });

            routes.MapRoute("IRISScanners", "IRIS-Scanners", new { controller = "Products", action = "IRISScanners" });
            routes.MapRoute("MIS100", "IRIS-Scanners/MIS100", new { controller = "Products", action = "MIS100" });
            routes.MapRoute("MIS100Modules", "IRIS-Scanners/MIS100-Modules", new { controller = "Products", action = "MIS100Modules" });

            routes.MapRoute("BiometricTerminals", "Biometric-Terminals", new { controller = "Products", action = "BiometricTerminals" });
            routes.MapRoute("MBAS50", "Biometric-Terminals/MBAS50", new { controller = "Products", action = "MBAS50" });
            routes.MapRoute("MBAS30", "Biometric-Terminals/MBAS30", new { controller = "Products", action = "MBAS30" });
            routes.MapRoute("MBAS40", "Biometric-Terminals/MBAS40", new { controller = "Products", action = "MBAS40" });
            routes.MapRoute("MT100", "Biometric-Terminals/MT100", new { controller = "Products", action = "MT100" });


            //---------------------------Site----------------------------

            
            routes.MapRoute("InsightsCaseStudies", "Insights-Case-Studies", new { controller = "Site", action = "InsightsCaseStudies" });
            routes.MapRoute("InsightsWhitePapers", "Insights-White-Papers", new { controller = "Site", action = "InsightsWhitePapers" });
            routes.MapRoute("SupportDownloadCenter", "Support-Download-Center", new { controller = "Site", action = "SupportDownloadCenter" });
            routes.MapRoute("SupportPortal", "Support-Portal", new { controller = "Site", action = "SupportPortal" });

            routes.MapRoute("ReturnPolicy", "Return-Policy", new { controller = "Site", action = "ReturnPolicy" });
            routes.MapRoute("PrivacyPolicy", "Privacy-Policy", new { controller = "Site", action = "PrivacyPolicy" });
            routes.MapRoute("TermsofUse", "Terms-of-Use", new { controller = "Site", action = "TermsofUse" });
            routes.MapRoute("AboutUs", "About-Us", new { controller = "Site", action = "AboutUs" });
            routes.MapRoute("ContactUs", "Contact-Us", new { controller = "Site", action = "ContactUs" });
            routes.MapRoute("PressReleases", "Press-Releases", new { controller = "Site", action = "PressReleases" });
            routes.MapRoute("Events", "Events", new { controller = "Site", action = "Events" });
            routes.MapRoute("Sitemap", "Sitemap", new { controller = "Site", action = "Sitemap" });

            routes.MapRoute("ThankYou", "Thank-You", new { controller = "Site", action = "ThankYou" });

            //---------------------------Blog----------------------------

            routes.MapRoute("Blog", "Blog", new { controller = "Blog", action = "Index" });

            //-2026

            //-2025
            routes.MapRoute("Howsecurebiometricauthenticationagainstcyberattacks", "How-secure-biometric-authentication-against-cyberattacks", new { controller = "Blog", action = "Howsecurebiometricauthenticationagainstcyberattacks" });
            routes.MapRoute("Fingerprintminutiaedemystifiedkeytoreliablebiometricmatching", "Fingerprint-minutiae-demystified-key-to-reliable-biometric-matching", new { controller = "Blog", action = "Fingerprintminutiaedemystifiedkeytoreliablebiometricmatching" });
            routes.MapRoute("Howbusinessescanstreamlinecustomeridentityverification", "How-businesses-can-streamline-customer-identity-verification", new { controller = "Blog", action = "Howbusinessescanstreamlinecustomeridentityverification" });
            routes.MapRoute("Biometricsfuturecontactlesspatientauthenticationhealthcare", "Biometrics-future-contact-less-patient-authentication-healthcare", new { controller = "Blog", action = "Biometricsfuturecontactlesspatientauthenticationhealthcare" });
            routes.MapRoute("Howopticalscannerselevaterecordmanagementineducationalsystem", "How-optical-scanners-elevate-record-management-in-educational-system", new { controller = "Blog", action = "Howopticalscannerselevaterecordmanagementineducationalsystem" });
            routes.MapRoute("How442fingerprintscannersrevolunizepublicsectoridverification", "How-4-4-2-fingerprint-scanners-revolunize-public-sector-id-verification", new { controller = "Blog", action = "How442fingerprintscannersrevolunizepublicsectoridverification" });
            routes.MapRoute("Whybiometricauthenticationfutureofmerchantpayments", "Why-biometric-authentication-future-of-merchant-payments", new { controller = "Blog", action = "Whybiometricauthenticationfutureofmerchantpayments" });
            routes.MapRoute("Spoofdetectionsafeguardingfutureofidentitysolutions", "Spoof-detection-safeguarding-future-of-identity-solutions", new { controller = "Blog", action = "Spoofdetectionsafeguardingfutureofidentitysolutions" });            

            //-2024
            routes.MapRoute("PowerofdigitalidentityMOSIPconnecting118Mpeople", "Power-of-digital-identity-MOSIP-connecting-118M-people", new { controller = "Blog", action = "PowerofdigitalidentityMOSIPconnecting118Mpeople" });
            routes.MapRoute("Typesoffingerprintscannersforapplications", "Types-of-fingerprint-scanners-for-applications", new { controller = "Blog", action = "Typesoffingerprintscannersforapplications" });
            routes.MapRoute("Biometricnationalidcardsbuildingtrustindigitalgovernance", "Biometric-national-id-cards-building-trust-in-digital-governance", new { controller = "Blog", action = "Biometricnationalidcardsbuildingtrustindigitalgovernance" });
            routes.MapRoute("Biometricsdigitalidentityverificationstrategicroadmapforsecuritytrust", "Biometrics-digital-identity-verification-strategic-roadmap-for-security-trust", new { controller = "Blog", action = "Biometricsdigitalidentityverificationstrategicroadmapforsecuritytrust" });
            routes.MapRoute("Howbiometricsistransforminghealthinsurancecards", "How-biometrics-is-transforming-health-insurance-cards", new { controller = "Blog", action = "Howbiometricsistransforminghealthinsurancecards" });
            routes.MapRoute("Opticalvscapacitivescannerwhichisrightforyou", "Optical-vs-capacitive-scanner-which-is-right-for-you", new { controller = "Blog", action = "Opticalvscapacitivescannerwhichisrightforyou" });
            routes.MapRoute("Howfakefingerprintdetectionworks", "How-fake-fingerprint-detection-works", new { controller = "Blog", action = "Howfakefingerprintdetectionworks" });
            routes.MapRoute("MantraSmartIdentityatDigitalGovernmentAfrica2024", "Mantra-Smart-Identity-at-Digital-Government-Africa-2024", new { controller = "Blog", action = "MantraSmartIdentityatDigitalGovernmentAfrica2024" });
            routes.MapRoute("IrisRecognitiondecodingfutureofsecurecivilidentification", "Iris-Recognition-decoding-future-of-secure-civil-identification", new { controller = "AuthenticationScanner", action = "IrisRecognitiondecodingfutureofsecurecivilidentification" });routes.MapRoute("Thepowerofbiometricsecurityindigitalbankingindustry", "The-power-of-biometric-security-in-digital-banking-industry", new { controller = "AuthenticationScanner", action = "Thepowerofbiometricsecurityindigitalbankingindustry" });
            routes.MapRoute("Advantageschallengesofbiometricidentificationinhealthcare", "Advantages-challenges-of-biometric-identification-in-healthcare", new { controller = "Blog", action = "Advantageschallengesofbiometricidentificationinhealthcare" });
            routes.MapRoute("MOSIPtransformingdigitalidentitymanagement", "MOSIP-transforming-digital-identity-management", new { controller = "Blog", action = "MOSIPtransformingdigitalidentitymanagement" });

            //---------------------------Support----------------------------

            //routes.MapRoute("Download", "/Support/Download", new { controller = "Support", action = "Download" });
            //routes.MapRoute("Registration", "Registration", new { controller = "Support", action = "Registration" });
            //routes.MapRoute("InvitedCustomer", "InvitedCustomer", new { controller = "Support", action = "InvitedCustomer" });

            routes.MapRoute("Error", "Error", new { controller = "Error", action = "Index" });
            routes.MapRoute("NotFound", "Not-Found", new { controller = "Error", action = "NotFound" });
            routes.MapRoute("ServerError", "Server-Error", new { controller = "Error", action = "ServerError" });

            //--------------Business-Security-Systems ------------ Solutions ---
            routes.Add(
                new Route("{controller}/{action}/{id}",
                new RouteValueDictionary(
                new { controller = "Site", action = "Index", id = "" }),
                new HyphenatedRouteHandler())
            );
        }
    }
}

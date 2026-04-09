const sitePages = [
  ['site/index', 'Home'],
  ['site/contactus', 'Contact Us'],
  ['site/returnpolicy', 'Return Policy'],
  ['site/privacypolicy', 'Privacy Policy'],
  ['site/termsofuse', 'Terms of Use'],
  ['site/insightscasestudies', 'Insights Case Studies'],
  ['site/insightswhitepapers', 'Insights White Papers'],
  ['site/thankyou', 'Thank You']
];

const productPages = [
  ['products/melo31', 'MELO31'],
  ['products/mfs500', 'MFS500'],
  ['products/mfs110', 'MFS110'],
  ['products/mfs210', 'MFS210'],
  ['products/melo31modules', 'MELO31 Modules'],
  ['products/mfs500modules', 'MFS500 Modules'],
  ['products/marc10', 'MARC10'],
  ['products/marc11', 'MARC11'],
  ['products/marc10modules', 'MARC10 Modules'],
  ['products/marc11modules', 'MARC11 Modules'],
  ['products/mis100', 'MIS100'],
  ['products/mis100modules', 'MIS100 Modules'],
  ['products/mbas50', 'MBAS50'],
  ['products/mbas30', 'MBAS30'],
  ['products/mbas40', 'MBAS40'],
  ['products/mt100', 'MT100']
];

const supportPages = [
  ['support/download', 'Support Download'],
  ['support/registration', 'Support Registration'],
  ['support/invitedcustomer', 'Support Invited Customer']
];

const blogPages = [
  ['blog/index', 'Blog Index'],
  ['blog/howsecurebiometricauthenticationagainstcyberattacks', 'How secure biometric authentication against cyber attacks'],
  ['blog/fingerprintminutiaedemystifiedkeytoreliablebiometricmatching', 'Fingerprint minutiae demystified'],
  ['blog/howbusinessescanstreamlinecustomeridentityverification', 'How businesses can streamline customer identity verification'],
  ['blog/biometricsfuturecontactlesspatientauthenticationhealthcare', 'Biometrics and contactless healthcare authentication'],
  ['blog/howopticalscannerselevaterecordmanagementineducationalsystem', 'Optical scanners in educational record management'],
  ['blog/how442fingerprintscannersrevolunizepublicsectoridverification', '442 fingerprint scanners in public sector'],
  ['blog/whybiometricauthenticationfutureofmerchantpayments', 'Biometric authentication for merchant payments'],
  ['blog/whypolicedepartmentadopting442fingerprintscannersaccuracyspeed', 'Police departments adopting 442 scanners'],
  ['blog/spoofdetectionsafeguardingfutureofidentitysolutions', 'Spoof detection and identity solutions'],
  ['blog/powerofdigitalidentitymosipconnecting118mpeople', 'Power of digital identity MOSIP'],
  ['blog/typesoffingerprintscannersforapplications', 'Types of fingerprint scanners'],
  ['blog/biometricnationalidcardsbuildingtrustindigitalgovernance', 'Biometric national ID cards'],
  ['blog/biometricsdigitalidentityverificationstrategicroadmapforsecuritytrust', 'Biometric digital identity roadmap'],
  ['blog/howbiometricsistransforminghealthinsurancecards', 'Biometrics in health insurance cards'],
  ['blog/opticalvscapacitivescannerwhichisrightforyou', 'Optical vs capacitive scanner'],
  ['blog/howfakefingerprintdetectionworks', 'How fake fingerprint detection works'],
  ['blog/mantrasmartidentityatdigitalgovernmentafrica2024', 'Mantra Smart Identity at DGA 2024'],
  ['blog/irisrecognitiondecodingfutureofsecurecivilidentification', 'Iris recognition and civil ID'],
  ['blog/harnessingtechnologylatestinitiativeinsmartzambiainstitute', 'Smart Zambia Institute initiative'],
  ['blog/thepowerofbiometricsecurityindigitalbankingindustry', 'Power of biometric security in banking'],
  ['blog/advantageschallengesofbiometricidentificationinhealthcare', 'Biometric identification in healthcare'],
  ['blog/mosiptransformingdigitalidentitymanagement', 'MOSIP transforming digital identity']
];

const toPage = ([path, title], section) => ({
  path: `/${path}`,
  title,
  section,
  legacyRoute: `/${path}`
});

export const allPages = [
  ...sitePages.map((entry) => toPage(entry, 'Site')),
  ...productPages.map((entry) => toPage(entry, 'Products')),
  ...supportPages.map((entry) => toPage(entry, 'Support')),
  ...blogPages.map((entry) => toPage(entry, 'Blog'))
];

export const groupedPages = allPages.reduce((acc, page) => {
  if (!acc[page.section]) {
    acc[page.section] = [];
  }
  acc[page.section].push(page);
  return acc;
}, {});

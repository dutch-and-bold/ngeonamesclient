using System.Collections.Generic;
using DutchAndBold.NGeoNamesClient.Entities;
using Refit;

namespace DutchAndBold.NGeoNamesClient.Dtos
{
    public class SearchQuery
    {
        /// <summary>
        /// (q,name or name_equals required)	search over all attributes of a place : place name, country name, continent, admin codes,... (Important:urlencoded utf8)
        /// </summary>
        [AliasAs("q")]
        public string Query { get; set; }

        /// <summary>
        /// (q,name or name_equals required)	place name only(Important:urlencoded utf8)
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// (q,name or name_equals required)	exact place name
        /// </summary>
        [AliasAs("name_equals")]
        public string NameEquals { get; set; }

        /// <summary>
        /// (optional)	place name starts with given characters
        /// </summary>
        [AliasAs("name_startsWith")]
        public string NameStartsWith { get; set; }

        /// <summary>
        /// (optional)	the maximal number of rows in the document returned by the service. Default is 100, the maximal allowed value is 1000.
        /// </summary>
        [AliasAs("maxRows")]
        public int? MaxRows { get; set; }

        /// <summary>
        /// (optional)	Used for paging results. If you want to get results 30 to 40, use startRow=30 and maxRows=10. Default is 0, the maximal allowed value is 5000 for the free services and 25000 for the premium services
        /// </summary>
        [AliasAs("startRow")]
        public int? StartRow { get; set; }

        /// <summary>
        /// : country code, ISO-3166 (optional)	Default is all countries. The country parameter may occur more than once, example: country=FR&country=GP
        /// </summary>
        [AliasAs("country")]
        public string Country { get; set; }

        /// <summary>
        /// (option), two letter country code ISO-3166	records from the countryBias are listed first
        /// </summary>
        [AliasAs("countryBias")]
        public string CountryBias { get; set; }

        /// <summary>
        /// : continent code : AF,AS,EU,NA,OC,SA,AN (optional)	restricts the search for toponym of the given continent.
        /// </summary>
        [AliasAs("continentCode")]
        public string ContinentCode { get; set; }

        /// <summary>
        /// adminCode2, adminCode3, adminCode4, adminCode5	string : admin code (optional)	code of administrative subdivision
        /// </summary>
        [AliasAs("adminCode1")]
        public string AdminCode1 { get; set; }

        /// <summary>
        /// adminCode2, adminCode3, adminCode4, adminCode5	string : admin code (optional)	code of administrative subdivision
        /// </summary>
        [AliasAs("adminCode2")]
        public string AdminCode2 { get; set; }

        /// <summary>
        /// adminCode2, adminCode3, adminCode4, adminCode5	string : admin code (optional)	code of administrative subdivision
        /// </summary>
        [AliasAs("adminCode3")]
        public string AdminCode3 { get; set; }

        /// <summary>
        /// adminCode2, adminCode3, adminCode4, adminCode5	string : admin code (optional)	code of administrative subdivision
        /// </summary>
        [AliasAs("adminCode4")]
        public string AdminCode4 { get; set; }

        /// <summary>
        /// adminCode2, adminCode3, adminCode4, adminCode5	string : admin code (optional)	code of administrative subdivision
        /// </summary>
        [AliasAs("adminCode5")]
        public string AdminCode5 { get; set; }

        /// <summary>
        /// A,H,L,P,R,S,T,U,V (optional)	featureclass(es) (default= all feature classes); this parameter may occur more than once, example: featureClass=P&featureClass=A
        /// </summary>
        [AliasAs("featureClass")]
        public string FeatureClass { get; set; }

        /// <summary>
        /// (optional)	featurecode(s) (default= all feature codes); this parameter may occur more than once, example: featureCode=PPLC&featureCode=PPLX
        /// </summary>
        [AliasAs("featureCode")]
        public string FeatureCode { get; set; }

        /// <summary>
        /// (optional)	optional filter parameter with three possible values 'cities1000', 'cities5000','cities15000' used to categorize the populated places into three groups according to size/relevance. See the download readme for further infos
        /// </summary>
        [AliasAs("cities")]
        public string Cities { get; set; }

        /// <summary>
        /// ISO-639 2-letter language code; en,de,fr,it,es,... (optional)	place name and country name will be returned in the specified language. Default is English. Feature classes and codes are only available in English and Bulgarian. Any help in translating is welcome.
        /// </summary>
        [AliasAs("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// xml,json,rdf	the format type of the returned document, default = xml
        /// </summary>
        [AliasAs("type")]
        public string Type { get; set; }

        /// <summary>
        /// SHORT,MEDIUM,LONG,FULL (optional)	verbosity of returned xml document, default = MEDIUM
        /// </summary>
        [AliasAs("style")]
        public string Style { get; set; }

        /// <summary>
        /// (optional)	At least one of the search term needs to be part of the place name. Example : A normal search for Berlin will return all places within the state of Berlin. If we only want to find places with 'Berlin' in the name we set the parameter isNameRequired to 'true'. The difference to the name_equals parameter is that this will allow searches for 'Berlin, Germany' as only one search term needs to be part of the name.
        /// </summary>
        [AliasAs("isNameRequired")]
        public bool? IsNameRequired { get; set; }

        /// <summary>
        /// (optional)	search for toponyms tagged with the specified tag
        /// </summary>
        [AliasAs("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// (optional)	default is 'AND', with the operator 'OR' not all search terms need to be matched by the response
        /// </summary>
        [AliasAs("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// (optional)	default is 'UTF8', defines the encoding used for the document returned by the web service.
        /// </summary>
        [AliasAs("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// (optional)	default is '1', defines the fuzziness of the search terms. float between 0 and 1. The search term is only applied to the name attribute.
        /// </summary>
        [AliasAs("fuzzy")]
        public float? Fuzzy { get; set; }

        /// <summary>
        /// (optional)	in combination with the name parameter, the search will only consider names in the specified language. Used for instance to query for IATA airport codes.
        /// </summary>
        [AliasAs("searchLang")]
        public string SearchLang { get; set; }

        /// <summary>
        /// (optional)[population,elevation,relevance]	in combination with the name_startsWith, if set to 'relevance' than the result is sorted by relevance.
        /// </summary>
        [AliasAs("orderBy")]
        public string OrderBy { get; set; }

        /// <summary>
        /// (option) [true]	include Bbox info, regardelss of style setting. (normally only included with style=FULL
        /// </summary>
        [AliasAs("inclBbox")]
        public string IncludeBbox { get; set; }
    }
}
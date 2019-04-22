using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGrpXML
{
    public class CharactersOfMarvel
    {
        private int id;
        private int digitalId;
        private string title;
        private int issueNumber;
        private string variantDescription;
        private string description;
        private string modified;
        private string isbn;
        private string upc;
        private string diamondCode;
        private string ean;
        private string issn;
        private string format;
        private int pageCount;
        private textObjects[] textObjects;
        private string resourceURI;
        private Urls[] urls;
        private Series series;
        private Variants[] variants;
        private Collections[] collections;
        private Issues[] collectedIssues;
        private Dates[] dates;
        private Prices[] prices;
        private Thumbnail thumbnail;
        private Images[] images;
        private creators[] Creators;
        private Characters characters;
        private Stories stories;
        private Events events;

        public int Id { get => id; set => id = value; }
        public int DigitalId { get => digitalId; set => digitalId = value; }
        public string Title { get => title; set => title = value; }
        public int IssueNumber { get => issueNumber; set => issueNumber = value; }
        public string VariantDescription { get => variantDescription; set => variantDescription = value; }
        public string Description { get => description; set => description = value; }
        public string Modified { get => modified; set => modified = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Upc { get => upc; set => upc = value; }
        public string DiamondCode { get => diamondCode; set => diamondCode = value; }
        public string Ean { get => ean; set => ean = value; }
        public string Issn { get => issn; set => issn = value; }
        public string Format { get => format; set => format = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public textObjects[] TextObjects { get => textObjects; set => textObjects = value; }
        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public Urls[] Urls { get => urls; set => urls = value; }
        public Series Series { get => series; set => series = value; }
        public Variants[] Variants { get => variants; set => variants = value; }
        public Collections[] Collections { get => collections; set => collections = value; }
        public Issues[] CollectedIssues { get => collectedIssues; set => collectedIssues = value; }
        public Dates[] Dates { get => dates; set => dates = value; }
        public Prices[] Prices { get => prices; set => prices = value; }
        public Thumbnail Thumbnail { get => thumbnail; set => thumbnail = value; }
        public Images[] Images { get => images; set => images = value; }
        public creators[] Creators1 { get => Creators; set => Creators = value; }
        public Characters Characters { get => characters; set => characters = value; }
        public Stories Stories { get => stories; set => stories = value; }
        public Events Events { get => events; set => events = value; }
    }
    public class textObjects
    {
        private string type;
        private string language;
        private string text;

        public string Type { get => type; set => type = value; }
        public string Language { get => language; set => language = value; }
        public string Text { get => text; set => text = value; }
    }
    public class Urls
    {
        private string type;
        private string url;

        public string Type { get => type; set => type = value; }
        public string Url { get => url; set => url = value; }
    }
    public class Series
    {
        private string resourceURI;
        private string name;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }
    public class Dates
    {
        private string type;
        private string date;

        public string Type { get => type; set => type = value; }
        public string Date { get => date; set => date = value; }
    }
    public class Prices
    {
        private string type;
        private string price;

        public string Type { get => type; set => type = value; }
        public string Price { get => price; set => price = value; }
    }
    public class Thumbnail
    {
        private string path;
        private string extension;

        public string Path { get => path; set => path = value; }
        public string Extension { get => extension; set => extension = value; }
    }
    public class Images
    {
        private string path;
        private string extension;

        public string Path { get => path; set => path = value; }
        public string Extension { get => extension; set => extension = value; }
    }
    public class creators
    {
        private string available;
        private string collectionURI;
        private items[] items;
        private string returned;

        public string Available { get => available; set => available = value; }
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        public items[] Items { get => items; set => items = value; }
        public string Returned { get => returned; set => returned = value; }
    }
    public class items
    {
        private string resourceURI;
        private string name;
        private string role;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
    }
    public class Characters
    {
        private string available;
        private string collectionURI;
        private Item[] items;
        private string returned;

        public string Available { get => available; set => available = value; }
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        public Item[] Items { get => items; set => items = value; }
        public string Returned { get => returned; set => returned = value; }
    }
    public class Item
    {
        private string resourceURI;
        private string name;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }
    public class Variants
    {
        private string resourceURI;
        private string name;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }

    public class Collections
    {
        private string resourceURI;
        private string name;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }
    public class Stories
    {
        private string available;
        private string collectionURI;
        private Item3[] item;
        private string returned;

        public string Available { get => available; set => available = value; }
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        public Item3[] Item { get => item; set => item = value; }
        public string Returned { get => returned; set => returned = value; }
    }
    public class Item3
    {
        private string resourceURI;
        private string name;
        private string type;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
    }
    public class Events
    {
        private string available;
        private string collectionURI;
        private itrm[] items;
        private string returned;

        public string Available { get => available; set => available = value; }
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        public string Returned { get => returned; set => returned = value; }
        public itrm[] Items { get => items; set => items = value; }
    }
    public class itrm
    {
        private string resourceURI;
        private string name;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }

    public class Issues
    {
        private string resourceURI;
        private string name;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }

}
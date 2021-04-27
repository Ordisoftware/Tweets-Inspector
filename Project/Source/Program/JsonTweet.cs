using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ordisoftware.TweetsInspector
{
  static public class JsonHelper
  {
    static public List<Json.Tweet.TweetItem> LoadTweets(string filePath)
    {
      var builder = new StringBuilder();
      using ( var stream = File.OpenText(filePath) )
      {
        string line = stream.ReadLine();
        if ( line == null ) return new List<Json.Tweet.TweetItem>();
        line = line.Replace("window.YTD.tweet.part0 = ", "");
        builder.Append(line);
        while ( ( line = stream.ReadLine() ) != null )
          builder.Append(line);
      }
      return Json.Tweet.JsonTweet.FromJson(builder.ToString()).Select(tweet => tweet.Item).ToList();
    }
  }
}

// https://github.com/quicktype/quicktype-vs
namespace Ordisoftware.TweetsInspector.Json.Tweet
{

  using System;
  using System.Collections.Generic;

  using System.Globalization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  public partial class JsonTweet
  {
    [JsonProperty("tweet")]
    public TweetItem Item { get; set; }
  }

  public partial class TweetItem
  {
    [JsonProperty("retweeted")]
    public bool Retweeted { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("entities")]
    public Entities Entities { get; set; }

    [JsonProperty("display_text_range")]
    [JsonConverter(typeof(DecodeArrayConverter))]
    public long[] DisplayTextRange { get; set; }

    [JsonProperty("favorite_count")]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long FavoriteCount { get; set; }

    [JsonProperty("id_str")]
    public string IdStr { get; set; }

    [JsonProperty("truncated")]
    public bool Truncated { get; set; }

    [JsonProperty("retweet_count")]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long RetweetCount { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("possibly_sensitive", NullValueHandling = NullValueHandling.Ignore)]
    public bool? PossiblySensitive { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("favorited")]
    public bool Favorited { get; set; }

    [JsonProperty("full_text")]
    public string FullText { get; set; }

    [JsonProperty("lang")]
    public Lang Lang { get; set; }

    [JsonProperty("extended_entities", NullValueHandling = NullValueHandling.Ignore)]
    public ExtendedEntities ExtendedEntities { get; set; }

    [JsonProperty("in_reply_to_status_id_str", NullValueHandling = NullValueHandling.Ignore)]
    public string InReplyToStatusIdStr { get; set; }

    [JsonProperty("in_reply_to_user_id", NullValueHandling = NullValueHandling.Ignore)]
    public string InReplyToUserId { get; set; }

    [JsonProperty("in_reply_to_status_id", NullValueHandling = NullValueHandling.Ignore)]
    public string InReplyToStatusId { get; set; }

    [JsonProperty("in_reply_to_screen_name", NullValueHandling = NullValueHandling.Ignore)]
    public string InReplyToScreenName { get; set; }

    [JsonProperty("in_reply_to_user_id_str", NullValueHandling = NullValueHandling.Ignore)]
    public string InReplyToUserIdStr { get; set; }

    [JsonProperty("withheld_copyright", NullValueHandling = NullValueHandling.Ignore)]
    public bool? WithheldCopyright { get; set; }

    [JsonProperty("withheld_in_countries", NullValueHandling = NullValueHandling.Ignore)]
    public string[] WithheldInCountries { get; set; }
  }

  public partial class Entities
  {
    [JsonProperty("hashtags")]
    public Hashtag[] Hashtags { get; set; }

    [JsonProperty("symbols")]
    public Hashtag[] Symbols { get; set; }

    [JsonProperty("user_mentions")]
    public UserMention[] UserMentions { get; set; }

    [JsonProperty("urls")]
    public Url[] Urls { get; set; }

    [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
    public Media[] Media { get; set; }
  }

  public partial class Hashtag
  {
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("indices")]
    [JsonConverter(typeof(DecodeArrayConverter))]
    public long[] Indices { get; set; }
  }

  public partial class Media
  {
    [JsonProperty("expanded_url")]
    public string ExpandedUrl { get; set; }

    [JsonProperty("source_status_id", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceStatusId { get; set; }

    [JsonProperty("indices")]
    [JsonConverter(typeof(DecodeArrayConverter))]
    public long[] Indices { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("media_url")]
    public string MediaUrl { get; set; }

    [JsonProperty("id_str")]
    public string IdStr { get; set; }

    [JsonProperty("source_user_id", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceUserId { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("media_url_https")]
    public string MediaUrlHttps { get; set; }

    [JsonProperty("source_user_id_str", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceUserIdStr { get; set; }

    [JsonProperty("sizes")]
    public Sizes Sizes { get; set; }

    [JsonProperty("type")]
    public TypeEnum Type { get; set; }

    [JsonProperty("source_status_id_str", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceStatusIdStr { get; set; }

    [JsonProperty("display_url")]
    public string DisplayUrl { get; set; }

    [JsonProperty("video_info", NullValueHandling = NullValueHandling.Ignore)]
    public VideoInfo VideoInfo { get; set; }

    [JsonProperty("additional_media_info", NullValueHandling = NullValueHandling.Ignore)]
    public AdditionalMediaInfo AdditionalMediaInfo { get; set; }
  }

  public partial class AdditionalMediaInfo
  {
    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("embeddable", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Embeddable { get; set; }

    [JsonProperty("monetizable")]
    public bool Monetizable { get; set; }

    [JsonProperty("call_to_actions", NullValueHandling = NullValueHandling.Ignore)]
    public CallToActions CallToActions { get; set; }
  }

  public partial class CallToActions
  {
    [JsonProperty("watch_now", NullValueHandling = NullValueHandling.Ignore)]
    public VisitSite WatchNow { get; set; }

    [JsonProperty("visit_site", NullValueHandling = NullValueHandling.Ignore)]
    public VisitSite VisitSite { get; set; }
  }

  public partial class VisitSite
  {
    [JsonProperty("url")]
    public string Url { get; set; }
  }

  public partial class Sizes
  {
    [JsonProperty("large")]
    public Large Large { get; set; }

    [JsonProperty("thumb")]
    public Large Thumb { get; set; }

    [JsonProperty("medium")]
    public Large Medium { get; set; }

    [JsonProperty("small")]
    public Large Small { get; set; }
  }

  public partial class Large
  {
    [JsonProperty("w")]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long W { get; set; }

    [JsonProperty("h")]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long H { get; set; }

    [JsonProperty("resize")]
    public Resize Resize { get; set; }
  }

  public partial class VideoInfo
  {
    [JsonProperty("aspect_ratio")]
    [JsonConverter(typeof(DecodeArrayConverter))]
    public long[] AspectRatio { get; set; }

    [JsonProperty("duration_millis", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long? DurationMillis { get; set; }

    [JsonProperty("variants")]
    public Variant[] Variants { get; set; }
  }

  public partial class Variant
  {
    [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long? Bitrate { get; set; }

    [JsonProperty("content_type")]
    public ContentType ContentType { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
  }

  public partial class Url
  {
    [JsonProperty("url")]
    public string UrlUrl { get; set; }

    [JsonProperty("expanded_url")]
    public string ExpandedUrl { get; set; }

    [JsonProperty("display_url")]
    public string DisplayUrl { get; set; }

    [JsonProperty("indices")]
    [JsonConverter(typeof(DecodeArrayConverter))]
    public long[] Indices { get; set; }
  }

  public partial class UserMention
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("screen_name")]
    public string ScreenName { get; set; }

    [JsonProperty("indices")]
    [JsonConverter(typeof(DecodeArrayConverter))]
    public long[] Indices { get; set; }

    [JsonProperty("id_str")]
    public string IdStr { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }
  }

  public partial class ExtendedEntities
  {
    [JsonProperty("media")]
    public Media[] Media { get; set; }
  }

  public enum Resize { Crop, Fit };

  public enum TypeEnum { AnimatedGif, Photo, Video };

  public enum ContentType { ApplicationXMpegUrl, VideoMp4 };

  public enum Lang { Ar, Ca, Cs, Cy, Da, De, En, Es, Et, Eu, Fi, Fr, Hi, Ht, Hu, In, Is, It, Iw, Lt, Nl, No, Pt, Ro, Sl, Sv, Tl, Und };

  public partial class JsonTweet
  {
    public static JsonTweet[] FromJson(string json) => JsonConvert.DeserializeObject<JsonTweet[]>(json, Converter.Settings);
  }

  public static class Serialize
  {
    public static string ToJson(this JsonTweet[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
  }

  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters = {
                ResizeConverter.Singleton,
                TypeEnumConverter.Singleton,
                ContentTypeConverter.Singleton,
                LangConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
  }

  internal class DecodeArrayConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(long[]);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      reader.Read();
      var value = new List<long>();
      while ( reader.TokenType != JsonToken.EndArray )
      {
        var converter = ParseIntegerConverter.Singleton;
        var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
        value.Add(arrayItem);
        reader.Read();
      }
      return value.ToArray();
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      var value = (long[])untypedValue;
      writer.WriteStartArray();
      foreach ( var arrayItem in value )
      {
        var converter = ParseIntegerConverter.Singleton;
        converter.WriteJson(writer, arrayItem, serializer);
      }
      writer.WriteEndArray();
      return;
    }

    public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
  }

  internal class ParseIntegerConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      long l;
      if ( Int64.TryParse(value, out l) )
      {
        return l;
      }
      throw new Exception("Cannot unmarshal type long");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if ( untypedValue == null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (long)untypedValue;
      serializer.Serialize(writer, value.ToString());
      return;
    }

    public static readonly ParseIntegerConverter Singleton = new ParseIntegerConverter();
  }

  internal class ResizeConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(Resize) || t == typeof(Resize?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      switch ( value )
      {
        case "crop":
          return Resize.Crop;
        case "fit":
          return Resize.Fit;
      }
      throw new Exception("Cannot unmarshal type Resize");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if ( untypedValue == null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (Resize)untypedValue;
      switch ( value )
      {
        case Resize.Crop:
          serializer.Serialize(writer, "crop");
          return;
        case Resize.Fit:
          serializer.Serialize(writer, "fit");
          return;
      }
      throw new Exception("Cannot marshal type Resize");
    }

    public static readonly ResizeConverter Singleton = new ResizeConverter();
  }

  internal class TypeEnumConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      switch ( value )
      {
        case "animated_gif":
          return TypeEnum.AnimatedGif;
        case "photo":
          return TypeEnum.Photo;
        case "video":
          return TypeEnum.Video;
      }
      throw new Exception("Cannot unmarshal type TypeEnum");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if ( untypedValue == null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (TypeEnum)untypedValue;
      switch ( value )
      {
        case TypeEnum.AnimatedGif:
          serializer.Serialize(writer, "animated_gif");
          return;
        case TypeEnum.Photo:
          serializer.Serialize(writer, "photo");
          return;
        case TypeEnum.Video:
          serializer.Serialize(writer, "video");
          return;
      }
      throw new Exception("Cannot marshal type TypeEnum");
    }

    public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
  }

  internal class ContentTypeConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(ContentType) || t == typeof(ContentType?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      switch ( value )
      {
        case "application/x-mpegURL":
          return ContentType.ApplicationXMpegUrl;
        case "video/mp4":
          return ContentType.VideoMp4;
      }
      throw new Exception("Cannot unmarshal type ContentType");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if ( untypedValue == null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (ContentType)untypedValue;
      switch ( value )
      {
        case ContentType.ApplicationXMpegUrl:
          serializer.Serialize(writer, "application/x-mpegURL");
          return;
        case ContentType.VideoMp4:
          serializer.Serialize(writer, "video/mp4");
          return;
      }
      throw new Exception("Cannot marshal type ContentType");
    }

    public static readonly ContentTypeConverter Singleton = new ContentTypeConverter();
  }

  internal class LangConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(Lang) || t == typeof(Lang?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      switch ( value )
      {
        case "ar":
          return Lang.Ar;
        case "ca":
          return Lang.Ca;
        case "cs":
          return Lang.Cs;
        case "cy":
          return Lang.Cy;
        case "da":
          return Lang.Da;
        case "de":
          return Lang.De;
        case "en":
          return Lang.En;
        case "es":
          return Lang.Es;
        case "et":
          return Lang.Et;
        case "eu":
          return Lang.Eu;
        case "fi":
          return Lang.Fi;
        case "fr":
          return Lang.Fr;
        case "hi":
          return Lang.Hi;
        case "ht":
          return Lang.Ht;
        case "hu":
          return Lang.Hu;
        case "in":
          return Lang.In;
        case "is":
          return Lang.Is;
        case "it":
          return Lang.It;
        case "iw":
          return Lang.Iw;
        case "lt":
          return Lang.Lt;
        case "nl":
          return Lang.Nl;
        case "no":
          return Lang.No;
        case "pt":
          return Lang.Pt;
        case "ro":
          return Lang.Ro;
        case "sl":
          return Lang.Sl;
        case "sv":
          return Lang.Sv;
        case "tl":
          return Lang.Tl;
        case "und":
          return Lang.Und;
      }
      throw new Exception("Cannot unmarshal type Lang");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if ( untypedValue == null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (Lang)untypedValue;
      switch ( value )
      {
        case Lang.Ar:
          serializer.Serialize(writer, "ar");
          return;
        case Lang.Ca:
          serializer.Serialize(writer, "ca");
          return;
        case Lang.Cs:
          serializer.Serialize(writer, "cs");
          return;
        case Lang.Cy:
          serializer.Serialize(writer, "cy");
          return;
        case Lang.Da:
          serializer.Serialize(writer, "da");
          return;
        case Lang.De:
          serializer.Serialize(writer, "de");
          return;
        case Lang.En:
          serializer.Serialize(writer, "en");
          return;
        case Lang.Es:
          serializer.Serialize(writer, "es");
          return;
        case Lang.Et:
          serializer.Serialize(writer, "et");
          return;
        case Lang.Eu:
          serializer.Serialize(writer, "eu");
          return;
        case Lang.Fi:
          serializer.Serialize(writer, "fi");
          return;
        case Lang.Fr:
          serializer.Serialize(writer, "fr");
          return;
        case Lang.Hi:
          serializer.Serialize(writer, "hi");
          return;
        case Lang.Ht:
          serializer.Serialize(writer, "ht");
          return;
        case Lang.Hu:
          serializer.Serialize(writer, "hu");
          return;
        case Lang.In:
          serializer.Serialize(writer, "in");
          return;
        case Lang.Is:
          serializer.Serialize(writer, "is");
          return;
        case Lang.It:
          serializer.Serialize(writer, "it");
          return;
        case Lang.Iw:
          serializer.Serialize(writer, "iw");
          return;
        case Lang.Lt:
          serializer.Serialize(writer, "lt");
          return;
        case Lang.Nl:
          serializer.Serialize(writer, "nl");
          return;
        case Lang.No:
          serializer.Serialize(writer, "no");
          return;
        case Lang.Pt:
          serializer.Serialize(writer, "pt");
          return;
        case Lang.Ro:
          serializer.Serialize(writer, "ro");
          return;
        case Lang.Sl:
          serializer.Serialize(writer, "sl");
          return;
        case Lang.Sv:
          serializer.Serialize(writer, "sv");
          return;
        case Lang.Tl:
          serializer.Serialize(writer, "tl");
          return;
        case Lang.Und:
          serializer.Serialize(writer, "und");
          return;
      }
      throw new Exception("Cannot marshal type Lang");
    }

    public static readonly LangConverter Singleton = new LangConverter();
  }

}

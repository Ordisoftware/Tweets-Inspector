using System;
using System.Linq;
using System.Collections.Generic;

namespace TwitterManager
{

  public enum TweetType { Main, Reply, RT };

  public class Tweet
  {
    public TweetType Type { get; set; }
    public string ScreenName { get; set; }
    public string Id { get; set; }
    public string Date { get; set; }
    public string Message { get; set; }
    public string Recipients { get; set; }
    public List<string> RecipientsAsList => Recipients.Split(',').ToList();
    public string Url => $"https://twitter.com/{ScreenName}/status/{Id}";
    public override string ToString()
    {
      return $"{Id}; {Date}; {string.Join(", ", Recipients)}; {Message}; {Url}";
    }
  }

}

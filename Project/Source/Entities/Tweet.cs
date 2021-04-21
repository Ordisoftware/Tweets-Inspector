using System;
using System.Linq;
using System.Collections.Generic;
using Ordisoftware.Core;

namespace TwitterManager
{

  public enum TweetType { Main, Reply, RT };

  public class Tweet
  {
    public string ScreenName => MainForm.TwitterTokens == null || MainForm.TwitterTokens.ScreenName.IsNullOrEmpty()
                                ? "ordisoftware"
                                : MainForm.TwitterTokens.ScreenName;
    public TweetType Type { get; set; }
    public long Id { get; set; }
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

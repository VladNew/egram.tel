using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class RichText : Structure
    {

        public class RichTextItalic : RichText
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "richTextItalic";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public RichText Text { get; set; }

        }

    }

}
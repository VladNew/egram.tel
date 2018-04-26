using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserType : Structure
    {

        public class UserTypeBot : UserType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userTypeBot";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_join_groups")]
                public bool CanJoinGroups { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_read_all_group_messages")]
                public bool CanReadAllGroupMessages { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_inline")]
                public bool IsInline { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("inline_query_placeholder")]
                public string InlineQueryPlaceholder { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_location")]
                public bool NeedLocation { get; set; }

        }

    }

}
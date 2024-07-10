﻿using System.Text.Json.Serialization;

namespace DiscordAspnet.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
        public Guid ChannelId { get; set; }
        [JsonIgnore]
        public Channel Channel { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
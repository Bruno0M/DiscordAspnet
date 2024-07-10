﻿using DiscordAspnet.Application.DTOs.ChannelDTOs;
using DiscordAspnet.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiscordAspnet.API.Controllers
{
    [Route("Guilds")]
    [ApiController]
    public class ChannelsController : ControllerBase
    {
        private readonly IChannelService _channelService;

        public ChannelsController(IChannelService channelService)
        {
            _channelService = channelService;
        }

        [HttpPost("{guildId}/Channels")]
        public async Task<IActionResult> CreateChannelAsync(ChannelRequest channelRequest, Guid guildId)
        {
            var channel = await _channelService.CreateChannelAsync(channelRequest, guildId);
            return Ok(channel);
        }

        [HttpDelete("{guildId}/{channelId}")]
        public async Task<IActionResult> DeleteChannelAsync(Guid guildId, Guid channelId, Guid ownerId)
        {

            var response = await _channelService.DeleteChannelAsync(guildId, channelId, ownerId);
            return Ok(response);
        }
    }
}
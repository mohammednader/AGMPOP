using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using System.Collections.Generic;

namespace AGMPOP
{
    public class Notify : Hub
    {
        private static readonly Dictionary<int, List<string>> Connections;

        static Notify()
        {
            Connections = new Dictionary<int, List<string>>();
        }

        public override Task OnConnectedAsync()
        {
            var userId = GetLoggedUserId();
            if (userId != 0)
            {
                if (Connections.ContainsKey(userId))
                {
                    Connections[userId].Add(Context.ConnectionId);
                }
                else
                {
                    Connections[userId] = new List<string> { Context.ConnectionId };
                }
            }
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var userId = GetLoggedUserId();
            if (userId != 0)
            {
                if (Connections.ContainsKey(userId))
                {
                    Connections[userId]?.Remove(Context.ConnectionId);
                }
            }
            return base.OnDisconnectedAsync(exception);
        }

        public async Task UpdateUnseenCount(int receiver, int count)
        {
            var clients = GetClientsByUserId(receiver);
            if (clients != null)
            {
                await clients.SendAsync("UpdateUnseenCount", count);
            }
        }

        public async Task SendNotification(int receiver, string message)
        {
            var clients = GetClientsByUserId(receiver);
            if (clients != null)
            {
                await clients.SendAsync("NewNotification", message);
            }
        }

        private int GetLoggedUserId()
        {
            try
            {
                return Convert.ToInt32(((ClaimsIdentity)Context.User.Identity)?.FindFirst("UserId").Value ?? "0");
            }
            catch
            {
                return 0;
            }
        }

        private IClientProxy GetClientsByUserId(int userId)
        {
            List<string> connectionIds;
            Connections.TryGetValue(userId, out connectionIds);
            if (connectionIds?.Count > 0)
            {
                return Clients.Clients(connectionIds);
            }
            else
            {
                return null;
            }
        }
    }
}


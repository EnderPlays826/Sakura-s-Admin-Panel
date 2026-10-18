/*
 * ii Reborn
 * Portions Copyright (C) 2025–2026 Goldentrophy Software
 * Licensed under GNU GPL v3.0-or-later — see LICENSE and NOTICE.
 * This file is part of a derivative work; see NOTICE for attribution
 * and modification history. Do not remove this notice.
 */

namespace iiMenu
{
    public class PluginInfo
    {
        public const string GUID = "ender.gorillatag.sakurasadminpanel";
        public const string Name = "Sakura's Admin Panel";
        public const string Description = "A Gorilla Tag mod menu.";
        public const string BuildTimestamp = "2026-10-10T20:00:00Z";
        public const string Version = "1.0.0";

        public const string BaseDirectory = "Sakura's Admin Panel";
        public const string LegacyBaseDirectory = "iisStupidMenu"; // ii Reborn has no affiliation with nor endorsement by Goldentrophy Software or its name, "ii's Stupid Menu". this is purely a database migration path
        public const string ClientResourcePath = "iiMenu.Resources.Client";
        public const string ServerResourcePath = "https://raw.githubusercontent.com/iimenu/project/main/Resources/Server";

        public const string DiscordAppId = "1553155235223044268";

        public const string DiscordLargeImageKey = "sakuralogo";
        public const string DiscordSmallImageKeyOnline = "";
        public const string DiscordSmallImageKeyOffline = "";
        
        public const string Logo = @"
••  ┳┓  ┓       
┓┓  ┣┫┏┓┣┓┏┓┏┓┏┓
┗┗  ┛┗┗ ┗┛┗┛┛ ┛┗
                ";

        public static bool BetaBuild = true;
    }
}

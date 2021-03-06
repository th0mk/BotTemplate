﻿using System;
using System.Threading.Tasks;
using Bot.Interfaces;

namespace Bot
{
    internal class Program
    {
        private static async Task Main()
        {
            Console.SetBufferSize(1000, short.MaxValue - 1);
            Unity.RegisterTypes();
            var bot = Unity.Resolve<IBot>();
            await bot.StartAsync().ConfigureAwait(false);
        }
    }
}

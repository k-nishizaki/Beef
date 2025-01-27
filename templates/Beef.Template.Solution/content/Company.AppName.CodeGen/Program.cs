﻿using Beef.CodeGen;
using System.Threading.Tasks;

namespace Company.AppName.CodeGen
{
    /// <summary>
    /// Represents the <b>code generation</b> program (capability).
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main startup.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        /// <returns>The status code whereby zero indicates success.</returns>
        public static Task<int> Main(string[] args) => CodeGenConsole.Create("Company", "AppName").Supports(entity: true, refData: true).RunAsync(args);
    }
}
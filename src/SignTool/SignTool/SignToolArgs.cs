﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignTool
{
    internal struct SignToolArgs
    {
        internal string OutputPath { get; }
        internal string IntermediateOutputPath { get; }
        internal string NuGetPackagesPath { get; }
        internal string AppPath { get; }
        internal string MSBuildPath { get; }
        internal string DotnetPath { get; }
        internal string ConfigFile { get; }
        internal bool Test { get; }

        internal SignToolArgs(
            string outputPath,
            string intermediateOutputPath,
            string appPath,
            string msbuildPath,
            string dotnetPath,
            string nugetPackagesPath,
            string configFile,
            bool test)
        {
            OutputPath = outputPath;
            IntermediateOutputPath = intermediateOutputPath;
            AppPath = appPath;
            MSBuildPath = msbuildPath;
            DotnetPath = dotnetPath;
            NuGetPackagesPath = nugetPackagesPath;
            ConfigFile = configFile;
            Test = test;
        }
    }
}

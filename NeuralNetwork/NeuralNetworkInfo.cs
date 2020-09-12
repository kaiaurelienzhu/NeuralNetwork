﻿namespace NeuralNetwork
{
    using System;
    using System.Drawing;
    using Grasshopper.Kernel;
    using NeuralNetwork.Properties;

    public class NeuralNetworkInfo : GH_AssemblyInfo
    {
        public override string Name => "NeuralNetwork";

        public override Bitmap Icon => Resources.icons_icon_plugin;

        // GHB note: if using the provided "About" component this text is output there
        public override string Description => "NeuralNetworkTODO: Provide description of the plugin";

        public override Guid Id => new Guid("69263764-3073-4c66-b093-33ad500105f1");

        public override string AuthorName => "NeuralNetworkTODO: Add author name";

        public override string AuthorContact => "NeuralNetworkTODO: Add author email";

        // GHB note: if using the provided "About" component this URL is output there
        public virtual Uri PluginURL => new Uri("https://github.com/philipbelesky/groundhog/");

        // GHB note: if using the provided "About" component this URL is parsed there
        public virtual Uri ReleasesFeed => new Uri("https://github.com/philipbelesky/groundhog/releases.atom");
    }
}

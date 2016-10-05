using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DotNetBay.Core;
using DotNetBay.Core.Execution;
using DotNetBay.Interfaces;
using DotNetBay.Data.Provider.FileStorage;

namespace DotNetBay.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public readonly IMainRepository MainRepository = new FileSystemMainRepository("Filename"); //Name der Datei zum Speichern der Daten

        public IAuctionRunner AuctionRunner;

        public App()
        {
            AuctionRunner = new AuctionRunner(MainRepository);
            AuctionRunner.Start();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BtrexTrader.Data;
using System.Threading;
using System.Diagnostics;
using BtrexTrader.Interface;
using BtrexTrader.Strategy.TripletStrategy;
using BtrexTrader.Strategy.Demo;

namespace BtrexTrader.Control
{
    class BtrexTradeController
    {
        private NewStratControl NewStrat = new NewStratControl();
        //private TripletTrader TripletTrader = new TripletTrader();

        public async Task InitializeMarkets()
        {
            await NewStrat.Initialize();
            //await TripletTrader.Initialize();
        }

        public void StartWork()
        {
            NewStrat.StartMarketsDemo();



            //var WorkThread = new Thread(() => ScanMarkets());
            //WorkThread.IsBackground = true;
            //WorkThread.Name = "Market-Scanning/Work-Thread";
            //WorkThread.Start();
        }

        private async void ScanMarkets()
        {
            while (true)
            {
                //Parallel.ForEach<TripletData>(TripletTrader.DeltaTrips, triplet => TripletTrader.CalcTrips(triplet));
                Thread.Sleep(100);
            }
        }

    }
}

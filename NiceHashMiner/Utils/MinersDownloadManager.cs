﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.IO.Compression;
using System.Windows.Forms;
using NiceHashMiner.Interfaces;
using System.Threading;
using NiceHashMiner.Configs;
using NiceHashMiner.Devices;

namespace NiceHashMiner.Utils {
    public static class MinersDownloadManager {
        public static DownloadSetup StandardDlSetup = new DownloadSetup(
            "http://github.com/DillonN/NiceHashMiner/releases/download/1.7.5.17/bin_1_7_5_17.zip",
            "bins.zip",
            "bin");

        public static DownloadSetup ThirdPartyDlSetup = new DownloadSetup(
            "http://github.com/DillonN/NiceHashMiner/releases/download/1.7.6.4/bin_3rdparty_1_7_6_4.zip",
            "bins_3rdparty.zip",
            "bin_3rdparty");
    }
}

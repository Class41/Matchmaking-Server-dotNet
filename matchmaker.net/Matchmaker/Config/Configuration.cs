﻿using Matchmaker.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaker.Net.Configuration
{
    public static class Debugging
    {
        public static bool DEBUG_ENABLED = false;
    }

    public static class SpamProtection
    {
        public static bool SPAM_PROTECTION_ENABLED = true;
        public static int FAILED_ATTEMPT_COUNT_MAX = 1;
    }

    public static class ServerVariables
    {
        public static int PORT = 25599,
                          MAX_CLIENTS_CONNECTED = 2, //change to -1 for no queue
                          BUFFER_SIZE = 2048; 

        public static UUID IDENTITY; //this is automatically generated during runtime
    }
}

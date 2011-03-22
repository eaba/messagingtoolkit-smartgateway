//===============================================================================
// OSML - Open Source Messaging Library
//
//===============================================================================
// Copyright © TWIT88.COM.  All rights reserved.
//
// This file is part of Open Source Messaging Library.
//
// Open Source Messaging Library is free software: you can redistribute it 
// and/or modify it under the terms of the GNU General Public License version 3.
//
// Open Source Messaging Library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this software.  If not, see <http://www.gnu.org/licenses/>.
//===============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MessagingToolkit.SmartGateway.Core.Web;

namespace MessagingToolkit.SmartGateway.Core
{
    /// <summary>
    /// Web management console
    /// </summary>
    public partial class WebConsole : UserControl
    {
        // web server settings
        static string appPath;
        static string portString;
        static string virtRoot;

        Server server;

        public WebConsole()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            appPath = @"C:\My Space\2009\MessagingToolkit\MessagingToolkit.Portal";
            portString = "80";
            virtRoot = "/";

            try
            {
                server = new Server(80, virtRoot, appPath);
                server.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            try
            {
                if (server != null)
                {
                    server.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        /// <summary>
        /// Handles the Load event of the WebConsole control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void WebConsole_Load(object sender, EventArgs e)
        {

        }

    }
}

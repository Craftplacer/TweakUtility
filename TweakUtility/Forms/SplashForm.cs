﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using TweakUtility.Attributes;
using TweakUtility.Extensions;
using TweakUtility.Helpers;

namespace TweakUtility.Forms
{
    internal partial class SplashForm : Form
    {
        internal SplashForm() => this.InitializeComponent();

        /// <summary>
        /// This prevents the application showing the main form if an error occurred while launching.
        /// </summary>
        private bool formInitiatedClose = false;

        private void SplashForm_Shown(object sender, EventArgs e)
        {
        }

        public new void Close()
        {
            formInitiatedClose = true;
            base.Close();
        }

        public void SetStatus(string status)
        {
            statusLabel.Text = status;
            statusLabel.Refresh();
            Application.DoEvents();
        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formInitiatedClose)
            {
                Application.Exit();
            }
        }
    }
}
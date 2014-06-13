using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XForms.Toolkit
{
    public abstract class BroadcastMonitor : BroadcastReceiver
    {
        /// <summary>
        ///  Start monitoring. 
        /// </summary>
        public virtual bool Start()
        {
            var intent = this.RegisterReceiver(this.Filter);
            if (intent == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        ///  Stop monitoring. 
        /// </summary>
        public virtual void Stop()
        {
            this.UnregisterReceiver();
        }

        protected abstract IntentFilter Filter { get; }
    }
}
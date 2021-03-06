﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyService
{
	public partial class Service1 : ServiceBase
	{
		System.Timers.Timer timer1 = new System.Timers.Timer();
		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			timer1.Interval = 10;
			timer1.Start();
			timer1.Elapsed += timer1Clock;
			timer1.Enabled = true;
			TestWinForm.WinformProxy.initShowTM();
		 }

 
		protected void timer1Clock(object sender, EventArgs e)
		{
			TestWinForm.WinformProxy.showTM();
		}
		protected override void OnStop()
		{
		}
	}
}

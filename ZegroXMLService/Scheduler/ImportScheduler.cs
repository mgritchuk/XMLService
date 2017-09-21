using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;

namespace ZegroXMLService.Scheduler
{
	public class ImportScheduler
	{
		public static void Start()
		{
			int checkInterval = 10;

			IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

			IJobDetail job = JobBuilder.Create<ImportJob>().Build();
			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("import1", "importGroup")
				.StartNow()
				.WithSimpleSchedule(x => x
					.WithIntervalInMinutes(checkInterval)
					.RepeatForever())
				.Build();

			scheduler.ScheduleJob(job, trigger);

			scheduler.Start();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Models
{
    public static class WMSContext
    {
        private static WMSEntities _inst;
		private static object lockObject = new object();
		public static WMSEntities Inst
		{
			get
			{
				lock (lockObject)
				{
					if (_inst == null)
					{
						try
						{
							_inst = new WMSEntities();
						}
						catch (Exception ex)
						{
						}
					}
					return _inst;
				}
			}
		}

		public static void RollBack()
		{
			foreach (var entity in Inst.ChangeTracker.Entries())
			{
				if (entity.State == System.Data.Entity.EntityState.Added)
				{
					entity.State = System.Data.Entity.EntityState.Deleted;
				}
				entity.Reload();
			}
		}

	}
}

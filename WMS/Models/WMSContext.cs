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

	}
}

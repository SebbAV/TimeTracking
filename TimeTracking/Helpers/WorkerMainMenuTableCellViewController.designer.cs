// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TimeTracking
{
	[Register ("WorkerMainMenuTableCellViewController")]
	partial class WorkerMainMenuTableCellViewController
	{
		[Outlet]
		UIKit.UILabel lblEnd { get; set; }

		[Outlet]
		UIKit.UILabel lblStart { get; set; }

		[Outlet]
		UIKit.UILabel lblTime { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblStart != null) {
				lblStart.Dispose ();
				lblStart = null;
			}

			if (lblEnd != null) {
				lblEnd.Dispose ();
				lblEnd = null;
			}

			if (lblTime != null) {
				lblTime.Dispose ();
				lblTime = null;
			}
		}
	}
}

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
	[Register ("WorkerTableCellViewController")]
	partial class WorkerTableCellViewController
	{
		[Outlet]
		UIKit.UIButton btnDetails { get; set; }

		[Outlet]
		UIKit.UILabel lblAmount { get; set; }

		[Outlet]
		UIKit.UILabel lblHours { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblHours != null) {
				lblHours.Dispose ();
				lblHours = null;
			}

			if (lblAmount != null) {
				lblAmount.Dispose ();
				lblAmount = null;
			}

			if (btnDetails != null) {
				btnDetails.Dispose ();
				btnDetails = null;
			}
		}
	}
}

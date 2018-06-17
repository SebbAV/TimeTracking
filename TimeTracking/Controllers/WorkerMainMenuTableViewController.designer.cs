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
	[Register ("WorkerMainMenuTableViewController")]
	partial class WorkerMainMenuTableViewController
	{
		[Outlet]
		UIKit.UINavigationBar navWorker { get; set; }

		[Action ("logout_TouchUpInside:")]
		partial void logout_TouchUpInside (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (navWorker != null) {
				navWorker.Dispose ();
				navWorker = null;
			}
		}
	}
}

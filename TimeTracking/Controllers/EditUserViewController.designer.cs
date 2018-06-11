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
	[Register ("EditUserViewController")]
	partial class EditUserViewController
	{
		[Outlet]
		UIKit.UITextField lblAmount { get; set; }

		[Outlet]
		UIKit.UITextField lblName { get; set; }

		[Outlet]
		UIKit.UITextField lblPosition { get; set; }

		[Outlet]
		UIKit.UITextField lblRfid { get; set; }

		[Action ("editUser_TouchUpInside:")]
		partial void editUser_TouchUpInside (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblRfid != null) {
				lblRfid.Dispose ();
				lblRfid = null;
			}

			if (lblAmount != null) {
				lblAmount.Dispose ();
				lblAmount = null;
			}

			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}

			if (lblPosition != null) {
				lblPosition.Dispose ();
				lblPosition = null;
			}
		}
	}
}

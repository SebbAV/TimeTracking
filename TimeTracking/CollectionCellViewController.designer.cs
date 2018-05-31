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
	[Register ("CollectionCellViewController")]
	partial class CollectionCellViewController
	{
		[Outlet]
		UIKit.UIButton btnChangeStatus_TouchUpInside { get; set; }

		[Outlet]
		UIKit.UIImageView imgUser { get; set; }

		[Outlet]
		UIKit.UILabel lblName { get; set; }

		[Outlet]
		UIKit.UILabel lblPosition { get; set; }

		[Outlet]
		UIKit.UILabel lblStatus { get; set; }

		[Action ("btnDelete_TouchUpInside:")]
		partial void btnDelete_TouchUpInside (Foundation.NSObject sender);

		[Action ("btnEdit_TouchUpInside:")]
		partial void btnEdit_TouchUpInside (Foundation.NSObject sender);

		[Action ("btnEnableEdit_TouchUpInside:")]
		partial void btnEnableEdit_TouchUpInside (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imgUser != null) {
				imgUser.Dispose ();
				imgUser = null;
			}

			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}

			if (lblPosition != null) {
				lblPosition.Dispose ();
				lblPosition = null;
			}

			if (lblStatus != null) {
				lblStatus.Dispose ();
				lblStatus = null;
			}

			if (btnChangeStatus_TouchUpInside != null) {
				btnChangeStatus_TouchUpInside.Dispose ();
				btnChangeStatus_TouchUpInside = null;
			}
		}
	}
}

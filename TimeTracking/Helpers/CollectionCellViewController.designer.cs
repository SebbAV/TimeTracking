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
        UIKit.UIButton btnDelete { get; set; }

        [Outlet]
        UIKit.UIButton btnEdit { get; set; }

        [Outlet]
        UIKit.UIButton btnGoOnline { get; set; }

        [Outlet]
        UIKit.UIImageView imgUser { get; set; }

        [Outlet]
        UIKit.UILabel lblName { get; set; }

        [Outlet]
        UIKit.UILabel lblPosition { get; set; }

        [Outlet]
        UIKit.UILabel lblStatus { get; set; }

        [Action ("btnEnableEdit_TouchUpInside:")]
        partial void btnEnableEdit_TouchUpInside (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (btnChangeStatus_TouchUpInside != null) {
                btnChangeStatus_TouchUpInside.Dispose ();
                btnChangeStatus_TouchUpInside = null;
            }

            if (imgUser != null) {
                imgUser.Dispose ();
                imgUser = null;
            }

            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }

            if (btnEdit != null) {
                btnEdit.Dispose ();
                btnEdit = null;
            }

            if (btnDelete != null) {
                btnDelete.Dispose ();
                btnDelete = null;
            }

            if (btnGoOnline != null) {
                btnGoOnline.Dispose ();
                btnGoOnline = null;
            }

            if (lblPosition != null) {
                lblPosition.Dispose ();
                lblPosition = null;
            }

            if (lblStatus != null) {
                lblStatus.Dispose ();
                lblStatus = null;
            }
        }
    }
}

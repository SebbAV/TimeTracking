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
    [Register ("AddUserViewController")]
    partial class AddUserViewController
    {
        [Outlet]
        UIKit.UITextField lblAmount { get; set; }

        [Outlet]
        UIKit.UITextField lblEmail { get; set; }

        [Outlet]
        UIKit.UITextField lblName { get; set; }

        [Outlet]
        UIKit.UITextField lblPassword { get; set; }

        [Outlet]
        UIKit.UITextField lblPosition { get; set; }

        [Outlet]
        UIKit.UITextField lblRfid { get; set; }

        [Outlet]
        UIKit.UISwitch switchAdmin { get; set; }

        [Action ("AddUser_TouchUpInside:")]
        partial void AddUser_TouchUpInside (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (lblEmail != null) {
                lblEmail.Dispose ();
                lblEmail = null;
            }

            if (lblPassword != null) {
                lblPassword.Dispose ();
                lblPassword = null;
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

            if (lblRfid != null) {
                lblRfid.Dispose ();
                lblRfid = null;
            }

            if (switchAdmin != null) {
                switchAdmin.Dispose ();
                switchAdmin = null;
            }
        }
    }
}

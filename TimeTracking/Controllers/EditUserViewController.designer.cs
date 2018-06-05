// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TimeTracking
{
    [Register ("EditUserViewController")]
    partial class EditUserViewController
    {
        [Outlet]
        UIKit.UILabel LblPosition { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LblPosition != null) {
                LblPosition.Dispose ();
                LblPosition = null;
            }
        }
    }
}
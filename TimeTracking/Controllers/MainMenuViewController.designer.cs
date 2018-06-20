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
	[Register ("MainMenuViewController")]
	partial class MainMenuViewController
	{
		[Outlet]
		UIKit.UICollectionView CollectionView { get; set; }

		[Action ("logOut_TouchUpInside:")]
		partial void logOut_TouchUpInside (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CollectionView != null) {
				CollectionView.Dispose ();
				CollectionView = null;
			}
		}
	}
}

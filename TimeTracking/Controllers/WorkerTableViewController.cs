// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

using System.Collections.Generic;
using Firebase.Database;

namespace TimeTracking
{
	public partial class WorkerTableViewController : UITableViewController
	{

        DatabaseReference workers,root,time_tracking;

		public WorkerTableViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView.Delegate = this;
            TableView.DataSource = this;
            root = Database.DefaultInstance.GetRootReference();
            workers = root.GetChild("team_members");
            time_tracking = root.GetChild("time_tracking");



        }

        public List<Employee> loadUsers(){
            
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("workerTable", indexPath);
            cell.TextLabel.Text = "hi";
            return cell;
        }
        public override nint RowsInSection(UITableView tableView, nint section){
            return 1;
        }
        [Export("numberOfSectionsInTableView:")]
        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

    }
}

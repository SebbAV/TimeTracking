// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TimeTracking
{
	public partial class WorkerMainMenuTableViewController : UITableViewController
	{
        Employee employee_details;
        public Employee Employee
        {
            get;
            set;
        }
        public WorkerMainMenuTableViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            employee_details = Employee;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath){
            var cell = tableView.DequeueReusableCell("WorkerDetail", indexPath);
            cell.TextLabel.Text = employee_details.WorkedTime[indexPath.Row].Start_Date.ToString();
            return cell;
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return employee_details.WorkedTime.Count;
        }
        [Export("numberOfSectionsInTableView:")]
        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }
        [Export("tableView:titleForHeaderInSection:")]
        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return "";
        }
	}
}

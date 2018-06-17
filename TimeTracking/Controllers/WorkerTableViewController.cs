// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

using System.Collections.Generic;
using Firebase.Database;
using TimeTracking.Models;

namespace TimeTracking
{
	public partial class WorkerTableViewController : UITableViewController
	{
        #region Class Variables
        static readonly int section_number = 1;
        DatabaseReference root, time_trackingNode, userNode;
        TimeTrackingClass timeTracking;
        List<string> key_list;
        List<TimeTrackingClass> lst_timetracking;
        List<Employee> lst_Employees;
        public  EventHandler getEmployee_Handler;
        Employee selected_employee;
        #endregion


		public WorkerTableViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Calls methods to load the required information.
            initializeView();
            loadUsersAsync();



        }
        public override void ViewWillAppear(bool animated)
        {
            loadUsers();
        }
        /// <summary>
        /// Method to initialize the lists and firebase node references.
        /// </summary>
        public void initializeView(){
            lst_timetracking = new List<TimeTrackingClass>();
            key_list = new List<string>();
            lst_Employees = new List<Employee>();
            TableView.Delegate = this;
            TableView.DataSource = this;

            root = Database.DefaultInstance.GetRootReference();
            time_trackingNode = root.GetChild("time_tracking");
            userNode = root.GetChild("team_members");
        }
        public void loadUsersAsync()
        {
            try
            {
                userNode.ObserveEvent(DataEventType.ChildChanged, (snapshot,prev) =>
                {
                    //Gets the recieved information from the event.
                    var data = snapshot.GetValue<NSDictionary>();
                   string name =  data.ValueForKey(new NSString("name")).ToString();
                    string id = data.ValueForKey(new NSString("id")).ToString();
                    string fare = data.ValueForKey(new NSString("fare")).ToString();
                    var index = lst_Employees.FindIndex(x => x.Id.Contains(id));
                    if(index != -1){
                        lst_Employees[index].Name = name;
                        lst_Employees[index].Fare = double.Parse(fare);
                        loadUserTimes();  
                    }



                }, (error) =>
                {
                    Console.WriteLine(error.LocalizedDescription);
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //Method to load the users.
       public void loadUsers(){
            lst_Employees = new List<Employee>();
            try
            {
                userNode.ObserveSingleEvent(DataEventType.Value, (snapshot) =>
                {
                    //Gets the recieved information from the event.
                    var data = snapshot.GetValue<NSDictionary>();
                    var employees = data.Values;
                    //For each eployee found in the team_members users. It adds it to our global list.
                    foreach (var employee in employees)
                    {
                        Employee temp_employee = new Employee();
                        temp_employee.Name = employee.ValueForKey(new NSString("name")).ToString();
                        temp_employee.Id = employee.ValueForKey(new NSString("id")).ToString();
                        temp_employee.RFID = employee.ValueForKey(new NSString("rfid")).ToString();
                        temp_employee.Position = employee.ValueForKey(new NSString("position")).ToString();
                        temp_employee.Fare = Double.Parse(employee.ValueForKey(new NSString("fare")).ToString());

                        lst_Employees.Add(temp_employee);

                    }
                    //Calls the method loadUsertimes once the employees list has been updated.
                    loadUserTimes();


                }, (error) =>
                {
                    Console.WriteLine(error.LocalizedDescription);
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void loadUserTimesOnchange(){
            time_trackingNode.ObserveEvent(DataEventType.ChildAdded, (snapshot) =>
            {
                var data = snapshot.GetValue<NSDictionary>();
            });
        }
        /// <summary>
        /// Method to create a single event to check for values in the timetracking node.
        ///This contains all the dates that the employees has work.
        /// </summary>
        public void loadUserTimes(){
            time_trackingNode.ObserveSingleEvent(DataEventType.Value, (snapshot) =>
            {
            var data = snapshot.GetValue<NSDictionary>();
            //Gets the keys for each user in the table.
            var keys = data.Keys;
                key_list = new List<string>();
                foreach (var key in keys)
                {

                    double employee_payment = 0;
                    //Looks for the key in the data received from the event and returns it as a dictionary.
                    var user_data = data.ValueForKey(new NSString(key.ToString())) as NSDictionary;
                    //Looks for the key in the users list. Returns an index, if it not found this should return a -1
                    var index = lst_Employees.FindIndex(x => x.Id.Contains(key.ToString()));

                    if (index != -1)
                    {
                        //Looks for the user and returns it as an Employee class object
                        Employee temp_employee = lst_Employees.Find(x => x.Id.Contains(key.ToString()));
                        //Adds the key to the temporary list.
                        key_list.Add(key.ToString());
                        var autogen_keys = user_data.Keys;
                        var autogen_values = user_data.Values;
                        temp_employee.FortNightWorkedTime = new TimeSpan(0,0,0);
                        foreach (var time in autogen_values)
                        {
                            //Gets the information found in the time_tracking node. This also calculates the worked time of the user and stores it into
                            //a list
                            timeTracking = new TimeTrackingClass();
                            timeTracking.End_Date = DateTime.Parse(time.ValueForKey(new NSString("end_date")).ToString());
                            timeTracking.Start_Date = DateTime.Parse(time.ValueForKey(new NSString("start_date")).ToString());
                            

                            DateTime currentDate = DateTime.Now;
                            if (currentDate.Month == timeTracking.Start_Date.Month)
                            {
                                if (timeTracking.Start_Date.Day < 15 && currentDate.Day < 15)
                                {

                                    TimeSpan worked_time = (timeTracking.End_Date - timeTracking.Start_Date);
                                    employee_payment += Math.Round(worked_time.TotalHours, 2);
                                    temp_employee.FortNightWorkedTime += worked_time;
                                    lst_timetracking.Add(timeTracking);
                                }


                                if (currentDate.Day > 15 && timeTracking.Start_Date.Day > 15)
                                {
                                    TimeSpan worked_time = (timeTracking.End_Date - timeTracking.Start_Date);
                                    employee_payment += Math.Round(worked_time.TotalHours, 2);
                                    temp_employee.FortNightWorkedTime += worked_time;
                                    lst_timetracking.Add(timeTracking);

                                }
                            }
                        }
                        employee_payment = 0;  
                        temp_employee.WorkedTime = lst_timetracking;
                        //Finds the employee in the current index and update the information of the employee
                        lst_Employees[index] = temp_employee;
                        lst_timetracking = new List<TimeTrackingClass>();   
                    }

                }
                TableView.ReloadData();
            });
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(WorkerTableCellViewController.key, indexPath) as WorkerTableCellViewController;
            cell.GetCell(indexPath.Section, ClickHandler);
            lst_Employees[indexPath.Section].Payment = Math.Round(lst_Employees[indexPath.Section].Fare * lst_Employees[indexPath.Section].FortNightWorkedTime.TotalHours,2);
            cell.LblAmount = $"${lst_Employees[indexPath.Section].Payment}";
            cell.LblHours = $"{lst_Employees[indexPath.Section].FortNightWorkedTime.TotalHours}";


            return cell;
        }

        void ClickHandler(WorkerTableCellViewController sender, CustomEventArgs args)
        {
            var cell = sender as WorkerTableCellViewController;

            if (cell != null)
            {
                if (lst_Employees.Count < 1)
                {

                }
                else
                {
                    //Gets the information of the selected employee and calls the segue to send the information to view 
                    //more details about that employee
                    selected_employee = new Employee();
                    selected_employee.Id = lst_Employees[args.Position].Id;
                    selected_employee.Name = lst_Employees[args.Position].Name;
                    selected_employee.WorkedTime = lst_Employees[args.Position].WorkedTime;
                    selected_employee.Payment = lst_Employees[args.Position].Payment;
                    PerformSegue("Worker_Details", null);
                }
            }

            var yourArgs = args as CustomEventArgs;

            if (yourArgs != null)
            {
                // do stuff
            }
        }


        //This method can't be bigger than 1
        public override nint RowsInSection(UITableView tableView, nint section) =>  section_number;

        [Export("numberOfSectionsInTableView:")]
        public override nint NumberOfSections(UITableView tableView) =>  lst_Employees.Count;

        [Export("tableView:titleForHeaderInSection:")]
        public override string TitleForHeader(UITableView tableView, nint section) =>  lst_Employees[(int)section].Name;




        /// <summary>
        /// Detects when a segue is being called. This allows to add information to the next view controllers while the next view is loading.
        /// </summary>
        /// <param name="segue">Segue.</param>
        /// <param name="sender">Sender.</param>
        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier != "Worker_Details")
                return;
            (segue.DestinationViewController as WorkerMainMenuTableViewController).Employee = selected_employee ;


        }


    }
    //Interal is used to allow the access to this delegate just to this asssembly
    internal delegate void CustomEventHandler(WorkerTableCellViewController sender, CustomEventArgs args);
}


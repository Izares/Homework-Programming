﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAppLogic
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public interface IUser
    {
        string UserName { get; }
        string Password { get; }
    }

    public interface ILoggedinUser
    {
        IUser User { get; }
    }

    public interface ITask
    {
        string Title { get; set; }
        string Description { get; set; }
        IUser AssignedTo { get; set; }
        DateTime Due { get; set; }
        Priority Priority { get; set; }
    }

    public interface IUserDatabase
    {
        ILoggedinUser Login(string username, string password);
        IUser GetUser(string username);
        void AddUser(string username, string password);
    }

    public interface ITaskDatabase
    {
        IEnumerable<ITask> GetTasks(IUser user);
        ITask NewTask();
        void SaveTask(ITask task);
    }
}

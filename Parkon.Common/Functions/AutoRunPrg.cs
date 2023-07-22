using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskScheduler;
using Microsoft.Win32;
using Prkn.Common.Variables;

namespace Prkn.Common.Functions
{
    public class AutoRunPrg
    {
        #region TaskSucheduler Register
        public static void TaskStart(string AppName)
        {
            TaskScheduler.TaskScheduler scheduler = new TaskScheduler.TaskScheduler();
            scheduler.Connect();

            ITaskDefinition definition = scheduler.NewTask(0);
            definition.RegistrationInfo.Author = "IDEMIR";
            definition.RegistrationInfo.Description = "" + AppName + " (AutoRun)";
            definition.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
            definition.Settings.StartWhenAvailable = true;
            definition.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_BOOT); //TASK_TRIGGER_LOGON

            IExecAction action = (IExecAction)definition.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            action.Path = Global.ProgramDizin.App_Path;

            scheduler.GetFolder("\\").RegisterTaskDefinition("" + AppName, definition, 6, Type.Missing, Type.Missing, TaskScheduler._TASK_LOGON_TYPE.TASK_LOGON_NONE); //TASK_LOGON_NONE
        }

        public static void TaskDisable(string AppName)
        {
            TaskScheduler.TaskScheduler scheduler = new TaskScheduler.TaskScheduler();
            scheduler.Connect();

            ITaskDefinition definition = scheduler.NewTask(0);
            definition.RegistrationInfo.Author = "IDEMIR";
            definition.RegistrationInfo.Description = "" + AppName + " (AutoRun)";
            definition.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
            definition.Settings.StartWhenAvailable = true;
            definition.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_BOOT); //TASK_TRIGGER_LOGON

            IExecAction action = (IExecAction)definition.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            action.Path = Global.ProgramDizin.App_Path;

            scheduler.GetFolder("\\").RegisterTaskDefinition("" + AppName, definition, 8, Type.Missing, Type.Missing, TaskScheduler._TASK_LOGON_TYPE.TASK_LOGON_NONE);
        }
        #endregion

        #region Register Program to Start With Windows

        public static void AddApplicationToStartup(string AppName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("" + AppName, "\"" + Global.ProgramDizin.App_Path + "\"");
            }
        }

        public static void RemoveApplicationFromStartup(string AppName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("" + AppName, false);
            }
        }

        #endregion
    }
}

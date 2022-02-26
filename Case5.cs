﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace FirstT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Case5 recording.
    /// </summary>
    [TestModule("0538221c-0e85-48ff-9570-20ba4e02aae2", ModuleType.Recording, 1)]
    public partial class Case5 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskRonwellRepo repository.
        /// </summary>
        public static TaskRonwellRepo repo = TaskRonwellRepo.Instance;

        static Case5 instance = new Case5();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case5()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case5 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Trendyol Website launched..
            Report.Log(ReportLevel.Info, "Website", "Trendyol Website launched..\r\nOpening web site 'https://www.trendyol.com/laptop-x-c103108' with browser 'Chrome' in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.trendyol.com/laptop-x-c103108", "Chrome", "", false, true, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.FvrtBtn4' at 9;18.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.FvrtBtn4Info, new RecordItemIndex(1));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.FvrtBtn4.Click("9;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Header' at 664;226.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.HeaderInfo, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Header.Click("664;226");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.FvrtBtn' at 22;24.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.FvrtBtnInfo, new RecordItemIndex(3));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.FvrtBtn.Click("22;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Favorilerim' at 11;16.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.FavorilerimInfo, new RecordItemIndex(4));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Favorilerim.Click("11;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Favorilerim1' at 52;13.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Favorilerim1Info, new RecordItemIndex(5));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Favorilerim1.Click("52;13");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

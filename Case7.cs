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
    ///The Case7 recording.
    /// </summary>
    [TestModule("9439082b-fe87-4953-994f-cdb4373b85a7", ModuleType.Recording, 1)]
    public partial class Case7 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TaskRonwellRepo repository.
        /// </summary>
        public static TaskRonwellRepo repo = TaskRonwellRepo.Instance;

        static Case7 instance = new Case7();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case7()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case7 Instance
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
            Report.Log(ReportLevel.Info, "Website", "Trendyol Website launched..\r\nOpening web site 'https://www.trendyol.com' with browser 'Chrome' in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.trendyol.com", "Chrome", "", false, true, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.CıkışYap' at 20;23.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.CıkışYapInfo, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.CıkışYap.Click(System.Windows.Forms.MouseButtons.Right, "20;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.BağlantıyıYeniSekmedeAc' at 27;6.", repo.Chrome.BağlantıyıYeniSekmedeAcInfo, new RecordItemIndex(3));
            repo.Chrome.BağlantıyıYeniSekmedeAc.Click("27;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.CıkışYap' at 37;17.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.CıkışYapInfo, new RecordItemIndex(4));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.CıkışYap.Click("37;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.LrContainer.TrendyolaGirişYapVeyaHesapOluştur' at 250;17.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LrContainer.TrendyolaGirişYapVeyaHesapOluşturInfo, new RecordItemIndex(5));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LrContainer.TrendyolaGirişYapVeyaHesapOluştur.Click("250;17");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

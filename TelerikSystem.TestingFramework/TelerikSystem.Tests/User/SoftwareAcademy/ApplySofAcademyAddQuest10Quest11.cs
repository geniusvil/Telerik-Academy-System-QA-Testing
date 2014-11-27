﻿namespace TelerikSystem.Tests.User.SoftwareAcademy
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage;

    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;
 //   using NUnit.Framework;

    [TestClass]
    public class ApplySofAcademyAddQuest10Quest11 : BaseTest
    {
        private TestingFramework.Core.Models.User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.NotFillApplicationForm();
            this.currentUser.Username = "ccccc";
            this.currentUser.Password = "123456";
        }

        #region[Question10]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
     //   [TestCase(143)]
        public void ApplySofAcademy_AssertMainErrorMessageQ10_NoSelection()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyAsQ10_NoSelection();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
   //     [TestCase(144)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ10_NoSelection()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyAsQ10_NoSelection();
        }

       // [Microsoft.VisualStudio.TestTools.UnitTesting.Ignore] // throws null referene
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
    //    [TestCase(226)]
        public void ApplySofAcademy_AssertMainErrorMessageQ10_Selected()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyAsQ10_Selected();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
    //    [TestCase(340)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ10_Selected()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyAsQ10_Selected();
        }
       
        #endregion

        #region[Question11]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
   //     [TestCase(342)]
        public void ApplySofAcademy_AssertMainErrorMessageQ11_NoSelection()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyAsQ11_NoSelection();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
    //    [TestCase(341)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ11_NoSelection()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyAsQ11_NoSelection();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
    //    [TestCase(146)]
        public void ApplySofAcademy_AssertMainErrorMessageQ11_Selected()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyAsQ11_Selected();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
    //    [TestCase(341)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ11_Selected()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyAsQ11_Selected();
        }
       
        #endregion
    }
}

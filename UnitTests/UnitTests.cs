using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using PupBuddy_CA2_OanaSorin;
using PupBuddy_CA2_OanaSorin.Models;
using PupBuddy_CA2_OanaSorin.Controllers;
using System.Web.Mvc;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CreatePuppy()
        {
            // PuppyModelsController puppy = new PuppyModelsController(  "chiuwawaaaawa", "oinc", "pettite", DateTime.Now);

            PuppyModel pupy = new PuppyModel();
            _ = ( 1, "", "chiuwawaaaawa", "oinc", "pettite", new DateTime(2020, 07, 03) );

        }

        [TestMethod()]
        public void PuppyView()
        {
            var createPuppy = new PuppyModelsController();
            var result = createPuppy.Create() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod]
        public void CreateMeetingTest()
        {
            MeetingController meeting = new MeetingController();
            _= (20, "Tick Removal", 5);
        }

        [TestMethod()]
        public void MeetingTestView()
        {
            var controller = new MeetingController();
            var result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("", result.ViewName);
        }

        public void EditMeetingTest()
        {
            MeetingModel meeting1 = new MeetingModel() { OutForWalk = new DateTime(2021, 04, 13), Location = "Tallaght", };
            MeetingModel meeting2 = new MeetingModel() { OutForWalk = new DateTime(2020, 12, 12), Location = "Tallaght" };

            PuppyModel meeting = new PuppyModel();
            meeting.PuppyID.Equals(meeting1.PuppyID);


            Assert.AreEqual(meeting, meeting1);
        }



    }
}


        

   
   
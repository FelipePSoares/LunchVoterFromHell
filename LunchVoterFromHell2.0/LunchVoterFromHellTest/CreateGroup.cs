using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using System.Collections.Generic;
using DomainService;
using Repository;
using Repository.Repository;
using Moq;

namespace LunchVoterFromHellTest
{
    [TestClass]
    public class CreateGroup : ObjectFactory
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
            this.GroupDomainService = this.GroupDomainServiceFactory();
        }

        [TestMethod]
        public void MustCreateGroup()
        {
            var group = new Group("Test", new Person("Test"), new List<Person>());
            group.Should().NotBeNull();
        }

        [TestMethod]
        public void MustReturnArgumentExceptionOnCreateGroupAndDontHaveName()
        {
            Action newInstance = () => new Group(string.Empty, new Person("Test"), new List<Person>());
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.ParamName == "Name");
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.Message.Contains("Name not entered."));
        }

        [TestMethod]
        public void MustReturnArgumentExceptionOnCreateGroupWithoutOwner()
        {
            Action newInstance = () => new Group("Name Group", null, new List<Person>());
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.ParamName == "Owner");
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.Message.Contains("Owner not entered."));
        }

        [TestMethod]
        public void MustReturnArgumentExceptionOnCreateGroupWithInexistentOwner()
        {
            var group = new Group("Name Group", new Person("Test"), new List<Person>());
            Action newInstance = () => this.GroupDomainService.Add(group);
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.ParamName == "Owner");
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.Message.Contains("Owner is inexistent."));
        }

        [TestMethod]
        public void MustChangeNameGroup()
        {
            // Arrange
            var person = new Person("Test");
            var group = new Group("Test", person, new List<Person> { person });
            this.GroupRepositoryMock.Setup(e => e.ChangeName(It.IsAny<Group>())).Returns(group);
            this.GroupRepositoryMock.Setup(e => e.GetByID<Group>(It.IsAny<Int32>())).Returns(group);
            this.GroupRepositoryMock.Setup(e => e.GetByID<Person>(It.IsAny<Int32>())).Returns(person);

            // Act
            group.Name = "new Test";
            group = this.GroupDomainService.ChangeName(group, person);

            //Assert
            group.Name.Should().Be("new Test");
        }

        [TestMethod]
        public void MustChangeGroupNameIfYouIsOwner()
        {
            // Arrange
            var person = new Person("Test") { Id = 1 };
            var group = new Group("Test", person, new List<Person> { person });
            this.GroupRepositoryMock.Setup(e => e.ChangeName(It.IsAny<Group>())).Returns(group);
            this.GroupRepositoryMock.Setup(e => e.GetByID<Group>(It.IsAny<Int32>())).Returns(group);
            this.GroupRepositoryMock.Setup(e => e.GetByID<Person>(It.IsAny<Int32>())).Returns(person);

            // Act
            group.Name = "new Test";
            group = this.GroupDomainService.ChangeName(group, person);

            //Assert
            group.Name.Should().Be("new Test");
        }

        [TestMethod]
        public void MustReturnArgumentExceptionOnChangeGroupNameIfYouIsNotAOwner()
        {
            // Arrange
            var person = new Person("Test") { Id = 1 };
            var secondPerson = new Person("Teste 2") { Id = 2 };
            var group = new Group("Test", person, new List<Person> { person });
            this.GroupRepositoryMock.Setup(e => e.ChangeName(It.IsAny<Group>())).Returns(group);
            this.GroupRepositoryMock.Setup(e => e.GetByID<Group>(It.IsAny<Int32>())).Returns(group);
            this.GroupRepositoryMock.Setup(e => e.GetByID<Person>(It.IsAny<Int32>())).Returns(secondPerson);

            // Act
            group.Name = "new Test";
            Action newInstance = () => this.GroupDomainService.ChangeName(group, secondPerson);

            //Assert
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.ParamName == "Owner");
            newInstance.ShouldThrow<ArgumentException>().Where(a => a.Message.Contains("This person does not Own."));
        }

        [TestMethod]
        public void MustAddParticipantOnGroup()
        {
            var newPerson = new Person("New Person");
            var group = new Group("Test", new Person("Test"), new List<Person>());
            group.Should().NotBeNull();

            group.Participants.Add(newPerson);
            this.GroupDomainService.AddParticipant(group, newPerson);
        }

        [TestMethod]
        public void MustReturnArgumentExceptionOnAddInexistentParticipantsOnGroup()
        {
            var newPerson = new Person("New Person");
            var group = new Group("Test", new Person("Test"), new List<Person>());
            group.Should().NotBeNull();

            group.Participants.Add(newPerson);
            this.GroupDomainService.AddParticipant(group, newPerson);
        }
        
        [TestMethod]
        public void MustDeleteGroup()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustAddOthersPeopleOnGroup()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustAddOthersPeopleOnGroupAndHaveOnlyOneOwner()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MustChangeOwner()
        {
            Assert.Inconclusive();
        }
    }
}

using DomainService;
using DomainService.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchVoterFromHellTest
{
    [TestClass]
    public class ObjectFactory
    {
        protected Mock<IGroupRepository> GroupRepositoryMock { get; set; }
        protected IGroupBO GroupDomainService { get; set; }

        public virtual void Initialize()
        {
            this.GroupRepositoryMock = new Mock<IGroupRepository>();
        }

        protected IGroupBO GroupDomainServiceFactory()
        {
            return new GroupBO(this.GroupRepositoryMock.Object);
        }
    }
}

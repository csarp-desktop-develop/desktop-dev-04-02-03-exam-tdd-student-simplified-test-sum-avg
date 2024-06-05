using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Desktop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreta.Desktop.Repos;
using Moq;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class AwardedStudentServiceTests
    {
        private readonly AwardedStudentService _awardedStudentService;
        private readonly Mock<IAwardedStudentRepo> _awardedStudentRepoMock = new Mock<IAwardedStudentRepo>();

        public AwardedStudentServiceTests()
        {
            _awardedStudentService = new AwardedStudentService(_awardedStudentRepoMock.Object);
        }
    }
}
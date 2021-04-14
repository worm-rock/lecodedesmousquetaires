using System;
using Xunit;
using FluentAssertions;


namespace HelloJenkins.UnitTests
{
    public class HelloJenkinsTests
    {
        [Fact]
        public void Test1()
        {
            true.Should().BeTrue();
        }
    }
}

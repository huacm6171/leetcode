// <copyright file="_541ReverseStrTest.cs">Copyright ©  2018</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode;

namespace leetcode.Tests
{
    /// <summary>此类包含 _541ReverseStr 的参数化单元测试</summary>
    [PexClass(typeof(_541ReverseStr))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class _541ReverseStrTest
    {
    }
}

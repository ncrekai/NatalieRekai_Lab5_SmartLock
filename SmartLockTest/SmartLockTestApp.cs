using System.Collections.Generic;
using leetgrind;

namespace SmartLockTest
{
    [TestClass]
    public sealed class LockTests
    {
        private SmartLock smartLock = new SmartLock();

        // Current state: Initial - Test methods EnterCode(good), EnterCode(bad), Lock(), Reset()
        [TestMethod]
        public void InitialState_EnterCodeGood()
        {
            string expected = "Unlocked";

            smartLock.EnterCode("1234");
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void InitialState_EnterCodeBad()
        {
            string expected = "Locked";

            smartLock.EnterCode("5678");
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void InitialState_Lock()
        {
            string expected = "Locked";

            smartLock.Lock();
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void InitialState_Reset()
        {
            string expected = "Locked";

            smartLock.Reset();
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        // Current state: Locked - Test methods EnterCode(good), EnterCode(bad), Lock(), Reset()
        [TestMethod]
        public void LockedState_EnterCodeGood()
        {
            string expected = "Unlocked";

            smartLock.Lock();
            smartLock.EnterCode("1234");
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void LockedState_EnterCodeBad()
        {
            string expected = "Locked";

            smartLock.Lock();
            smartLock.EnterCode("5678");
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void LockedState_Lock()
        {
            string expected = "Locked";

            smartLock.Lock();
            smartLock.Lock();
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void LockedState_Reset()
        {
            string expected = "Locked";

            smartLock.Lock();
            smartLock.Reset();
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        // Current state: Unlocked - Test methods EnterCode(good), EnterCode(bad), Lock(), Reset()
        [TestMethod]
        public void UnlockedState_EnterCodeGood()
        {
            string expected = "Unlocked";

            smartLock.EnterCode("1234");
            smartLock.EnterCode("1234");
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void UnlockedState_EnterCodeBad()
        {
            string expected = "Unlocked";

            smartLock.EnterCode("1234");
            smartLock.EnterCode("5678");
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void UnlockedState_Lock()
        {
            string expected = "Locked";

            smartLock.EnterCode("1234");
            smartLock.Lock();
            Assert.AreEqual(expected, smartLock.GetLockState());
        }

        [TestMethod]
        public void UnlockedState_Reset()
        {
            string expected = "Locked";

            smartLock.EnterCode("1234");
            smartLock.Reset();
            Assert.AreEqual(expected, smartLock.GetLockState());
        }
    }
}
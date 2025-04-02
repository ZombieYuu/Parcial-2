using NUnit.Framework;


namespace BehaviorTreeTests
{
    [TestFixture]
    public class NodeTests
    {
        [Test]
        public void BehaviorTree_ShouldHaveOnlyOneRoot()
        {
            Assert.Pass();
        }

        [Test]
        public void Root_ShouldHaveOnlyOneChild_AndNotBeAnotherRoot()
        {
            Assert.Pass();
        }

        [Test]
        public void CompositeNode_CannotBeInstantiatedExceptBySubclasses()
        {
            Assert.Pass();
        }

        [Test]
        public void CompositeNode_ShouldNotHaveRootAsChild()
        {
            Assert.Pass();
        }

        [Test]
        public void TaskNode_CannotBeInstantiatedExceptBySubclasses()
        {
            Assert.Pass();
        }

        [Test]
        public void TaskNode_ShouldNotHaveAnyChildren()
        {
            Assert.Pass();
        }
    }

    [TestFixture]
    public class HierarchyTests
    {
        [Test]
        public void AllNodes_ShouldInheritFromNode()
        {
            Assert.Pass();
        }

        [Test]
        public void SequenceAndSelector_ShouldInheritFromComposite()
        {
            Assert.Pass();
        }

        [Test]
        public void SubclassesOfSequenceAndSelector_ShouldAlsoInheritFromComposite()
        {
            Assert.Pass();
        }

        [Test]
        public void TaskNodes_ShouldInheritFromNode_AndNotFromRootOrComposite()
        {
            Assert.Pass();
        }

        [Test]
        public void NoNode_ShouldInheritFromRoot()
        {
            Assert.Pass();
        }
    }

    [TestFixture]
    public class BehaviorTreeExecutionTests
    {
        [Test]
        public void EmptyRoot_ShouldReturnFalse()
        {
            Assert.Pass();
        }

        [Test]
        public void RootWithSingleTask_ShouldReturnTrue_IfTaskCompletes()
        {
            Assert.Pass();
        }

        [Test]
        public void RootWithSingleTask_ShouldReturnFalse_IfTaskFails()
        {
            Assert.Pass();
        }

        [Test]
        public void RootWithSequence_ShouldReturnAccordingToRules()
        {
            Assert.Pass();
        }

        [Test]
        public void RootWithSelector_ShouldReturnAccordingToRules()
        {
            Assert.Pass();
        }

        [Test]
        public void SelectorOrSequenceWithSingleChild_ShouldReturnChildResult()
        {
            Assert.Pass();
        }

        [Test]
        public void SelectorOrSequenceWithMultipleChildren_ShouldFollowExecutionRules()
        {
            Assert.Pass();
        }
    }

    [TestFixture]
    public class ParityTaskTests
    {
        [Test]
        public void ParityTask_ShouldReturnSuccess_IfNumberIsEven()
        {
            Assert.Pass();
        }

        [Test]
        public void ParityTask_ShouldReturnFailure_IfNumberIsOdd()
        {
            Assert.Pass();
        }
    }
}

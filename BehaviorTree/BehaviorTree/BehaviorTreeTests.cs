using NUnit.Framework;
using BehaviorTree;
using NUnit.Framework.Legacy;


namespace BehaviorTreeTests
{
    [TestFixture]
    public class NodeTests
    {
        [Test]
        public void BehaviorTree_ShouldHaveOnlyOneRoot()
        {
            var tree = new BehaviourTree();
            ClassicAssert.IsNotNull(tree.Root);
        }

        [Test]
        public void Root_ShouldHaveOnlyOneChild_AndNotBeAnotherRoot()
        {
            var root = new Root();
            var childRoot = new Root();
            Assert.Throws<System.InvalidOperationException>(() => root.SetChild(childRoot));
        }
    }

    [TestFixture]
    public class HierarchyTests
    {
        [Test]
        public void SequenceAndSelector_ShouldInheritFromComposite()
        {
            ClassicAssert.IsTrue(typeof(Composite).IsAssignableFrom(typeof(Sequence)));
            ClassicAssert.IsTrue(typeof(Composite).IsAssignableFrom(typeof(Selector)));
        }
    }

    [TestFixture]
    public class BehaviorTreeExecutionTests
    {
        [Test]
        public void EmptyRoot_ShouldReturnFalse()
        {
            var tree = new BehaviourTree();
            ClassicAssert.IsFalse(tree.Execute());
        }

        [Test]
        public void RootWithSingleTask_ShouldReturnTrue_IfTaskCompletes()
        {
            var tree = new BehaviourTree();
            tree.Root.SetChild(new ParityTask(2));
            ClassicAssert.IsTrue(tree.Execute());
        }

        [Test]
        public void RootWithSingleTask_ShouldReturnFalse_IfTaskFails()
        {
            var tree = new BehaviourTree();
            tree.Root.SetChild(new ParityTask(3));
            ClassicAssert.IsFalse(tree.Execute());
        }
    }

    [TestFixture]
    public class ParityTaskTests
    {
        [Test]
        public void ParityTask_ShouldReturnSuccess_IfNumberIsEven()
        {
            var task = new ParityTask(4);
            ClassicAssert.IsTrue(task.Execute());
        }

        [Test]
        public void ParityTask_ShouldReturnFailure_IfNumberIsOdd()
        {
            var task = new ParityTask(5);
            ClassicAssert.IsFalse(task.Execute());
        }
    }
}

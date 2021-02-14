using BinarySearchTreeNameSpace;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        BinarySearchTree<int> BinaryTree;

        [SetUp]
        public void Setup()
        {
            BinaryTree = new BinarySearchTree<int>();
        }

        [Test]
        public void Given3Nodes_WhenAddedToBinaryTree_ShouldReturnSizeTh()
        {           
            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);

            Assert.AreEqual(56, BinaryTree.GetRoot);
            Assert.AreEqual(30, BinaryTree.GetRootLeft);
            Assert.AreEqual(70, BinaryTree.GetRootRight);
        }

        [Test]
        public void Given13Nodes_WhenAddedToBinaryTree_ShouldReturnSize13()
        {
            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(11);
            BinaryTree.AddNode(63);
            BinaryTree.AddNode(67);
            BinaryTree.AddNode(16);
            BinaryTree.AddNode(60);
            BinaryTree.AddNode(95);
            BinaryTree.AddNode(65);
            BinaryTree.AddNode(3);

            int Size = BinaryTree.GetSize();
            Assert.AreEqual(13, Size);
            Assert.AreEqual(56, BinaryTree.GetRoot);
        }
    }
}
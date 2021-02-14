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
        public void Given3Numbers_WhenAddedToBinaryTree_ShouldReturnSizeTh()
        {           
            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);

            Assert.AreEqual(56, BinaryTree.GetRoot);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queues;

namespace QueuesTests
{
    [TestClass]
    public class QueueUsingTwoStacksTests
    {
        private static QueueUsingTwoStacks<int>_queue ;

        [TestInitialize]
        public void Init()
        {
            _queue = new QueueUsingTwoStacks<int>();
        }

        [TestMethod]
        public void TestMethod1()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);

            Assert.AreEqual(1, _queue.Dequeue());
            Assert.AreEqual(2, _queue.Dequeue());
            Assert.AreEqual(3, _queue.Dequeue());
        }

        [TestMethod]
        public void TestMethod2()
        {
            // using will make sure the file is closed
            using (System.IO.StreamReader input = new System.IO.StreamReader(@"..\..\QueueUsingTwoStacksData\\input1.txt"))
            {
                using (System.IO.StreamReader output = new System.IO.StreamReader(@"..\..\QueueUsingTwoStacksData\\output1.txt"))
                {
                    var count = int.Parse(input.ReadLine());

                    for(var i = 0; i < count; i++)
                    {
                        var commands = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                        switch (commands[0])
                        {
                            case 1:
                                _queue.Enqueue(commands[1]);
                                break;

                            case 2:
                                _queue.Dequeue();
                                break;

                            case 3:
                                Assert.AreEqual(int.Parse(output.ReadLine()), _queue.Peek());
                                break;
                        }
                    }
                }
            }
        }

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        //public void TestMethod2()
        //{
        //    _queue.Dequeue();
        //}
    }
}

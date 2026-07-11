using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following value and priority: Serious (2), Critical (3), Minor (1) and run
    // until queue is empty.
    // Expected Result: Critical, Serious, Minor
    // Defect(s) Found: Items were not being removed from the queue when Dequeue() was called
    public void TestPriorityQueue_1()
    {
        var serious = new PriorityItem("Serious", 2);
        var critical = new PriorityItem("Critical", 3);
        var minor = new PriorityItem("Minor", 1);

        PriorityItem[] expectedResult = [critical, serious, minor];

        PriorityQueue priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(serious.Value, serious.Priority);
        priorityQueue.Enqueue(critical.Value, critical.Priority);
        priorityQueue.Enqueue(minor.Value, minor.Priority);


        int i = 0;

        while (priorityQueue.Count > 0)
        {
            if (i > expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }

    }

    [TestMethod]
    // Scenario: Create a queue with the following value and priority: Minor (1), Critical (3), Important (2), Imperative (3), Serious (2), Noteworthy (1)
    // and run until the queue is empty
    // Expected Result: Critical, Imperative, Important, Serious, Minor, Noteworthy
    // Defect(s) Found: Code was set up to take the last item in the queue with the highest priority instead of the first item in the queue
    // with the highest priority
    public void TestPriorityQueue_2()
    {
        var minor = new PriorityItem("Minor", 1);
        var critical = new PriorityItem("Critical", 3);
        var important = new PriorityItem("Important", 2);
        var imperative = new PriorityItem("Imperative", 3);
        var serious = new PriorityItem("Serious", 2);
        var noteworthy = new PriorityItem("Noteworthy", 1);

        PriorityItem[] expectedResult = [critical, imperative, important, serious, minor, noteworthy];

        PriorityQueue priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(minor.Value, minor.Priority);
        priorityQueue.Enqueue(critical.Value, critical.Priority);
        priorityQueue.Enqueue(important.Value, important.Priority);
        priorityQueue.Enqueue(imperative.Value, imperative.Priority);
        priorityQueue.Enqueue(serious.Value, serious.Priority);
        priorityQueue.Enqueue(noteworthy.Value, noteworthy.Priority);



        int i = 0;

        while (priorityQueue.Count > 0)
        {
            if (i > expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }

    }


    [TestMethod]
    // Scenario: Create a queue with the following value and priority: Math (3), English (3), History(3), Science (3) and run
    // until queue is empty to test whether items are added to the queue correctly.
    // Expected Result: Math, English, History, Science
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var math = new PriorityItem("Math", 3);
        var english = new PriorityItem("English", 3);
        var history = new PriorityItem("History", 3);
        var science = new PriorityItem("Science", 3);

        PriorityItem[] expectedResult = [math, english, history, science];

        PriorityQueue priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(math.Value, math.Priority);
        priorityQueue.Enqueue(english.Value, english.Priority);
        priorityQueue.Enqueue(history.Value, history.Priority);
        priorityQueue.Enqueue(science.Value, science.Priority);


        int i = 0;

        while (priorityQueue.Count > 0)
        {
            if (i > expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }

    }

    // Add more test cases as needed below.
}
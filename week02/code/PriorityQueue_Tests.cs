using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  Enqueue multiple items with varying priorities and dequeue to check order
    // Expected Result:Items with higher priority are dequeued first
    // Defect(s) Found:If the implementation only considers FIFO, high priority items might come out late 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority", 1);
        priorityQueue.Enqueue("Medium Priority 1", 5);
        priorityQueue.Enqueue("High Priority", 10);
        priorityQueue.Enqueue("Medium Priority 2", 5);

        Assert.AreEqual("High Priority", priorityQueue.Dequeue());
        Assert.AreEqual("Medium Priority 1", priorityQueue.Dequeue()); 
        Assert.AreEqual("Medium Priority 2", priorityQueue.Dequeue());
        Assert.AreEqual("Low Priority", priorityQueue.Dequeue());
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First in line", 5);
        priorityQueue.Enqueue("Second in line", 5);
        priorityQueue.Enqueue("Third in line", 5);

        Assert.AreEqual("First in line", priorityQueue.Dequeue());
        Assert.AreEqual("Second in line", priorityQueue.Dequeue());
        Assert.AreEqual("Third in line", priorityQueue.Dequeue());
        Assert.Fail("Implement the test case and then remove this.");
    }
    

    // Add more test cases as needed below.

     [TestMethod]
    // Scenario: Enqueue a single item and dequeue it.
    // Expected Result: The item is dequeued successfully.
    // Defect(s) Found: Basic functionality check.
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Only Item", 10);
        Assert.AreEqual("Only Item", priorityQueue.Dequeue());
    }
}
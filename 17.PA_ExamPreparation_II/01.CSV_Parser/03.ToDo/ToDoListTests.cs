using System;
using System.Globalization;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        //Arrange
        this._toDoList.AddTask("The task 1", DateTime.Today);
       

        //Act
        string result = this._toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Does.Contain("[ ] The task 1 - Due:"));


    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    { 
        //Arrange
        this._toDoList.AddTask("The task 1", DateTime.Today);


        //Act
        this._toDoList.CompleteTask("The task 1");
        string result = this._toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Does.Contain("[✓] The task 1 - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        //Arrange
        string taskName = "task 2";


        //Act & Assert
        Assert.That(() => this._toDoList.CompleteTask(taskName), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        //Arrange

        //Act
       string result = this._toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        //Arrange
        this._toDoList.AddTask("The task 1", DateTime.Today);
        this._toDoList.AddTask("The task 2", DateTime.Today);


        //Act
        this._toDoList.CompleteTask("The task 1");
        string result = this._toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Does.Contain("To-Do List:"));
        Assert.That(result, Does.Contain("[✓] The task 1 - Due:"));
        Assert.That(result, Does.Contain("[ ] The task 2 - Due:"));
    }
}

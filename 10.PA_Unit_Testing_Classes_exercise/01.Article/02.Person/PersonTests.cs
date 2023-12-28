using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{

    private Person _person;

    [SetUp]
    public void SetUp()
    {
        this._person = new Person();
    }


    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new()
        {
            new Person { Name = "Alice", Id = "A001", Age = 35},
            new Person { Name = "Bob", Id = "B002", Age = 30},
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
       
        List<Person> peopleData = new()
        {
            new Person { Name = "Viki", Id = "1", Age = 25},
            new Person { Name = "Bob", Id = "2", Age = 30},
            new Person { Name = "Alice", Id = "3", Age = 35}
        };

        string expected = $"Viki with ID: 1 is 25 years old.{Environment.NewLine}" +
            $"Bob with ID: 2 is 30 years old.{Environment.NewLine}" +
            $"Alice with ID: 3 is 35 years old.";

        // Act
        string actual = this._person.GetByAgeAscending(peopleData);

        // Assert
        Assert.AreEqual(expected, actual);
       
    }
}

using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Reflection;
using NUnit.Framework;
using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;

    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }

    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        //Arrange
        this._chatRoom.SendMessage("Ivan", "Hello!");

        //Act
        string result = this._chatRoom.DisplayChat();

        //Assert
        Assert.That(result, Does.Contain($"Chat Room Messages:{Environment.NewLine}" +
        $"Ivan: Hello! - Sent at"));
        StringAssert.Contains("Ivan", result);
        StringAssert.Contains("Hello!", result);
    }


    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        //Arrange
      

        //Act
        string result = this._chatRoom.DisplayChat();
       

        //Assert
        //Assert.AreEqual(result.Trim(), "Chat Room Messages:");
        //Assert.That(result, Does.Contain("Chat Room Messages:"));
        //Assert.That(result.Length, Is.EqualTo(19));
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        //Arrange
        this._chatRoom.SendMessage("Ivan", "Hello!");
        this._chatRoom.SendMessage("Pesho", "Hi");
        this._chatRoom.SendMessage("Sasho", "Goog morning");

        //Act
        string result = this._chatRoom.DisplayChat();

        //Assert
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Ivan: Hello! - Sent at"));
        Assert.That(result, Does.Contain("Pesho: Hi - Sent at"));
        Assert.That(result, Does.Contain("Sasho: Goog morning - Sent at"));
        StringAssert.Contains("Ivan: Hello!", result);
        StringAssert.Contains("Pesho: Hi", result);
        StringAssert.Contains("Sasho: Goog morning", result);

    }


}

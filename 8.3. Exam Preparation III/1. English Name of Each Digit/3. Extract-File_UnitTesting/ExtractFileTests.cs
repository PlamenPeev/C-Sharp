using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        //Arrange
        string? path = null;

        //Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = "";

        //Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "dance@mail.bg";

        //Act
        string result = ExtractFile.GetFile(path);

        //Assert
        Assert.That(result, Is.EqualTo("File name: dance@mail\nFile extension: bg"));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = "dance@mail";

        //Act
        string result = ExtractFile.GetFile(path);

        //Assert
        Assert.That(result, Is.EqualTo("File name: dance@mail"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "dance_bg@mail.bg";

        //Act
        string result = ExtractFile.GetFile(path);

        //Assert
        Assert.That(result, Is.EqualTo("File name: dance_bg@mail\nFile extension: bg"));
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;


namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string item = "Walk the dog.";
      Item newItem = new Item(item);

      //Act
      string result = newItem.GetItem();

      //Assert
      Assert.AreEqual(item, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string item01 = "Walk the dog.";
      string item02 = "Wash the dishes.";
      Item newItem1 = new Item(item01);
      Item newItem2 = new Item(item02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      //Act
      List<Item> result = Item.GetAll();
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output: " + thisItem.GetItem());
      }

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
    public void Dispose()
    {
      Item.ClearAll();
    }
  }
}

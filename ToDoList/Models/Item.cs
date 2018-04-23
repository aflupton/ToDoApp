using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public static List<Item> _instances = new List<Item> {};
    private string _description;
    private string _date;
    private string _memo;
    private string _importance;
    private int _id;


    public Item(string description, string date = "0", string memo = "null", string importance = "null")
      {
        _description = description;
        _date = date;
        _memo = memo;
        _importance = importance;
        _id = _instances.Count;
      }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetDate()
    {
      return _date;
    }

    public void SetDate(string newDate)
    {
      _date = newDate;
    }

    public string GetMemo()
    {
      return _memo;
    }

    public void SetMemo(string newMemo)
    {
      _memo = newMemo;
    }

    public string GetImportance()
    {
      return _importance;
    }

    public void SetImportance(string newImportance)
    {
      _importance = newImportance;
    }

    public int GetId()
    {
      return _id + 1;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}

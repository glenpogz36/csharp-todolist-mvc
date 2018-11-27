using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Parcel
  {
    
    private string _material;
    private string _width;
    private string _height;
    private string _weight;
    private int _cost;
  


    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(string material, string width, string height, string weight)
    {
      _material = material;
      _width = width;
      _height = height;
      _weight = weight;
      _cost = (int.Parse(height) * int.Parse(width))/2 * int.Parse(weight)/2 ;
     
    }

    public string GetMaterial()
    {
      return _material;
    }

    public void SetMaterial(string newMaterial)
    {
      _material= newMaterial;
    }

     public string GetWidth()
    {
      return _width;
    }

    public void SetWidth(string newWidth)
    {
      _width = newWidth;
    }

     public string GetHeight()
    {
      return _height;
    }

    public void SetHeight(string newHeight)
    {
      _height = newHeight;
    }

     public string GetWeight()
    {
      return _weight;
    }

    public void SetWeight(string newWeight)
    {
      _weight = newWeight;
    }

       public int GetCost()
    {
      return _cost;
    }

    public void SetCost(int newCost)
    {
      _cost = newCost;
    }
    

    public static List<Parcel> GetAll()
    {
      return _instances;
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

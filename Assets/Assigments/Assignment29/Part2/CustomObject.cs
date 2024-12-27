using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment29.Part2
{
    public class CustomObject
    {
        // Start is called before the first frame update
        private int _ID;
        private string _Name;

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public CustomObject(int id, string name)
        {
            this._Name = name;
            this._ID = id;

        }
        public override string ToString()
        {
            return $"Object [ID: {_ID}, Name: {_Name}]";
        }

        // public override bool Equals(object obj)
        // {
        //     CustomObject ob = obj as CustomObject;

        //     if (ob == null) return false;
        //     if (ob._ID == _ID && ob._Name == _Name) return true;
        //     return false;


        // }

        public static bool operator ==(CustomObject a, CustomObject b)
        {
            if (a.Equals(null) && b.Equals(null)) return true; // same type with no data to point to 
            if (a.Equals(null) || b.Equals(null)) return false; // one points to an address and the other doesn't
            if (a.ID == b.ID && a.Name == b.Name) return true; // both point to and address and both contain same data
            return false;


        }

        public static bool operator !=(CustomObject a, CustomObject b)
        {
            if (a.Equals(null) && b.Equals(null)) return false; // same type with no data to point to 
            if (a.Equals(null) || b.Equals(null)) return true; // one points to an address and the other doesn't
            if (a.ID == b.ID && a.Name == b.Name) return false; // both point to and address and both contain same data
            return true;

        }
    }
}

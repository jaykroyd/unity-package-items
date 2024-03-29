﻿using System;
using UnityEngine.Events;

namespace Elysium.Items
{
    public interface IItemStack
    {
        Guid ID { get; }
        bool IsEmpty { get; }
        bool IsFull { get; }
        IItem Item { get; }
        int Quantity { get; }

        event UnityAction OnValueChanged;
        event UnityAction OnFull;
        event UnityAction OnEmpty;

        void Add(int _quantity);
        void Empty();
        void Remove(int _quantity);
        void Set(IItem _item);
        void Set(IItem _item, int _value);
        void Set(int _value);
        void SwapContents(IItemStack _target);
        bool Use(IItemUser _user, int _numOfTimes = 1);
        string ToString();        
    }
}

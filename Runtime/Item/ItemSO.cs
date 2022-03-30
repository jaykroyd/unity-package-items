using System;
using System.IO;
using UnityEngine;
using static System.Text.Encoding;

namespace Elysium.Items
{
    [CreateAssetMenu(fileName = "ItemSO_", menuName = "Scriptable Objects/Inventory/Item")]
    public class ItemSO : ScriptableObject, IItem
    {
        [SerializeField] private string itemName = default;
        [SerializeField] private Sprite icon = default;
        [SerializeField] private int maxStack = 1;
        [SerializeField] private bool usable = false;

        public Guid ItemID => Guid.NewGuid();
        public Guid InstanceID => Guid.NewGuid();
        public string Name => itemName;
        public Sprite Icon => icon;
        public int MaxStack => maxStack;
        public bool IsUsable => usable;        
    }
}
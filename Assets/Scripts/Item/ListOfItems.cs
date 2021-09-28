using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Create New Items List", order = 2, fileName = "ListOfItems")]
public class ListOfItems : ScriptableObject
{
    [SerializeField] private List<Item> m_items = new List<Item>();
    public List<Item> Items => m_items;

}

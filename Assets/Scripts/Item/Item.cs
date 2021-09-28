using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Items/Create New Item", order = 1, fileName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField] private int m_id;
    public int Id => m_id;

    [SerializeField] private string m_name;
    public string Name => m_name;

    [SerializeField] private Texture m_icon;
    public Texture Icon => m_icon;

    [SerializeField] private GameObject m_prefab;
    public GameObject Prefab => m_prefab;

}

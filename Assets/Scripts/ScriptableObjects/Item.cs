﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class Item : ScriptableObject  {

    public Sprite itemSprite;
    public int id;
    public string itemDescription;
    public bool isKey;

}

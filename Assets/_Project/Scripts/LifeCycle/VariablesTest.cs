using System;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    [SerializeField] public int shopIndex = 8;

    #region INCAPSULAMENTO
    //INCAPSULAMENTO
    public int ShopIndexBis { get; private set; }  //{get => ShopIndex; private set => shopIndex = 2;}
    public int ShopIndex => shopIndex; 
    
    public void SetShopIndexValue(int _shopIndex)
    {
        if(shopStateBase != ShopState.CLOSING)
        {
            shopIndex = _shopIndex;
        }
    }
    //
    #endregion

    [SerializeField] float shopRevenues = 50.5f;
    [SerializeField] bool shopOpen = false;
    
    public enum ShopState {OPENING = 0, SELLING, RESTOCKING, CLOSING};
    [SerializeField] ShopState shopStateBase = ShopState.OPENING;
    [SerializeField] ShopState shopStateAdvanced = ShopState.RESTOCKING;

    [SerializeField] string shopName = "shop";

    //Array bool+[] > nome variabile
    [SerializeField] int[] productArray = new int[5];

    [SerializeField] List<int> productList = new List<int>();

    //keys = nome prodotto, float = prezzo prodotto
    Dictionary<string, float> productDictionary = new Dictionary<string, float>();
    HashSet<Product> productsHashSet = new HashSet<Product>();

    [SerializeField] List<Product> productsList = new List<Product>();
}

[Serializable]
//variabili private = lettere iniziale minuscola; variabili pubbliche = lettera iniziale maiuscola
public class Product
{
    public string Name;
    public float Price;
}

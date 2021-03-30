using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondCounter : MonoBehaviour
{
    public static int hitungdiamond;
    Text hitungdiamondtext;
    void Start()
    {
        hitungdiamond = 0;
        hitungdiamondtext = GetComponent<Text>();
    }

    void Update()
    {
        hitungdiamondtext.text = hitungdiamond.ToString();
    }
}

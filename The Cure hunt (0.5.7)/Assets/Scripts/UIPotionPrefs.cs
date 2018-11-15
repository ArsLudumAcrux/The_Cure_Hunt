using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPotionPrefs : MonoBehaviour {


    public Hud_Menu hudmenu;
    public PotionScriptableObj potioninfo;
    public Image image;
    public PlayerScript player;
    public Text NamePotion;



    public void SetupPotion(PotionScriptableObj potion)
    {
        potioninfo = potion;
        image.sprite = potion.artwork;
        NamePotion.text = potion.name;
    }
    public void UsePotion()
    {
        player.UsePotion(potioninfo);
        hudmenu.UpdateListItens();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropCoin : MonoBehaviour
{

    public GameObject Coin;
    [Tooltip("Função PotionsDrop:\n0 = 5% chance de drop\n1 = 10% chance de drop\n2 = 12.5% chance de drop\n3 = 12.5% chance de drop\n4 = 15% chance de drop\n5 = 45% chance de drop")]
    [SerializeField]
    GameObject[] PotionsDrop;
    public float CoinPotion;


    private void Start()
    {
        //stats.GetComponent<Statistics>();
    }

    public void ChanceCoinPotion()
    {
        CoinPotion = Random.Range(0,2);
        if(CoinPotion == 0)
        {
            DroparMoeda();
        }
        else
        {
            DroparPotion();
        }
    }


    public void DroparMoeda()
    {
        int Drop = Random.Range(1, 5);
        print("Drop: " + Drop);
        if (Drop >= 0 && Drop <= 3)
        {
            Instantiate(Coin, transform.position, transform.rotation);
        }

    }
    public void DroparPotion()
    {
        float ChanceDropPotion = Random.Range(0f, 100f);


        if (ChanceDropPotion > 0 && ChanceDropPotion <= 5)
        {
            Instantiate(PotionsDrop[0], transform.position, Quaternion.identity);
        }
          else if (ChanceDropPotion > 5 && ChanceDropPotion <= 15)
        {
            Instantiate(PotionsDrop[1], transform.position, Quaternion.identity);
        }
        else if (ChanceDropPotion > 15 && ChanceDropPotion <= 27.5f)
        {
            Instantiate(PotionsDrop[2], transform.position, Quaternion.identity);
        }
        else if (ChanceDropPotion > 27.5 && ChanceDropPotion <= 40)
        {
            Instantiate(PotionsDrop[3], transform.position, Quaternion.identity);
        }
        else if (ChanceDropPotion > 40 && ChanceDropPotion <= 55)
        {
            Instantiate(PotionsDrop[4], transform.position, Quaternion.identity);
        }
        else if (ChanceDropPotion > 55 && ChanceDropPotion <= 100)
        {
            Instantiate(PotionsDrop[5], transform.position, Quaternion.identity);
        }



    }
}

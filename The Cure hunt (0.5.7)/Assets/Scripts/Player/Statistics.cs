using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{

    [Header("Status Player")]
    public string Nome;
    [SerializeField]
    public float HP_Max = 100;    
    public int Level;
    public float Exp;
    public float ExpAtual;
    public float XPToNextLevel;
    public int Gold;
    public float strongh;
    public Text LevelText;
    public Image levelup;


    [Header("Game Statistics")]
    public float TempoDeJogo;
   //public int InimigosMortos;
    public float HpPerdido;
   

    [Header("Confg. Coins")]
    public GameObject CopperCoin;
    public GameObject SilverCoin;
    public GameObject GoldCoin;
    public GameObject PearlCoin;
    public GameObject MithrilCoin;


    private int MoedaExp;
    private int MoedaGold;


    public Text CoinText;
    public Text CoinTextMenu;
    public Text CoinTextShadow;


    //public UnityEngine.UI.Text NameText;
    //public UnityEngine.UI.Text NameTextShadow;


    [Header("Sounds")]
    public AudioClip CoinSound;
    public AudioClip DmgSound;
    public AudioClip RecoverSound;
    public AudioClip LevelUp;
    private AudioSource source;

    [Header("Others")]
    public GameObject ObjectEnemy;
    Enemy_Dmg Damage;
    public Sword espada;
    public DropCoin dropcoin;
    

    Animator anim;
    
    public HealthBar HB;

    private void Start()
    {
        anim = GetComponent<Animator>();
        levelup.gameObject.SetActive(false);


        ExpAtual = 0;
        for (int i = 0; i < espada.Espadas.Length; i++)
        {
            espada.Espadas[i].gameObject.SetActive(false);
            espada.Cadeado[i].gameObject.SetActive(true);
            espada.EspadasBorrada[i].gameObject.SetActive(true);
        }
    }


    void Awake()
    {

        
        //Get and store a reference to the Rigidbody2D component so that we can access it.

        //Nome = PlayerPrefs.GetString("NomeDoPlayer");
        Gold = 0;
        Level = 1;
        ExpAtual = 0;
        LevelText.text = Level.ToString();
        XPToNextLevel = 32;
        TempoDeJogo = 0;
        


        PlayerPrefs.SetInt("GoldDoPlayer", Gold);
        PlayerPrefs.SetInt("LevelDoPlayer", Level);

        source = GetComponent<AudioSource>();
        //Damage = FindObjectOfType <Willow_Enemy> ();

        //Call our SetCountText function which will update the text with the current value for count.


    }


    void OnTriggerEnter2D(Collider2D col)
    {
            if (col.gameObject.CompareTag("Coin"))
        {
            int intCoinsText = int.Parse(CoinText.text);
            intCoinsText += 1;
            CoinText.text = intCoinsText.ToString();
            CoinTextMenu.text = intCoinsText.ToString();
            Destroy(col.gameObject);
        }

        
        if (col.gameObject.CompareTag("Enemy"))
        {
            source.PlayOneShot(DmgSound, 5.0f);
        }

    }


        // Update is called once per frame
        void Update () {

        //if (HB.HP_Current <= 0)
        //{
        //    anim.SetBool("Dead", true);
        //    Debug.Log("Player is DEAD!!!");
        //}


        //HP = ObjectEnemy.GetComponent<Willow_Enemy>().Vida;

        /*Essa variável mostra o tempo de jogo dentro do Inspector: */
        TempoDeJogo = TempoDeJogo + Time.deltaTime;


        //		PlayerPrefs.SetString ("NomeDoPlayer", Nome);
        //		if (Gold > PlayerPrefs.GetInt ("HighScore_Gold")) 
        //		{
        //			PlayerPrefs.SetInt ("HighScore_Gold", Gold);
        //			PlayerPrefs.SetInt ("HighScore_Nivel", Level);
        //			PlayerPrefs.SetString ("HighScore_Nome", Nome);
        //		}

        //		SceneManager.LoadScene("4-GameOver");
        //	} 
        //}
        //} 
        //} 
        //} 
        // ------------------------
        //	 LEVEL UP!	//

        //if (ExpAtual >= XPToNextLevel)
        //{
        //    Level = Level + 1;
        //    XPToNextLevel = Mathf.Round(XPToNextLevel + (XPToNextLevel * 1.63f));
        //    HP_Max = Mathf.Round(HP_Max * 1.05f);
        //    source.PlayOneShot(LevelUp, 1.0f);
        //    LevelText.text = Level.ToString();
        //    PlayerPrefs.SetInt("LevelDoPlayer", Level);
        //    Debug.Log("LevelDoPlayer" + Level);
        //    Debug.Log("Vida maxima atual: " + HP_Max);
        //}


        if (Level == 1)
        {
            espada.Cadeado[0].gameObject.SetActive(false);
            espada.EspadasBorrada[0].gameObject.SetActive(true);
            espada.Espadas[0].gameObject.SetActive(true);
        } else if(Level == 2)
        {
            espada.Cadeado[1].gameObject.SetActive(false);
            espada.EspadasBorrada[1].gameObject.SetActive(true);
            espada.Espadas[1].gameObject.SetActive(true);
        } else if(Level == 3)
        {
            espada.Cadeado[2].gameObject.SetActive(false);
            espada.EspadasBorrada[2].gameObject.SetActive(true);
            espada.Espadas[2].gameObject.SetActive(true);
        } else if(Level == 4)
        { 
            espada.Cadeado[3].gameObject.SetActive(false);
            espada.EspadasBorrada[3].gameObject.SetActive(true);
            espada.Espadas[3].gameObject.SetActive(true);
        }
        


    }
    public void LevelAtual()
    {
        if(Level == 1)
        {
            levelup.gameObject.SetActive(true);
            Invoke("UparLevel", 2f);
        }
        else if (Level == 2)
        {
            levelup.gameObject.SetActive(true);
            Invoke("UparLevel", 2f);
        }
        else if (Level == 3)
        {
            levelup.gameObject.SetActive(true);
            Invoke("UparLevel", 2f);
        }
        else if (Level == 4)
        {
            levelup.gameObject.SetActive(true);
            Invoke("UparLevel", 2f);
        }

    }
       public void UparLevel()
    {
        levelup.gameObject.SetActive(false);
    }
    
    //public void Experiencia(int xpMin, int xpMax)
    //{
    //    int Exp = Random.Range(xpMin, xpMax);
    //    ExpAtual += Exp;
    //    experiencia_img.fillAmount = ExpAtual / Exp;
    //    print("Experiencia Ganha:"+ Exp);
    //    print("Experiencia atual:"+ ExpAtual);
    //}
}
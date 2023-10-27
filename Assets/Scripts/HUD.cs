using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int health;
    public int coinCount;
    
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI coinText;

    public List<int> destroyedObjects = new List<int>();
    // Awake is called before start
    void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        coinCount = 0;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount;
        healthText.text = "Health: " + health;
    }
}
